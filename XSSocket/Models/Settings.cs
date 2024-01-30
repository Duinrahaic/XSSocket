namespace XSSocket.Models;

/// <summary>
/// Represents Application Settings
/// </summary>
public class Settings
{
    /// <summary>
    /// Version Number
    /// </summary>
    public int VersionNumber { get; set; }
    /// <summary>
    /// Name of the currently loaded Keyboard sound pack
    /// </summary>
    public string KeyboardSoundpackName { get; set; }
    /// <summary>
    /// Index to the currently loaded keyboard sound pack
    /// </summary>
    public int KeyboardSoundpackIndex { get; set; }
    /// <summary>
    /// When enabled, the keyboard is forced into JIS layout 
    /// </summary>
    public bool ForceJISKeyboard { get; set; }
    /// <summary>
    /// Format of keyboard (minimal, half size, full)
    /// </summary>
    public int KeyboardFormat { get; set; }
    /// <summary>
    /// The opacity of the keyboard, between 0 and 1
    /// </summary>
    public float KeyboardOpacity { get; set; }
    /// <summary>
    /// When enabled, the keyboard typing noises are on
    /// </summary>
    public bool KeyboardTypingSounds { get; set; }
    /// <summary>
    /// Represents the wrist overlay position in local space. This is relative to the device it's attached to.
    /// </summary>
    public WristOffsets WristOffsets { get; set; }
    /// <summary>
    /// Represents the wrist overlay rotation, in euler angles, in local space. This is relative to the device it's attached to.
    /// </summary>
    public WristRotation WristRotation { get; set; }
    /// <summary>
    /// Wrist overlay scale
    /// </summary>
    public float WristScale { get; set; }
    /// <summary>
    /// Dominant Hand. This would be left (0) or right (1).
    /// </summary>
    public int DominantHand { get; set; }
    /// <summary>
    /// Index of the currently selected language. 
    /// </summary>
    public int Language { get; set; }
    /// <summary>
    /// The path to the currently selected language on the system
    /// </summary>
    public string LanguageURL { get; set; }
    /// <summary>
    /// Represents the input method of cursor when interacting with devices. This would be touch (0) or mouse emulation (1). 
    /// </summary>
    public int InputMethod { get; set; }
    /// <summary>
    /// When enabled, the mouse cursor automatically moves with the VR Cursor, or if an input is required first. 
    /// </summary>
    public bool AutomaticMouseControl { get; set; }
    /// <summary>
    /// Represents the amount of time in milliseconds after a click that the cursor will freeze in place to allow for easier double-clicking.
    /// </summary>
    public float DoubleClickDelay { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will communicate to discord what you are playing.
    /// </summary>
    public bool DiscordRichPresence { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will play a sound when the battery is low.
    /// </summary>
    public bool LowBatterySound { get; set; }
    /// <summary>
    /// Represents the threshold of battery percentage that will trigger a low battery warning. This is between 0 and 100.
    /// </summary>
    public int LowBatteryWarningPercent { get; set; }
    /// <summary>
    /// Represents the haptics strength when interacting with XSOverlay. This is between 0 and 1.
    /// </summary>
    public float HapticsStrength { get; set; }
    /// <summary>
    /// When enabled, this hides tooltips.
    /// </summary>
    public bool HideTooltips { get; set; }
    /// <summary>
    /// Represents the scale of the pointer. This is between 0 and 1.
    /// </summary>
    public float PointerScale { get; set; }
    /// <summary>
    /// Represents the capture method of the overlay. This is either Windows Game Capture (0) or BitBlt (1).
    /// </summary>
    public int CaptureMethod { get; set; }
    /// <summary>
    /// When enabled, this will show previews of the windows.
    /// </summary>
    [Obsolete("This setting is no longer used. However, it is still here for backwards compatibility.", false)]
    public bool ShowWindowPreviews { get; set; }
    /// <summary>
    /// When enabled, this allows overlay windows to be curved.
    /// </summary>
    public bool CurvedOverlays { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will automatically re-center when layout mode opens.
    /// </summary>
    public bool AutoRecenter { get; set; }
    /// <summary>
    /// When enabled, this will invert the scaling direction when scaling the overlay.
    /// </summary>
    public bool InvertScaleGesture { get; set; }
    /// <summary>
    ///  Represents the control strength of the overlay curving.
    /// </summary>
    public float OverlayCurveBias { get; set; }
    /// <summary>
    /// Represents the clip angle to auto-hide overlays when not looking at them. Auto-hide must be enabled for this to work.
    /// </summary>
    public int OverlayClipAngle { get; set; }
    /// <summary>
    /// Represents the default scale of the overlay when it is created. This is between 0 and 1.
    /// </summary>
    public float OverlayDefaultScale { get; set; }
    /// <summary>
    /// Represents the default opacity of the overlay when it is created. This is between 0 and 1.
    /// </summary>
    public float OverlayDefaultOpacity { get; set; }
    /// <summary>
    /// Represents the default minimum FPS of a newly created overlay overlay.
    /// </summary>
    public int OverlayDefaultMinFPS { get; set; }
    /// <summary>
    /// Represents the default maximum FPS of a newly created overlay overlay.
    /// </summary>
    public int OverlayDefaultMaxFPS { get; set; }
    /// <summary>
    /// Represents the target an overlay will aim at when holding it. This could be mixed (0), head (1), or hand (2). AimAtTarget must be enabled for this to work.
    /// </summary>
    public int AimTarget { get; set; }
    /// <summary>
    /// When enabled, this will aim the overlay at the target when holding it.
    /// </summary>
    public bool AimAtTarget { get; set; }
    /// <summary>
    /// Represents the sensitivity of the grab gesture. This is between 0 (light) and 1 (hard). 
    /// </summary>
    public float GrabSensitivity { get; set; }
    /// <summary>
    /// Represents the speed of pushing/pulling an overlay. This is between 0 (slow) and 1 (fast).
    /// </summary>
    public float PushSpeed { get; set; }
    /// <summary>
    /// Represents the speed of scaling an overlay. This is between 0 (slow) and 1 (fast).
    /// </summary>
    public float ScaleSpeed { get; set; }
    /// <summary>
    /// Represents the reaction speed when an overlay adjusts it's position when moving around. This is between 0 and 1.
    /// </summary>
    public int PositionDampening { get; set; }
    /// <summary>
    /// Represents the reaction speed when an overlay adjusts it's position when moving around. This is between 0 and 1.
    /// </summary>
    public int RotationDampening { get; set; }
    /// <summary>
    /// Represents the angle your head needs relative to the space overlay to to adapt to being sideways. (I.E. For Laying down)
    /// </summary>
    public int SmartRollAngle { get; set; }
    /// <summary>
    /// When enabled, this will allow the wrist overlay to be moved.
    /// </summary>
    public bool AllowWristMovement { get; set; }
    /// <summary>
    /// When enabled, this will allow the wrist overlay to be hidden. 
    /// </summary>
    [Obsolete("This setting is no longer used. However, it is still here for backwards compatibility.", false)]
    public bool HideWristOverlay { get; set; }
    /// <summary>
    /// Represents the opacity of the wrist overlay. This is between 0 and 1.
    /// </summary>
    public float WristOpacity { get; set; }
    /// <summary>
    /// Represents the clip angle to auto-hide the wrist overlay when not looking at it. 
    /// </summary>
    public int WristClipAngle { get; set; }
    /// <summary>
    /// When enabled, the time format will be in 24 hour format.
    /// </summary>
    public bool ContinentalTimeFormat { get; set; }
    /// <summary>
    /// Represents the date format. This could be MM/DD/YYYY (0), DD/MM/YYYY (1)
    /// </summary>
    public int DateFormat { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will automatically detect media playing.
    /// </summary>
    public bool AutoMediaDetection { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will adjust the theme based on the playing media's album art.
    /// </summary>
    public bool MediaThemeing { get; set; }
    /// <summary>
    /// When enabled, the wrist battery widget will always show battery percentage and time remaining.
    /// </summary>
    public bool AlwaysShowDetailedInformation { get; set; }
    /// <summary>
    /// When enabled, the wrist battery widget will always show battery percentage instead of time remaining.
    /// </summary>
    public bool DefaultShowBatteryPercentage { get; set; }
    /// <summary>
    /// Represents the font-size for the battery widget.
    /// </summary>
    public int BatteryFontScale { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will use the dark theme.
    /// </summary>
    public bool UseDarkTheme { get; set; }
    /// <summary>
    /// Represents how much mix the accent color into the primary theme color. This is between 0 and 1.
    /// </summary>
    public float AdaptiveColor { get; set; }
    /// <summary>
    /// Represents the theme accent color.
    /// </summary>
    public AccentColor AccentColor { get; set; }
    /// <summary>
    /// Represents the notification scale. This is between 0 and 1.
    /// </summary>
    public float NotificationScale { get; set; }
    /// <summary>
    /// Represents the notification offset relative to local space to the hmd.
    /// </summary>
    public NotificationOffsets NotificationOffsets { get; set; }
    /// <summary>
    /// When enabled, this will force overlays to be rendered at a higher resolution.
    /// </summary>
    public bool ForceHigherQualityOverlays { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will attempt to block input to the background application.
    /// </summary>
    public bool BlockInputToBackgroundApplication { get; set; }
    /// <summary>
    /// Represents the input blocking behavior. Chose between 'blocking when layout mode is open' (0) or 'blocking when hovering over an overlay' (1).
    /// </summary>
    public int InputBlockingBehavior { get; set; }
    /// <summary>
    /// Represents the behavior of the night-light which can apply a red-ish hue to the overlays during select hours (true) or all time (false).
    /// </summary>
    public bool NightLight { get; set; }
    /// <summary>
    /// Represents the starting hour of the night light cycle.
    /// </summary>
    public int NightLightStartHour { get; set; }
    /// <summary>
    /// Represents the ending hour of the night light cycle.
    /// </summary>
    public int NightLightEndHour { get; set; }
    /// <summary>
    /// When enabled, the night light cycle will start at PM, otherwise it will start at AM.
    /// </summary>
    public bool NightLightStartAMPM { get; set; }
    /// <summary>
    /// When enabled, the night light cycle will end at PM, otherwise it will start at AM.
    /// </summary>
    public bool NightLightEndAMPM { get; set; }
    /// <summary>
    /// Represents the intensity of the night light. This is between 0 and 1.
    /// </summary>
    public float NightLightIntensity { get; set; }
    /// <summary>
    /// When enabled, the night light will follow a schedule.
    /// </summary>
    public bool NightLightSchedule { get; set; }
    /// <summary>
    /// When enabled, XSOverlay will be granted admin permissions.
    /// </summary>
    public bool AllowAdminPermissions { get; set; }
    /// <summary>
    /// UUID of the user. This is an anonymous identifier used for analytics.
    /// </summary>
    public string UUID { get; set; }
    /// <summary>
    /// When enabled, the anonymous analytics will be sent.
    /// </summary>
    public bool SendAnalytics { get; set; }
}