namespace XSSocket.Models;

public class XSDevice
{
    public XSDevice()
    {
    }

    public XSDevice(int id, int classification, int type, string lastUpdated, string lastBatteryUpdate,
        int connection, bool charging, int battery, string label, string name,
        string timeEstimate, List<float> runningBatterySecondsPerPercent, int runningBatteryIndex,
        string fingerprint, bool deviceDidPingLowBattery, string friendlyName,
        bool waitingForFirstRealBatteryUpdate)
    {
        Id = id;
        Classification = classification;
        Type = type;
        LastUpdated = lastUpdated;
        LastBatteryUpdate = lastBatteryUpdate;
        Connection = connection;
        Charging = charging;
        Battery = battery;
        Label = label;
        Name = name;
        TimeEstimate = timeEstimate;
        RunningBatterySecondsPerPercent = runningBatterySecondsPerPercent;
        RunningBatteryIndex = runningBatteryIndex;
        Fingerprint = fingerprint;
        DeviceDidPingLowBattery = deviceDidPingLowBattery;
        FriendlyName = friendlyName;
        WaitingForFirstRealBatteryUpdate = waitingForFirstRealBatteryUpdate;
    }

    public int Id { get; set; }
    public int Classification { get; set; }
    public int Type { get; set; }
    public string LastUpdated { get; set; }
    public string LastBatteryUpdate { get; set; }
    public int Connection { get; set; }
    public bool Charging { get; set; }
    public float Battery { get; set; }
    public string Label { get; set; }
    public string Name { get; set; }
    public string TimeEstimate { get; set; }
    public List<float> RunningBatterySecondsPerPercent { get; set; }
    public int RunningBatteryIndex { get; set; }
    public string Fingerprint { get; set; }
    public bool DeviceDidPingLowBattery { get; set; }
    public string FriendlyName { get; set; }
    public bool WaitingForFirstRealBatteryUpdate { get; set; }
}