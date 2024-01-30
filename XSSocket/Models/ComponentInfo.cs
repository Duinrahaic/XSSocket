namespace XSSocket.Models;

/// <summary>
/// Represents a component within a computer.
/// </summary>
public class ComponentInfo
{
    /// <summary>
    /// Component Type
    /// </summary>
    public int Type { get; set; }
    /// <summary>
    /// Component Manufacturer
    /// </summary>
    public int Manufacturer { get; set; }
    /// <summary>
    /// Name of the component
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Temperature of the component. Temperature Unit is based on user settings.
    /// </summary>
    public float Temperature { get; set; }
    /// <summary>
    /// The utilization of the component. Range between 0 and 100.
    /// </summary>
    public float Load { get; set; } // Used for device utilization, e.g. GPU / CPU Usage.
    /// <summary>
    /// The memory utilization of the component. Range between 0 and 100.
    /// </summary>
    public float MemLoad { get; set; }
    /// <summary>
    /// The total memory size of the system. 
    /// </summary>
    public float MemSize { get; set; }

    /// <summary>
    /// Gets the hardware type.
    /// </summary>
    /// <returns>
    /// The hardware type.
    /// </returns>
    public HardwareType GetComponentType()
    {
        return (HardwareType)Type;
    }

    /// <summary>
    /// Gets the manufacturer type.
    /// </summary>
    /// <returns>
    /// The manufacturer type.
    /// </returns>
    public ManufacturerType GetManufacturer()
    {
        return (ManufacturerType)Manufacturer;
    }
}