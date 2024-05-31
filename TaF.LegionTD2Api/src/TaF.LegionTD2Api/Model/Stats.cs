using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace TaF.LegionTD2Api.Model;

/// <summary>
///     Note: Existing fields should not change but there might always be new fields added to this object
/// </summary>
[DataContract]
public class Stats : IEquatable<Stats>, IValidatableObject
{
    /// <summary>
    ///     Gets or Sets Id
    /// </summary>
    [DataMember(Name = "_id", EmitDefaultValue = false)]
    public string Id { get; }

    /// <summary>
    ///     Gets or Sets SecondsPlayed
    /// </summary>
    [DataMember(Name = "secondsPlayed", EmitDefaultValue = false)]
    public int SecondsPlayed { get; }

    /// <summary>
    ///     Gets or Sets GamesPlayed
    /// </summary>
    [DataMember(Name = "gamesPlayed", EmitDefaultValue = false)]
    public int GamesPlayed { get; set; }

    /// <summary>
    ///     Gets or Sets TotalXp
    /// </summary>
    [DataMember(Name = "totalXp", EmitDefaultValue = false)]
    public int TotalXp { get; set; }

    /// <summary>
    ///     Gets or Sets ___
    /// </summary>
    [DataMember(Name = "...", EmitDefaultValue = false)]
    public string ___ { get; set; }

    /// <summary>
    ///     Returns true if Stats instances are equal
    /// </summary>
    /// <param name="input">Instance of Stats to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Stats input)
    {
        if (input == null)
        {
            return false;
        }

        return (Id == input.Id || (Id != null && Id.Equals(input.Id))) && (SecondsPlayed == input.SecondsPlayed || SecondsPlayed.Equals(input.SecondsPlayed)) && (GamesPlayed == input.GamesPlayed || GamesPlayed.Equals(input.GamesPlayed)) && (TotalXp == input.TotalXp || TotalXp.Equals(input.TotalXp)) && (___ == input.___ || (___ != null && ___.Equals(input.___)));
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
        sb.Append("class Stats {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SecondsPlayed: ").Append(SecondsPlayed).Append("\n");
        sb.Append("  GamesPlayed: ").Append(GamesPlayed).Append("\n");
        sb.Append("  TotalXp: ").Append(TotalXp).Append("\n");
        sb.Append("  ___: ").Append(___).Append("\n");
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
        return Equals(input as Stats);
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
            {
                hashCode = hashCode * 59 + Id.GetHashCode();
            }

            hashCode = hashCode * 59 + SecondsPlayed.GetHashCode();
            if (GamesPlayed != null)
            {
                hashCode = hashCode * 59 + GamesPlayed.GetHashCode();
            }

            if (TotalXp != null)
            {
                hashCode = hashCode * 59 + TotalXp.GetHashCode();
            }

            if (___ != null)
            {
                hashCode = hashCode * 59 + ___.GetHashCode();
            }

            return hashCode;
        }
    }
}