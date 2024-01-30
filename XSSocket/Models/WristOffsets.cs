namespace XSSocket.Models;

/// <summary>
/// Represents the wrist overlay position in local space, relative to the device it's attached to.
/// </summary>
public class WristOffsets
{
    /// <summary>
    /// X Offset
    /// </summary>
    public float x { get; set; }
    /// <summary>
    /// Y Offset
    /// </summary>
    public float y { get; set; }
    /// <summary>
    /// Z Offset
    /// </summary>
    public float z { get; set; }
}