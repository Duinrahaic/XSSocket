namespace XSSocket.Models;

public class XSUpdateLayoutMode : XSApiObject
{
    public XSUpdateLayoutMode()
    {
    }

    public XSUpdateLayoutMode(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateLayoutMode(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public bool? IsLayoutModeOpen
    {
        get
        {
            if (string.IsNullOrEmpty(rawData))
                return null;
            try
            {
                return Convert.ToBoolean(rawData);
            }
            catch
            {
                return null;
            }
        }
    }
}