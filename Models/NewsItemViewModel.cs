using System;
using Newtonsoft.Json;

namespace Covid.Models
{
    public class NewsItemViewModel
    {
        public string Name { get; set; } //"Avalanche traps delivery truck, closes Wyoming pass"

        public Uri URL { get; set; } //https://www.washingtontimes.com/news/2020/jan/9/avalanche-traps-delivery-truck-closes-wyoming-pass/

        public ValueImage Image { get; set; }

        public string Description { get; set; }

        public About[] About { get; set; }

        public Mention[] Mentions { get; set; }

        public Provider[] Provider { get; set; }

        public DateTimeOffset DatePublished { get; set; } //2020-01-10T02:20:00.0000000Z

        public string Category { get; set; } //US

        public bool Headline { get; set; } //true

        public Uri AmpUrl { get; set; } //https://www.washingtonpost.com/national/energy-environment/2-suspected-coyote-attacks-in-chicago-several-sightings/2020/01/09/97b60000-334c-11ea-971b-43bec3ff9860_story.html?outputType=amp
    }

    public partial class About
    {
        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class ValueImage
    {
        [JsonProperty("thumbnail")]
        public PurpleThumbnail Thumbnail { get; set; }
    }

    public partial class PurpleThumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class Mention
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Provider
    {
        [JsonProperty("_type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public ProviderImage Image { get; set; }
    }

    public partial class ProviderImage
    {
        [JsonProperty("thumbnail")]
        public FluffyThumbnail Thumbnail { get; set; }
    }

    public partial class FluffyThumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }
    }

    public enum TypeEnum { Organization };

}
