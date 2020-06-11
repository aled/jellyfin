#nullable disable
#pragma warning disable CS1591
#pragma warning disable CA1819 // Properties should not return arrays

using System;

using MediaBrowser.Model.Entities;

namespace MediaBrowser.Model.Configuration
{
    public class LibraryOptions
    {
        public LibraryOptions()
        {
            TypeOptionsCollection = Array.Empty<TypeOptions>();
            DisabledSubtitleFetchers = Array.Empty<string>();
            SubtitleFetcherOrder = Array.Empty<string>();
            DisabledLocalMetadataReaders = Array.Empty<string>();

            SkipSubtitlesIfAudioTrackMatches = true;
            RequirePerfectSubtitleMatch = true;

            EnablePhotos = true;
            SaveSubtitlesWithMedia = true;
            EnableRealtimeMonitor = true;
            PathInfos = Array.Empty<MediaPathInfo>();
            EnableInternetProviders = true;
            EnableAutomaticSeriesGrouping = true;
            SeasonZeroDisplayName = "Specials";
        }

        public bool EnablePhotos { get; set; }

        public bool EnableRealtimeMonitor { get; set; }

        public bool EnableChapterImageExtraction { get; set; }

        public bool ExtractChapterImagesDuringLibraryScan { get; set; }

        public bool DownloadImagesInAdvance { get; set; }

        public MediaPathInfo[] PathInfos { get; set; }

        public bool SaveLocalMetadata { get; set; }

        public bool EnableInternetProviders { get; set; }

        public bool ImportMissingEpisodes { get; set; }

        public bool EnableAutomaticSeriesGrouping { get; set; }

        public bool EnableEmbeddedTitles { get; set; }

        public bool EnableEmbeddedEpisodeInfos { get; set; }

        public int AutomaticRefreshIntervalDays { get; set; }

        /// <summary>
        /// Gets or sets the preferred metadata language.
        /// </summary>
        /// <value>The preferred metadata language.</value>
        public string PreferredMetadataLanguage { get; set; }

        /// <summary>
        /// Gets or sets the metadata country code.
        /// </summary>
        /// <value>The metadata country code.</value>
        public string MetadataCountryCode { get; set; }

        public string SeasonZeroDisplayName { get; set; }

        public string[] MetadataSavers { get; }

        public string[] DisabledLocalMetadataReaders { get; set; }

        public string[] LocalMetadataReaderOrder { get; }

        public string[] DisabledSubtitleFetchers { get; }

        public string[] SubtitleFetcherOrder { get; }

        public bool SkipSubtitlesIfEmbeddedSubtitlesPresent { get; set; }

        public bool SkipSubtitlesIfAudioTrackMatches { get; set; }

        public string[] SubtitleDownloadLanguages { get; set; }

        public bool RequirePerfectSubtitleMatch { get; set; }

        public bool SaveSubtitlesWithMedia { get; set; }

        public TypeOptions[] TypeOptionsCollection { get; set; }

        public TypeOptions GetTypeOptions(string type)
        {
            foreach (var options in TypeOptionsCollection)
            {
                if (string.Equals(options.Type, type, StringComparison.OrdinalIgnoreCase))
                {
                    return options;
                }
            }

            return null;
        }
    }
}
