#nullable disable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Emby.Server.Implementations.LiveTv.Listings.SchedulesDirectDtos
{
    /// <summary>
    /// Movie dto.
    /// </summary>
    public class MovieDto
    {
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        [JsonPropertyName("year")]
        public string Year { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the list of quality rating.
        /// </summary>
        [JsonPropertyName("qualityRating")]
        public List<QualityRatingDto> QualityRating { get; set; }
    }
}
