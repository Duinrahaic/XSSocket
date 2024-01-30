namespace XSSocket.Models;

/// <summary>
/// Represents the notification offset relative to local space to the hmd.
/// </summary>
public class NotificationOffsets
{
    /// <summary>
    /// X Offset
    /// </summary>
    public float x { get; set; }= 0.0f;
    /// <summary>
    /// Y Offset
    /// </summary>
    public float y { get; set; }= 0.0f;
    /// <summary>
    /// Z Offset
    /// </summary>
    public float z { get; set; } = 0.0f;

    /// <summary>
    /// Represents the notification offset relative to local space to the hmd.
    /// </summary>
    public NotificationOffsets()
    {
        
    }
    /// <summary>
    /// Represents the notification offset relative to local space to the hmd.
    /// </summary>
    public NotificationOffsets(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}