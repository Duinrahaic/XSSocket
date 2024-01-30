namespace XSSocket.Models;

/// <summary>
/// Represents the wrist overlay rotation, in euler angles, in local space. This is relative to the device it's attached to.
/// </summary>
public class WristRotation
{
    /// <summary>
    /// X Rotation
    /// </summary>
    public float x { get; set; }
    /// <summary>
    /// Y Rotation
    /// </summary>
    public float y { get; set; }
    /// <summary>
    /// Z Rotation
    /// </summary>
    public float z { get; set; }
}