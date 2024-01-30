using System.Drawing;

namespace XSSocket.Models;

public class XSUpdateAvatar : XSApiObject
{
    public XSUpdateAvatar()
    {
    }

    public XSUpdateAvatar(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateAvatar(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public Image? GetPng()
    {
        if (string.IsNullOrEmpty(rawData)) return null;
        try
        {
            var imageBytes = Convert.FromBase64String(rawData);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
#pragma warning disable CA1416
                var image = Image.FromStream(ms);
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);
#pragma warning restore CA1416
                return image;
            }
        }
        catch
        {
            return null;
        }
    }
}