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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace TaF.LegionTD2Api.Model;

/// <summary>
///     Wave
/// </summary>
[DataContract]
public class Wave : IEquatable<Wave>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Wave" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Wave() { }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Wave" /> class.
    /// </summary>
    /// <param name="id">id.</param>
    /// <param name="name">name (required).</param>
    /// <param name="waveUnitId">waveUnitId.</param>
    /// <param name="amount">amount.</param>
    /// <param name="amount2">amount2.</param>
    /// <param name="category">category.</param>
    /// <param name="spellUnit2Id">spellUnit2Id.</param>
    /// <param name="iconPath">iconPath (required).</param>
    /// <param name="levelNum">levelNum (required).</param>
    /// <param name="prepareTime">prepareTime (required).</param>
    /// <param name="totalReward">totalReward (required).</param>
    public Wave(string id = default, string name = default, string waveUnitId = default, string amount = default, string amount2 = default, string category = default, string spellUnit2Id = default, string iconPath = default, string levelNum = default, string prepareTime = default, string totalReward = default)
    {
        // to ensure "name" is required (not null)
        if (name == null)
        {
            throw new InvalidDataException("name is a required property for Wave and cannot be null");
        }

        Name = name;

        // to ensure "iconPath" is required (not null)
        if (iconPath == null)
        {
            throw new InvalidDataException("iconPath is a required property for Wave and cannot be null");
        }

        IconPath = iconPath;

        // to ensure "levelNum" is required (not null)
        if (levelNum == null)
        {
            throw new InvalidDataException("levelNum is a required property for Wave and cannot be null");
        }

        LevelNum = levelNum;

        // to ensure "prepareTime" is required (not null)
        if (prepareTime == null)
        {
            throw new InvalidDataException("prepareTime is a required property for Wave and cannot be null");
        }

        PrepareTime = prepareTime;

        // to ensure "totalReward" is required (not null)
        if (totalReward == null)
        {
            throw new InvalidDataException("totalReward is a required property for Wave and cannot be null");
        }

        TotalReward = totalReward;

        Id = id;
        WaveUnitId = waveUnitId;
        Amount = amount;
        Amount2 = amount2;
        Category = category;
        SpellUnit2Id = spellUnit2Id;
    }

    /// <summary>
    ///     Gets or Sets Id
    /// </summary>
    [DataMember(Name = "_id", EmitDefaultValue = false)]
    public string Id { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets WaveUnitId
    /// </summary>
    [DataMember(Name = "waveUnitId", EmitDefaultValue = false)]
    public string WaveUnitId { get; set; }

    /// <summary>
    ///     Gets or Sets Amount
    /// </summary>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public string Amount { get; set; }

    /// <summary>
    ///     Gets or Sets Amount2
    /// </summary>
    [DataMember(Name = "amount2", EmitDefaultValue = false)]
    public string Amount2 { get; set; }

    /// <summary>
    ///     Gets or Sets Category
    /// </summary>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    public string Category { get; set; }

    /// <summary>
    ///     Gets or Sets SpellUnit2Id
    /// </summary>
    [DataMember(Name = "spellUnit2Id", EmitDefaultValue = false)]
    public string SpellUnit2Id { get; set; }

    /// <summary>
    ///     Gets or Sets IconPath
    /// </summary>
    [DataMember(Name = "iconPath", EmitDefaultValue = true)]
    public string IconPath { get; set; }

    /// <summary>
    ///     Gets or Sets LevelNum
    /// </summary>
    [DataMember(Name = "levelNum", EmitDefaultValue = true)]
    public string LevelNum { get; set; }

    /// <summary>
    ///     Gets or Sets PrepareTime
    /// </summary>
    [DataMember(Name = "prepareTime", EmitDefaultValue = true)]
    public string PrepareTime { get; set; }

    /// <summary>
    ///     Gets or Sets TotalReward
    /// </summary>
    [DataMember(Name = "totalReward", EmitDefaultValue = true)]
    public string TotalReward { get; set; }

    /// <summary>
    ///     Returns true if Wave instances are equal
    /// </summary>
    /// <param name="input">Instance of Wave to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Wave input)
    {
        if (input == null)
        {
            return false;
        }

        return (Id == input.Id || (Id != null && Id.Equals(input.Id))) && (Name == input.Name || (Name != null && Name.Equals(input.Name))) && (WaveUnitId == input.WaveUnitId || (WaveUnitId != null && WaveUnitId.Equals(input.WaveUnitId))) && (Amount == input.Amount || (Amount != null && Amount.Equals(input.Amount))) && (Amount2 == input.Amount2 || (Amount2 != null && Amount2.Equals(input.Amount2))) && (Category == input.Category || (Category != null && Category.Equals(input.Category))) && (SpellUnit2Id == input.SpellUnit2Id || (SpellUnit2Id != null && SpellUnit2Id.Equals(input.SpellUnit2Id))) && (IconPath == input.IconPath || (IconPath != null && IconPath.Equals(input.IconPath))) && (LevelNum == input.LevelNum || (LevelNum != null && LevelNum.Equals(input.LevelNum))) && (PrepareTime == input.PrepareTime || (PrepareTime != null && PrepareTime.Equals(input.PrepareTime))) && (TotalReward == input.TotalReward || (TotalReward != null && TotalReward.Equals(input.TotalReward)));
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
        sb.Append("class Wave {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  WaveUnitId: ").Append(WaveUnitId).Append("\n");
        sb.Append("  Amount: ").Append(Amount).Append("\n");
        sb.Append("  Amount2: ").Append(Amount2).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  SpellUnit2Id: ").Append(SpellUnit2Id).Append("\n");
        sb.Append("  IconPath: ").Append(IconPath).Append("\n");
        sb.Append("  LevelNum: ").Append(LevelNum).Append("\n");
        sb.Append("  PrepareTime: ").Append(PrepareTime).Append("\n");
        sb.Append("  TotalReward: ").Append(TotalReward).Append("\n");
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
        return Equals(input as Wave);
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

            if (Name != null)
            {
                hashCode = hashCode * 59 + Name.GetHashCode();
            }

            if (WaveUnitId != null)
            {
                hashCode = hashCode * 59 + WaveUnitId.GetHashCode();
            }

            if (Amount != null)
            {
                hashCode = hashCode * 59 + Amount.GetHashCode();
            }

            if (Amount2 != null)
            {
                hashCode = hashCode * 59 + Amount2.GetHashCode();
            }

            if (Category != null)
            {
                hashCode = hashCode * 59 + Category.GetHashCode();
            }

            if (SpellUnit2Id != null)
            {
                hashCode = hashCode * 59 + SpellUnit2Id.GetHashCode();
            }

            if (IconPath != null)
            {
                hashCode = hashCode * 59 + IconPath.GetHashCode();
            }

            if (LevelNum != null)
            {
                hashCode = hashCode * 59 + LevelNum.GetHashCode();
            }

            if (PrepareTime != null)
            {
                hashCode = hashCode * 59 + PrepareTime.GetHashCode();
            }

            if (TotalReward != null)
            {
                hashCode = hashCode * 59 + TotalReward.GetHashCode();
            }

            return hashCode;
        }
    }
}