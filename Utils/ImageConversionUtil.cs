using ImageMagick;

using System;
using System.Collections.Generic;

namespace Image2Icon.Utils;

public static class ImageConversionUtil {

    /// <exception cref="MagickException">Thrown when an error is raised by ImageMagick.</exception>
    private static void ResizeImageToSquare(MagickImage image) {
        uint size = Math.Max(image.Width, image.Height);
        image.BackgroundColor = MagickColors.Transparent;
        image.Extent(size, size, Gravity.Center);
    }

    private static void SetIconSizes(MagickImage image, IEnumerable<uint> sizes) {
        image.Settings.SetDefine(MagickFormat.Icon, "auto-resize", string.Join(",", sizes));
    }

    /// <exception cref="MagickException">Thrown when an error is raised by ImageMagick.</exception>
    public static void ConvertImageToIcon(string imagePath, string iconPath, IEnumerable<uint> sizes, bool shouldNormalizeAspectRatio) {
        using MagickImage image = new(imagePath);
        if (shouldNormalizeAspectRatio) {
            ResizeImageToSquare(image);
        }
        SetIconSizes(image, sizes);
        image.Write(iconPath);
    }
}
