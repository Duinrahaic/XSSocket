namespace XSSocket.Models;

/// <summary>
/// Hardware Type
/// </summary>
public enum HardwareType
{
    /// <summary>
    /// Default type when hardware type is not identified or specified.
    /// </summary>
    Generic = 0,
    /// <summary>
    /// Graphics Processing Unit
    /// </summary>
    Gpu = 1,
    /// <summary>
    /// Central Processing Unit
    /// </summary>
    Cpu = 2,
    /// <summary>
    /// System Memory
    /// </summary>
    Memory = 3
}