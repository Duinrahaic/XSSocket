namespace XSSocket.Models;

public class XSUpdateAcheivementStatus : XSApiObject
{
    public XSUpdateAcheivementStatus()
    {
    }

    public XSUpdateAcheivementStatus(string sender, string target, string command, string jsonData,
        string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateAcheivementStatus(string sender, string command, string jsonData, string? rawData = null) : base(
        sender,
        command, jsonData, rawData)
    {
    }

    public Dictionary<string, bool>? GetAchievements()
    {
        return GetJsonData<Dictionary<string, bool>>();
    }
}