namespace XSSocket.Models;

public class XSSettingObject
{
    public string internalName { get; set; }
    public object value { get; set; }
    /// <summary>
    /// Represents a setting object that can be sent to the client.
    /// <a target="_blank" href="http://www.google.com/">More details.</a>
    /// <exception cref="ArgumentNullException"> Setting value cannot be null.</exception>
    /// </summary>
    public XSSettingObject(string internalName, object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value) + " cannot be null.");
        }
        this.internalName = internalName;
        this.value = value;
    }
}