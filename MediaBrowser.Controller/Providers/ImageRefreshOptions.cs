#nullable disable

#pragma warning disable CA1819, CS1591

using System;
using System.Linq;
using MediaBrowser.Model.Entities;

namespace MediaBrowser.Controller.Providers
{
    public class ImageRefreshOptions
    {
        public ImageRefreshOptions(IDirectoryService directoryService)
        {
            ImageRefreshMode = MetadataRefreshMode.Default;
            DirectoryService = directoryService;

            ReplaceImages = Array.Empty<ImageType>();
            IsAutomated = true;
        }

        public MetadataRefreshMode ImageRefreshMode { get; set; }

        public IDirectoryService DirectoryService { get; private set; }

        public bool ReplaceAllImages { get; set; }

        public ImageType[] ReplaceImages { get; set; }

        public bool IsAutomated { get; set; }

        public bool IsReplacingImage(ImageType type)
        {
            return ImageRefreshMode == MetadataRefreshMode.FullRefresh &&
                   (ReplaceAllImages || ReplaceImages.Contains(type));
        }
    }
}
