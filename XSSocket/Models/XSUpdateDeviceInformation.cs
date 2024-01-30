namespace XSSocket.Models;

public class XSUpdateDeviceInformation : XSApiObject
{
    public XSUpdateDeviceInformation()
    {
    }

    public XSUpdateDeviceInformation(string sender, string target, string command, string jsonData,
        string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateDeviceInformation(string sender, string command, string jsonData, string? rawData = null) : base(
        sender,
        command, jsonData, rawData)
    {
    }

    public List<XSDevice> GetDevices()
    {
        var devices = GetJsonData<List<XSDevice>>();
        return devices ?? new List<XSDevice>();
    }
}