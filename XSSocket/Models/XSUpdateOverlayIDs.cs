namespace XSSocket.Models;

public class XSUpdateOverlayIDs : XSApiObject
{
    public XSUpdateOverlayIDs()
    {
    }

    public XSUpdateOverlayIDs(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateOverlayIDs(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public Dictionary<string, ulong>? GetOverlays()
    {
        return GetJsonData<Dictionary<string, ulong>>();
    }
}