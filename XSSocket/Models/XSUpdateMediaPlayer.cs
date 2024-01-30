using System.Drawing;

namespace XSSocket.Models;

public class XSUpdateMediaPlayer : XSApiObject
{
    public XSUpdateMediaPlayer()
    {
    }

    public XSUpdateMediaPlayer(string sender, string target, string command, string jsonData, string? rawData = null) :
        base(sender, target, command, jsonData, rawData)
    {
    }

    public XSUpdateMediaPlayer(string sender, string command, string jsonData, string? rawData = null) : base(sender,
        command, jsonData, rawData)
    {
    }

    public string? Artist => GetJsonValue<string?>("Artist");
    public string? Title => GetJsonValue<string?>("Title");
    public string? AlbumTitle => GetJsonValue<string?>("AlbumTitle");
    public string? AlbumArt => GetJsonValue<string?>("AlbumArt");
    public bool? PlaybackStatus => GetJsonValue<bool?>("PlaybackStatus");

    public Image? GetAlbumArtImage()
    {
        if (string.IsNullOrEmpty(AlbumArt)) return null;
        try
        {
            var imageBytes = Convert.FromBase64String(AlbumArt);
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