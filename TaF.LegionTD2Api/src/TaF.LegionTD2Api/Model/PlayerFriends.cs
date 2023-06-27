/*
 * LTD2ApiV2
 *
 * This is the official Legion TD 2 public API. The new API endpoint is https://apiv2.legiontd2.com/ <br /> You can generate your key at <a href='https://developer.legiontd2.com/'>developer.legiontd2.com</a><br />In your requests add the HTTP header 'x-api-key' and your secret key from the developer portal. <br /><br />For icons, emotes or splash art images you can use our CDN: <a href='https://cdn.legiontd2.com/icons/Yozora.png'>cdn.legiontd2.com</a>. <br /> If you prefer to host the icons on your own server you can find the image files in your game files: 'Steam\\steamapps\\common\\Legion TD 2\\Legion TD 2_Data\\uiresources\\AeonGT\\hud\\img\\icons'<br /> <br /> The current limits are 15 requests per second / 10k burst requests and a maximum of 10k requests per day. If you need a higher limit, reach out to us in discord or through our support portal. <br /> <br /> If you have any other questions, feel free to ask in the &#35;api channel on the <a href='https://discord.gg/4K4xwCz2DN'>Legion TD 2 Contributors Discord</a>
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace TaF.LegionTD2Api.Model
{
    /// <summary>
    ///     PlayerFriends
    /// </summary>
    [DataContract]
    public class PlayerFriends : IEquatable<PlayerFriends>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PlayerFriends" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="count">count.</param>
        public PlayerFriends(PlayerFriendsId id = default, int count = default)
        {
            Id = id;
            Count = count;
        }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", EmitDefaultValue = false)]
        public PlayerFriendsId Id { get; set; }

        /// <summary>
        ///     Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        ///     Returns true if PlayerFriends instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerFriends to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerFriends input)
        {
            if (input == null)
                return false;

            return
                (
                    Id.Equals(input.Id) ||
                    (Id != null &&
                     Id.Equals(input.Id))
                ) &&
                (
                    Count == input.Count ||
                    (Count.Equals(input.Count))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerFriends {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PlayerFriends);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                return hashCode;
            }
        }
    }
}