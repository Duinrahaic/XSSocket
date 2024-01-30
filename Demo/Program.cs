using System.Drawing;
using System.Drawing.Imaging;
using System.Net.WebSockets;
using XSSocket.Models;

namespace Demo;
using XSSocket;
public class Program
{
    
    private static XSSocket connector;
    
    public static async Task Main(string[] args)
    {
        connector = new XSSocket("Demo");
        connector.ConnectAsync().ConfigureAwait(false);
        while (connector.State == WebSocketState.Connecting)
        {
            Console.WriteLine("Connecting...");
            await Task.Delay(1000); // wait 1 second
        }
        if (connector.State == WebSocketState.Open)
        {
            Console.WriteLine("Connected!");
        }
        else
        {
            Console.WriteLine($"Connection failed with state: {connector.State}");
        }

        Console.WriteLine("Sending Notification...");
        
        
        XSNotificationObject notificationObject =
            new XSNotificationObject()
            {
                title = "Hello World",
                content = "This is a test notificationObject",
                sourceApp = "Demo"
            };
        await connector.SendNotification(notificationObject);
        await Task.Delay(3000); // wait 3 second
        
        Console.WriteLine("Subscribing to events...");
        //await connector.SubscribeToEvents(new(){});

        connector.OnStateChanged += state =>
        {
            Console.WriteLine($"State changed to: {state}");
        };
        
        connector.OnDataRecieved += data =>
        {
            Console.WriteLine($"Data received: {data.command}");
            
            if (data is XSUpdateAvatar avatar)
            {
                Image? i = avatar.GetPng(); 
                if(i != null)
                    i.Save("avatar.png", ImageFormat.Png);
            }
            else if (data is XSUpdateDateTime datetime)
            {
                DateTime? dt = datetime.CurrentDateTime;
                TimeSpan? ts = datetime.SessionLength;
                Console.WriteLine($"Date: {dt?.ToShortDateString() ?? string.Empty} Time: {dt?.ToShortTimeString() ?? string.Empty} Session Length: {ts?.ToString() ?? string.Empty}");
            }
            else if (data is XSUpdateTheme theme)
            {
                Console.WriteLine($"Theme: {theme.HiTone ?? string.Empty} {theme.MidTone ?? string.Empty} {theme.DarkTone ?? string.Empty} {theme.ContrastingTone ?? string.Empty} {theme.ErrorTone ?? string.Empty} {theme.WarningTone ?? string.Empty} {theme.ConfirmTone ?? string.Empty} {theme.AccentColor ?? string.Empty} {theme.AccentColorBright ?? string.Empty}");
            }
            else if (data is XSUpdateDeviceInformation deviceInformation)
            {
                List<XSDevice> devices = deviceInformation.GetDevices();
                foreach (XSDevice device in devices)
                {
                    Console.WriteLine($"Device: {device.FriendlyName}");
                }
            }
            else if (data is XSUpdateLayoutMode layoutMode)
            {
                Console.WriteLine($"Layout Open: {(!layoutMode.IsLayoutModeOpen.HasValue ? "Unknown" : layoutMode.IsLayoutModeOpen.Value.ToString())}");
            }
            else if (data is XSUpdateMediaPlayer mediaPlayer)
            {
                Console.WriteLine($"Media Player: {mediaPlayer.Title}" );
            }
            else if (data is XSUpdateSettings settings)
            {
                Console.WriteLine($"Settings Version: {settings.GetSettings()?.VersionNumber}" );
            }
            else if (data is XSUpdateLanguageList language)
            {
                var languages = language.GetLanguageMap();
                Console.WriteLine($"Languages: {language.GetLanguageMap()?.Count}" );
            }
            else if (data is XSUpdatedLanguageMap languageMap)
            {
                var languages = languageMap.GetLanguageMap();
                Console.WriteLine($"Languages Translations: {languageMap.GetLanguageMap()?.Count}" );
            }
            else if (data is XSUpdateAcheivementStatus achievements)
            {
                Console.WriteLine($"Achievement Unlocked: {achievements.GetAchievements()?.Count(x=>x.Value == true)}/{achievements.GetAchievements()?.Count} " );

            }
            else if (data is XSUpdateWindowList windowList)
            {
                var windows = windowList.GetWindowList();
                Console.WriteLine($"Windows List: {windowList.GetWindowList()?.Count}" );
            }
            else if (data is XSUpdateRuntimePerformance perfStats)
            {
                var stats = perfStats.GetPerformanceStats();
                Console.WriteLine($"CPU Load: {stats?.CPU.Load}%" );
            }
            else if (data is XSUpdateOverlayIDs overlays)
            {
                var id = overlays.GetOverlays();
                Console.WriteLine($"Overlays: {overlays.GetOverlays()?.Count}" );
            }
        };
        await connector.SubscribeToEvents();

        await Task.Delay(3000); // wait 3 second
        Console.WriteLine("Unsubscribe to events...");

        
        await connector.UnsubscribeToEvents();
        
        
        await Task.Delay(10000*30); // wait 3 second

        Console.WriteLine("Disconnecting...");

        connector.Disconnect();

    }
}