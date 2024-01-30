namespace XSSocket.Models;

public class XSUpdateRuntimePerformance : XSApiObject
{
    public XSUpdateRuntimePerformance()
    {
    }

    public XSUpdateRuntimePerformance(string sender, string target, string command, string jsonData,
        string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateRuntimePerformance(string sender, string command, string jsonData, string? rawData = null) : base(
        sender,
        command, jsonData, rawData)
    {
    }

    public SystemInfo? GetPerformanceStats()
    {
        return GetJsonData<SystemInfo>();
    }
}