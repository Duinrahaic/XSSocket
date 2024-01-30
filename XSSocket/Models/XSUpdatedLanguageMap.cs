namespace XSSocket.Models;

public class XSUpdatedLanguageMap : XSApiObject
{
    public XSUpdatedLanguageMap()
    {
    }

    public XSUpdatedLanguageMap(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdatedLanguageMap(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public Dictionary<string, string>? GetLanguageMap()
    {
        return GetJsonData<Dictionary<string, string>>();
    }
}