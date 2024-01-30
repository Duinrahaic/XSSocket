using System.Runtime.InteropServices;
using System.Text.Json;
using XSSocket.Models;

namespace XSSocket;

public partial class XSSocket
{
    /// <summary>
    /// Toggles layout mode on or off.
    /// </summary>
    public async Task ToggleLayoutMode()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "ToggleLayoutMode";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Toggles performance overlay on or off.
    /// </summary>
    public async Task TogglePerformanceStats()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "TogglePerformanceStats";
        await SendAsync(obj);
    }

    /// <summary>
    /// Creates an overlay
    /// </summary>
    public async Task Create()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "Create";
        await SendAsync(obj);
    }

    /// <summary>
    /// Re-centers the overlay space.
    /// </summary>
    public async Task Recenter()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "Recenter";
        await SendAsync(obj);
    }

    /// <summary>
    /// Summons / dismisses the keyboard.
    /// </summary>
    public async Task Keyboard()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "Keyboard";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Summons / dismisses the layout folder.
    /// </summary>
    public async Task Layouts()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "Layouts";
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Summons / dismisses settings panel.
    /// </summary>
    public async Task Settings()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "Settings";
        await SendAsync(obj);
    }

    /// <summary>
    /// Deletes all active overlays.
    /// </summary>
    public async Task DeleteAll()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "DeleteAll";
        await SendAsync(obj);
    }

    /// <summary>
    /// Toggles on and off grid view.
    /// </summary>
    public async Task WindowSwitcher()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "WindowSwitcher";
        await SendAsync(obj);
    }

    /// <summary>
    /// Play/Pauses the media player.
    /// </summary>
    public async Task MediaPlayPause()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "MediaPlayPause";
        await SendAsync(obj);
    }
    /// <summary>
    ///  Goes to the previously played song on the media player.
    /// </summary>
    public async Task MediaPrevious()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "MediaPrevious";
        await SendAsync(obj);
    }

    /// <summary>
    ///  Skips to the next song on the media player.
    /// </summary>
    public async Task MediaNext()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "MediaPrevious";
        await SendAsync(obj);
    }

    /// <summary>
    ///  Toggles if the window settings panel is visible.
    /// </summary>
    public async Task WindowSettings()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "MediaPrevious";
        await SendAsync(obj);
    }

    /// <summary>
    ///  Toggles if the window select panel is visible.
    /// </summary>
    public async Task WindowSelect()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "WindowSelect";
        await SendAsync(obj);
    }

    /// <summary>
    /// Deletes the overlay that has ownership of the window toolbar.
    /// </summary>
    public async Task WindowDelete()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "WindowDelete";
        await SendAsync(obj);
    }

    /// <summary>
    /// Updates the media player information.
    /// <param name='mediaPlayerObject'> is the object that contains the information about the media player. </param>
    /// </summary>
    public async Task UpdateMediaPlayerInformation(XSMediaPlayerObject mediaPlayerObject)
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "UpdateMediaPlayerInformation";
        obj.jsonData = JsonSerializer.Serialize(mediaPlayerObject);
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Sets a user settings.
    /// <a target="_blank" href="http://www.google.com/">More details.</a>.
    /// <param name="settingName"> Represents the setting name. </param>
    /// <param name="value"> Represents how the setting should be altered.</param>
    /// <exception cref="ArgumentNullException"> Value cannot be null.</exception>
    /// </summary>
    public async Task SetXSOverlaySystemSetting(string settingName, object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value) + " cannot be null.");
        }
        await SetXSOverlaySystemSetting(new(settingName, value));
    }
    /// <summary>
    /// Sets a user settings.
    /// <a target="_blank" href="http://www.google.com/">More details.</a>.
    /// <param name="setting"> Represents the setting that should be changed and how it should be altered.</param>
    /// <exception cref="ArgumentNullException"> Setting value cannot be null.</exception>
    /// </summary>
    public async Task SetXSOverlaySystemSetting(XSSettingObject setting)
    {
        if (setting.value == null)
        {
            throw new ArgumentNullException(nameof(setting.value) + " cannot be null.");
        }
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "SetXSOverlaySystemSetting";
        obj.jsonData = JsonSerializer.Serialize(setting);
        await SendAsync(obj);
    }
    
    /// <summary>
    /// Sets a setting on the currently active overlay.
    /// <a target="_blank" href="http://www.google.com/">More details.</a>.
    /// <param name="settingName"> Represents the setting name. </param>
    /// <param name="value"> Represents how the setting should be altered.</param>
    /// <exception cref="ArgumentNullException"> Value cannot be null.</exception>
    /// </summary>
    public async Task SetActiveOverlaySetting(string settingName, object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value) + " cannot be null.");
        }
        await SetActiveOverlaySetting(new(settingName, value));
    }
    
    /// <summary>
    /// Sets a setting on the currently active overlay.
    /// <a target="_blank" href="http://www.google.com/">More details.</a>.
    /// <param name="setting"> Represents the setting that should be changed and how it should be altered.</param>
    /// <exception cref="ArgumentNullException"> Setting value cannot be null.</exception>
    /// </summary>
    public async Task SetActiveOverlaySetting(XSSettingObject setting)
    {
        if (setting.value == null)
        {
            throw new ArgumentNullException(nameof(setting.value) + " cannot be null.");
        }
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "SetActiveOverlaySetting";
        obj.jsonData = JsonSerializer.Serialize(setting);
        await SendAsync(obj);
    }

    /// <summary>
    /// Requests to show a tooltip.
    /// </summary>
    public async Task RequestShowTooltip()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestShowTooltip";
        await SendAsync(obj);
    }

    /// <summary>
    /// Allows you to play haptic feedback on a device.
    /// <param name='hapticsObject'> is the object that contains the information about the haptics. </param>
    /// </summary>
    public async Task PlayDeviceHaptics(XSHapticsObject hapticsObject)
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "PlayDeviceHaptics";
        obj.jsonData = JsonSerializer.Serialize(hapticsObject);
        await SendAsync(obj);
    }

    /// <summary>
    /// Opens the SteamVR Binding Dashboard Page for XSO.
    /// </summary>
    public async Task OpenSteamVRBindings()
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "OpenSteamVRBindings";
        await SendAsync(obj);
    }

    /// <summary>
    /// Sends a notificationObject to the overlay.
    /// <param name='notificationObject'> The object that contains the information about the notification. </param>
    /// </summary>
    public async Task SendNotification(XSNotificationObject notificationObject)
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "SendNotification";
        obj.jsonData = JsonSerializer.Serialize(notificationObject);
        await SendAsync(obj);
    }

    /// <summary>
    /// Requests that the collision area for the panel be updated. Prevents cursor being visible on transparent parts of UI. May not update instantly.
    /// <param name='overlayHandle'> The id of the overlay to update. </param>
    /// </summary>
    public async Task RequestUpdateCursorCollisionTexture(ulong overlayHandle)
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestUpdateCursorCollisionTexture";
        obj.rawData = overlayHandle.ToString();
        await SendAsync(obj);
    }

    /// <summary>
    /// Requests that the canvas resolution for the overlay be updated to the requested resolution. May not update instantly.
    /// <param name='overlayHandle'> the id of the overlay to update.</param>
    /// <param name='width'> The width of the window. </param>
    /// <param name='height'> The height of the window. </param>
    /// </summary>
    public async Task RequestUpdateCursorCollisionTexture(ulong overlayHandle, int width, int height)
    {
        await RequestUpdateCursorCollisionTexture(overlayHandle, new CanvasSize(width, height));
    }
    
    /// <summary>
    /// Requests that the canvas resolution for the overlay be updated to the requested resolution. May not update instantly.
    /// <param name='overlayHandle'> The id of the overlay to update.</param>
    /// <param name='size'> The dimensions of the window.</param>
    /// </summary>
    public async Task RequestUpdateCursorCollisionTexture(ulong overlayHandle, CanvasSize size)
    {
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "RequestUpdateCursorCollisionTexture";
        obj.rawData = overlayHandle.ToString();
        obj.jsonData = JsonSerializer.Serialize(size);
        await SendAsync(obj);
    }

    /// <summary>
    /// Subscribes to events from the overlay based on the list provided.
    /// <param name='tags'> The list of subscription tags to subscribe to. If empty, subscribes to all events. </param>
    /// </summary>
    public async Task SubscribeToEvents(List<XSSubscriptionTag>? tags = null)
    {
        tags = tags ?? new List<XSSubscriptionTag>();
        if (!tags.Any()) tags = Enum.GetValues(typeof(XSSubscriptionTag)).Cast<XSSubscriptionTag>().ToList();
        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "SubscribeToEvents";
        obj.jsonData = JsonSerializer.Serialize(tags.ToStringList());
        await SendAsync(obj);
    }

    /// <summary>
    /// Unsubscribes to events from the overlay based on the list provided.
    /// <param name='tags'> The list of subscription tags to subscribe to. If empty, unsubscribes to all events. </param>
    /// </summary>
    public async Task UnsubscribeToEvents(List<XSSubscriptionTag>? tags = null)
    {
        tags = tags ?? new List<XSSubscriptionTag>();
        if (!tags.Any()) tags = Enum.GetValues(typeof(XSSubscriptionTag)).Cast<XSSubscriptionTag>().ToList();

        var obj = new XSApiObject();
        obj.sender = AppName;
        obj.command = "UnsubscribeToEvents";
        obj.jsonData = JsonSerializer.Serialize(tags.ToStringList());
        await SendAsync(obj);
    }
}