namespace XSSocket.Models;

public class XSUpdateSettings : XSApiObject
{
    public XSUpdateSettings()
    {
    }

    public XSUpdateSettings(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateSettings(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public Settings? GetSettings()
    {
        return GetJsonData<Settings>();
    }
}