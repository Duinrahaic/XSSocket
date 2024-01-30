namespace XSSocket.Models;

/// <summary>
/// Accent Color
/// </summary>
public class AccentColor
{
    /// <summary>
    /// Red
    /// </summary>
    public float r { get; set; }
    /// <summary>
    /// Green
    /// </summary>
    public float g { get; set; }
    /// <summary>
    /// Blue. 
    /// </summary>
    public float b { get; set; }

    /// <summary>
    /// Alpha.
    /// </summary>
    [Obsolete("This setting is no longer used. However, it is still here for backwards compatibility.", false)]
    public float a { get; set; } = 1.0f;
    /// <summary>
    /// Accent Color
    /// </summary>
    public AccentColor()
    {
        r = 0;
        g = 0;
        b = 0;
    }
    /// <summary>
    /// Accent Color
    /// </summary>
    public AccentColor(float r, float g, float b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
    }
}