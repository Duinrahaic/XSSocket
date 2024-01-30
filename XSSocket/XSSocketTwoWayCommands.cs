using XSSocket.Models;

namespace XSSocket;

public partial class XSSocket
{
    /// <summary>
    /// Returns the current date and time, including session length, formatted based on User Setting.
    /// </summary>
    public async Task RequestDateTime()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestDateTime";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Returns the current theme colors in hexadecimal format.
    /// </summary>
    public async Task RequestThemeUpdate()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestThemeUpdate";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns the steam avatar of the user.
    /// <param name="size"> Represents the requested size of the avatar image. If nothing is submitted the size of the image is 'medium'. </param> 
    /// </summary>
    public async Task RequestSteamAvatar(AvatarSize? size = null)
    {
        size = size ?? AvatarSize.Medium;
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestSteamAvatar";
        obj.rawData = size.Value.ToString().ToLower();
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Returns a list of devices and information about those devices.
    /// </summary>
    public async Task RequestDeviceInformation()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestDeviceInformation";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns the current open / closed state of Layout Mode.
    /// </summary>
    public async Task RequestLayoutModeState()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestLayoutModeState";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Returns the current media information.
    /// </summary>
    public async Task RequestMediaPlayerUpdate()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestMediaPlayerUpdate";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Returns user settings for the overlay.
    /// </summary>
    public async Task RequestGetSettings()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestGetSettings";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns the list of possible languages.
    /// </summary>
    public async Task RequestUpdatedLanguageList()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestUpdatedLanguageList";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns the map of strings for the currently selected language.
    /// </summary>
    public async Task RequestUpdatedLanguageMap()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestUpdatedLanguageMap";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns list of achievements with a boolean for unlocked / locked for the user.
    /// </summary>
    public async Task RequestAchievementInformation()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestAchievementInformation";
        await SendAsync(obj);
    }

    /// <summary>
    /// Returns a list of windows that can be captured.
    /// </summary>
    public async Task RequestWindowList()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestWindowList";
        await SendAsync(obj);
    }

    /// <summary>
    /// Requests the current active overlay. This is the overlay that has ownership of the window toolbar.
    /// </summary>
    public async Task RequestActiveOverlayInformation()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestActiveOverlayInformation";
        await SendAsync(obj);
    }

    /// <summary>
    /// Requests information about system resource usage, such as CPU, GPU, and Memory.
    /// </summary>
    public async Task RequestRuntimePerformance()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestRuntimePerformance";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Requests the lists of overlays and their ids.
    /// </summary>

    public async Task RequestOverlayIDs()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestOverlayIDs";
        await SendAsync(obj);
    }
}