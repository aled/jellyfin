#pragma warning disable CS1591

using MediaBrowser.Model.Dlna;

namespace Emby.Dlna.Profiles
{
    [System.Xml.Serialization.XmlRoot("Profile")]
    public class SonySANS510Profile : DefaultProfile
    {
        public SonySANS510Profile()
        {
            Name = "Sony SA-NS510 Network Speaker";

            SupportedMediaTypes = "Audio";

            Identification = new DeviceIdentification
            {
                Manufacturer = @"Sony",

                Headers = new[]
               {
                   new HttpHeaderInfo
                   {
                       Name = "User-Agent",
                       Value = "Sony",
                       Match = HeaderMatchType.Substring
                   }
               }
            };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "wav",
                    Type = DlnaProfileType.Audio
                },
            };

            ResponseProfiles = new ResponseProfile[] { };
        }
    }
}
