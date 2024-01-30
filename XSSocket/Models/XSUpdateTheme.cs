namespace XSSocket.Models;

public class XSUpdateTheme : XSApiObject
{
    public XSUpdateTheme()
    {
    }

    public XSUpdateTheme(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateTheme(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public string? HiTone => GetJsonValue<string?>("HiTone");
    public string? MidTone => GetJsonValue<string?>("MidTone");
    public string? DarkTone => GetJsonValue<string?>("DarkTone");
    public string? ContrastingTone => GetJsonValue<string?>("ContrastingTone");
    public string? ErrorTone => GetJsonValue<string?>("ErrorTone");
    public string? WarningTone => GetJsonValue<string?>("WarningTone");
    public string? ConfirmTone => GetJsonValue<string?>("ConfirmTone");
    public string? AccentColor => GetJsonValue<string?>("AccentColor");
    public string? AccentColorBright => GetJsonValue<string?>("AccentColorBright");
}