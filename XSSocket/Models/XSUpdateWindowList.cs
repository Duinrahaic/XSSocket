namespace XSSocket.Models;

public class XSUpdateWindowList : XSApiObject
{
    public XSUpdateWindowList()
    {
    }

    public XSUpdateWindowList(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateWindowList(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public List<Window>? GetWindowList()
    {
        return GetJsonData<Dictionary<string, Window>>()?.Select(x => x.Value).ToList();
    }
}