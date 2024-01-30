namespace XSSocket.Models;

public class XSUpdateDateTime : XSApiObject
{
    public XSUpdateDateTime()
    {
    }

    public XSUpdateDateTime(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateDateTime(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public DateTime? CurrentDateTime => GetDateTime();
    public TimeSpan? SessionLength => GetJsonValue<TimeSpan?>("SessionLength");

    private DateTime? GetDateTime()
    {
        if (!DateTime.TryParse(
                $"{GetJsonValue<string?>("Date") ?? string.Empty} {GetJsonValue<string?>("Time") ?? string.Empty ?? string.Empty}"
                    .Trim(), out var result)) return null;
        return result;
    }

    private TimeSpan? GetCurrentSessionLength()
    {
        if (!TimeSpan.TryParse(GetJsonValue<string?>("SessionLength") ?? string.Empty, out var result)) return null;
        return result;
    }
}