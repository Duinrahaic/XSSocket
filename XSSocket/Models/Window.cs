using System.Drawing;

namespace XSSocket.Models;

public class Window
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Icon { get; set; } // base64 Icon image
    public string WindowPreview { get; set; } // base64 preview image. Currently not used.
    public string AppName { get; set; }
    public bool IsDesktop { get; set; }
    public bool IsPrimaryDesktop { get; set; }
    public bool IsUWP { get; set; }
    public bool IsSystem { get; set; }

    public override string ToString()
    {
        if (IsDesktop == false)
            return AppName;
        if (IsDesktop)
        {
            if (IsPrimaryDesktop)
                return Title;
            return $"{Title} - Non-Primary Desktop";
        }

        return AppName;
    }

    public Image? GetIconPng()
    {
        if (string.IsNullOrEmpty(Icon)) return null;
        try
        {
            var imageBytes = Convert.FromBase64String(Icon);
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

    public Image? GetWindowPreviewPng()
    {
        if (string.IsNullOrEmpty(WindowPreview)) return null;
        try
        {
            var imageBytes = Convert.FromBase64String(WindowPreview);
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