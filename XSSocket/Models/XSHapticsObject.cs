namespace XSSocket.Models;

public class XSHapticsObject
{
    public XSHapticsObject(string deviceId, int duration)
    {
        DeviceId = deviceId;
        Duration = duration;
    }

    public string DeviceId { get; set; }
    public int Duration { get; set; }
}