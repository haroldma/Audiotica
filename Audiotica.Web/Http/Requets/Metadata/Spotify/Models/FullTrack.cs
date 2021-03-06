﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Audiotica.Web.Http.Requets.Metadata.Spotify.Models
{
    public class FullTrack : SimpleTrack
    {
        /// <summary>
        ///     Simple-AlbumName object of the track @<see cref="Paging" />
        /// </summary>
        [JsonProperty("album")]
        public SimpleAlbum Album { get; set; }

        [JsonProperty("artists")]
        public List<SimpleArtist> Artists { get; set; }

        public new SimpleArtist Artist => Artists.FirstOrDefault();

        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }
    }
}