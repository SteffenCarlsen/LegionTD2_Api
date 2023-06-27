/*
 * LTD2ApiV2
 *
 * This is the official Legion TD 2 public API. The new API endpoint is https://apiv2.legiontd2.com/ <br /> You can generate your key at <a href='https://developer.legiontd2.com/'>developer.legiontd2.com</a><br />In your requests add the HTTP header 'x-api-key' and your secret key from the developer portal. <br /><br />For icons, emotes or splash art images you can use our CDN: <a href='https://cdn.legiontd2.com/icons/Yozora.png'>cdn.legiontd2.com</a>. <br /> If you prefer to host the icons on your own server you can find the image files in your game files: 'Steam\\steamapps\\common\\Legion TD 2\\Legion TD 2_Data\\uiresources\\AeonGT\\hud\\img\\icons'<br /> <br /> The current limits are 15 requests per second / 10k burst requests and a maximum of 10k requests per day. If you need a higher limit, reach out to us in discord or through our support portal. <br /> <br /> If you have any other questions, feel free to ask in the &#35;api channel on the <a href='https://discord.gg/4K4xwCz2DN'>Legion TD 2 Contributors Discord</a>
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TaF.LegionTD2Api.Model
{
    /// <summary>
    ///     Defines QueueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueType
    {
        /// <summary>
        ///     Enum Normal for value: Normal
        /// </summary>
        [EnumMember(Value = "Normal")] Normal = 1,

        /// <summary>
        ///     Enum Classic for value: Classic
        /// </summary>
        [EnumMember(Value = "Classic")] Classic = 2,

        /// <summary>
        ///     Enum Arcade for value: Arcade
        /// </summary>
        [EnumMember(Value = "Arcade")] Arcade = 3,

        /// <summary>
        ///     Enum Coop for value: Coop
        /// </summary>
        [EnumMember(Value = "Coop")] Coop = 4,

        /// <summary>
        ///     Enum Custom for value: Custom
        /// </summary>
        [EnumMember(Value = "Custom")] Custom = 5
    }
}