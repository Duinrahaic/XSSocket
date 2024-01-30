namespace XSSocket;

internal static class Helper
{
    public static List<string> ToStringList(this List<XSSubscriptionTag> enumList)
    {
        return enumList.Select(e => e.ToString()).ToList();
    }
}