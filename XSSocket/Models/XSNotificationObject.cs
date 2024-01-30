namespace XSSocket.Models;

public class XSNotificationObject
{
    public int type { get; set; } = 1;
    public int index { get; set; } = 1;
    public float timeout { get; set; } = 0.5f;
    public float height { get; set; } = 175;
    public float opacity { get; set; } = 1;
    public float volume { get; set; } = 0.7f;
    public string audioPath { get; set; } = string.Empty;
    public string title { get; set; } = string.Empty;
    public string content { get; set; } = string.Empty;
    public bool useBase64Icon { get; set; } = false;
    public string icon { get; set; } = string.Empty;
    public string sourceApp { get; set; } = string.Empty;
}