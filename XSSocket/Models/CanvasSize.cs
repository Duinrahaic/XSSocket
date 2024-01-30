namespace XSSocket.Models;


/// <summary>
/// Represents the size of the canvas.
/// </summary>
public struct CanvasSize
{
    /// <summary>
    /// Width of the canvas.
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// Height of the canvas.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Represents the size of the canvas.
    /// </summary>
    /// <param name="width">Width of the canvas.</param>
    /// <param name="height">Height of the canvas.</param>
    public CanvasSize(int width, int height)
    {
        Width = width;
        Height = height;
    }
}