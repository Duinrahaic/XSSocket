using Newtonsoft.Json;

namespace XSSocket.Models;

public class XSApiObject
{
    public XSApiObject()
    {
    }

    public XSApiObject(string sender, string target, string command, string jsonData, string? rawData = null)
    {
        this.sender = sender;
        this.target = target;
        this.command = command;
        this.jsonData = jsonData;
        this.rawData = rawData;
    }

    public XSApiObject(string sender, string command, string jsonData, string? rawData = null)
    {
        this.sender = sender;
        this.command = command;
        this.jsonData = jsonData;
        this.rawData = rawData;
    }

    public string sender { get; set; } = string.Empty;
    public string target { get; set; } = "xsoverlay";
    public string command { get; set; } = string.Empty;
    public string? jsonData { get; set; }
    public string? rawData { get; set; }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }

    public Dictionary<string, object>? GetJsonData()
    {
        if (string.IsNullOrEmpty(jsonData)) return null;
        return JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
    }

    public T? GetJsonData<T>()
    {
        if (string.IsNullOrEmpty(jsonData)) return default;
        return JsonConvert.DeserializeObject<T>(jsonData);
    }

    public T? GetJsonValue<T>(string key)
    {
        var dict = GetJsonData();
        if (dict == null) return default;
        if (dict.ContainsKey(key))
            try
            {
                return (T)dict[key];
            }
            catch
            {
                return default;
            }

        return default;
    }

    public T? GetJsonObject<T>()
    {
        if (string.IsNullOrEmpty(jsonData)) return default;
        return JsonConvert.DeserializeObject<T>(jsonData);
    }
}