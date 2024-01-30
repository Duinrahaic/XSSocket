using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using XSSocket.Models;

namespace XSSocket;

public partial class XSSocket : IDisposable
{
    public delegate void DataRecieved(XSApiObject data);

    public delegate void StateChanged(WebSocketState state);

    private const int _receiveBufferSize = 2048 * 4;
    private readonly CancellationTokenSource _cts = new();

    private ClientWebSocket? _client;

    public XSSocket(string appName, int webSocketPort = 42070)
    {
        WebSocketPort = webSocketPort;
        if (string.IsNullOrEmpty(appName)) throw new Exception("App name cannot be empty!");
        AppName = appName;
    }

    public bool IsConnected => _client?.State == WebSocketState.Open;
    public WebSocketState State => _client?.State ?? WebSocketState.None;

    public int WebSocketPort { get; }
    public string AppName { get; } = string.Empty;

    private Uri _uri => new($@"ws://localhost:{WebSocketPort}/?client={AppName}");

    public void Dispose()
    {
        Disconnect();
    }

    public event StateChanged? OnStateChanged;
    public event DataRecieved? OnDataRecieved;

    public async Task ConnectAsync()
    {
        if (_client != null)
            _client.Dispose();
        _client = new ClientWebSocket();

        await _client.ConnectAsync(_uri, _cts.Token);

        var buffer = new ArraySegment<byte>(new byte[_receiveBufferSize]);
        OnStateChanged?.Invoke(_client.State);
        while (_client.State == WebSocketState.Open)
            try
            {
                WebSocketReceiveResult result;

                using (var ms = new MemoryStream())
                {
                    do
                    {
                        result = await _client.ReceiveAsync(buffer, CancellationToken.None);
                        if (buffer.Array != null)
                            ms.Write(buffer.Array, buffer.Offset, result.Count);
                    } while (!result.EndOfMessage);

                    ms.Seek(0, SeekOrigin.Begin);

                    if (result.MessageType == WebSocketMessageType.Text)
                        using (var reader = new StreamReader(ms, Encoding.UTF8))
                        {
                            var data = await reader.ReadToEndAsync();
                            var apiObject = JsonSerializer.Deserialize<XSApiObject>(data);
                            if (apiObject == null)
                                return;

                            if (apiObject.command == "UpdateSteamAvatar")
                                apiObject = JsonSerializer.Deserialize<XSUpdateAvatar>(data);
                            else if (apiObject.command == "UpdateDateTime")
                                apiObject = JsonSerializer.Deserialize<XSUpdateDateTime>(data);
                            else if (apiObject.command == "UpdateTheme")
                                apiObject = JsonSerializer.Deserialize<XSUpdateTheme>(data);
                            else if (apiObject.command == "UpdateDeviceInformation")
                                apiObject = JsonSerializer.Deserialize<XSUpdateDeviceInformation>(data);
                            else if (apiObject.command == "UpdateLayoutModeState")
                                apiObject = JsonSerializer.Deserialize<XSUpdateLayoutMode>(data);
                            else if (apiObject.command == "UpdateMediaPlayer")
                                apiObject = JsonSerializer.Deserialize<XSUpdateMediaPlayer>(data);
                            else if (apiObject.command == "UpdateSettings")
                                apiObject = JsonSerializer.Deserialize<XSUpdateSettings>(data);
                            else if (apiObject.command == "UpdateLanguageList")
                                apiObject = JsonSerializer.Deserialize<XSUpdateLanguageList>(data);
                            else if (apiObject.command == "UpdateLanguageMap")
                                apiObject = JsonSerializer.Deserialize<XSUpdatedLanguageMap>(data);
                            else if (apiObject.command == "UpdateAchievementStatus")
                                apiObject = JsonSerializer.Deserialize<XSUpdateAcheivementStatus>(data);
                            else if (apiObject.command == "UpdateWindowList")
                                apiObject = JsonSerializer.Deserialize<XSUpdateWindowList>(data);
                            else if (apiObject.command == "UpdateRuntimePerformance")
                                apiObject = JsonSerializer.Deserialize<XSUpdateRuntimePerformance>(data);
                            else if (apiObject.command == "UpdateOverlayIDs")
                                apiObject = JsonSerializer.Deserialize<XSUpdateOverlayIDs>(data);
                            if (apiObject == null)
                                return;
                            OnDataRecieved?.Invoke(apiObject);
                        }
                }

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await _client.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, _cts.Token);
                    OnStateChanged?.Invoke(_client.State);
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                _client.Abort();
                OnStateChanged?.Invoke(_client.State);
            }
    }

    public async Task SendAsync(XSApiObject apiDataObject)
    {
        if (_client == null) throw new Exception("Client is not connected!");
        var bytes = Encoding.UTF8.GetBytes(apiDataObject.ToJson());
        await _client.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
    }


    public void Disconnect()
    {
        if (_client != null)
        {
            _client.Abort();
            _cts.Cancel();
            _client = null;
        }
    }
}