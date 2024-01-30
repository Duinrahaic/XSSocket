namespace XSSocket.Models;

/// <summary>
/// Represents the system information of the system.
/// </summary>
public class SystemInfo
{
    /// <summary>
    /// Represents the CPU of the system.
    /// </summary>
    public ComponentInfo CPU { get; set; }
    /// <summary>
    /// Represents the GPU of the system.
    /// </summary>
    public ComponentInfo GPU { get; set; }
    /// <summary>
    /// Represents the RAM of the system.
    /// </summary>
    public ComponentInfo Memory { get; set; }
    /// <summary>
    /// Current time in ms between the previous frame and this frame.
    /// </summary>
    public float Frametime { get; set; } 
    /// <summary>
    /// Current framerate in Frames Per Second
    /// </summary>
    public float Framerate { get; set; }
    /// <summary>
    /// Maximum frame-time based on Headset Refresh Rate in ms e.g. 90hz = 11.1ms
    /// </summary>
    public float MaxFrametime { get; set; } 
    /// <summary>
    /// Represents the maximum framerate based on Headset Refresh Rate in Frames Per Second e.g. 90hz = 90fps
    /// </summary>
    public float MaxFramerate { get; set; } 
}