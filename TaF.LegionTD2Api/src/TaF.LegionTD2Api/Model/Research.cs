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
///     Research
/// </summary>
[DataContract]
public class Research : IEquatable<Research>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Research" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Research() { }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Research" /> class.
    /// </summary>
    /// <param name="id">id.</param>
    /// <param name="name">name (required).</param>
    /// <param name="category">category.</param>
    /// <param name="legionId">legionId.</param>
    /// <param name="levels">levels.</param>
    /// <param name="tooltip">tooltip.</param>
    /// <param name="goldCost">goldCost.</param>
    /// <param name="iconPath">iconPath.</param>
    /// <param name="description">description.</param>
    /// <param name="mythiumCost">mythiumCost.</param>
    /// <param name="descriptionId">descriptionId.</param>
    /// <param name="goldCostPerLevel">goldCostPerLevel.</param>
    /// <param name="mythiumCostPerLevel">mythiumCostPerLevel.</param>
    public Research(string id = default, string name = default, string category = default, string legionId = default, string levels = default, string tooltip = default, string goldCost = default, string iconPath = default, string description = default, string mythiumCost = default, string descriptionId = default, string goldCostPerLevel = default, string mythiumCostPerLevel = default)
    {
        // to ensure "name" is required (not null)
        if (name == null)
        {
            throw new InvalidDataException("name is a required property for Research and cannot be null");
        }

        Name = name;

        Id = id;
        Category = category;
        LegionId = legionId;
        Levels = levels;
        Tooltip = tooltip;
        GoldCost = goldCost;
        IconPath = iconPath;
        Description = description;
        MythiumCost = mythiumCost;
        DescriptionId = descriptionId;
        GoldCostPerLevel = goldCostPerLevel;
        MythiumCostPerLevel = mythiumCostPerLevel;
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
    ///     Gets or Sets Category
    /// </summary>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    public string Category { get; set; }

    /// <summary>
    ///     Gets or Sets LegionId
    /// </summary>
    [DataMember(Name = "legionId", EmitDefaultValue = false)]
    public string LegionId { get; set; }

    /// <summary>
    ///     Gets or Sets Levels
    /// </summary>
    [DataMember(Name = "levels", EmitDefaultValue = false)]
    public string Levels { get; set; }

    /// <summary>
    ///     Gets or Sets Tooltip
    /// </summary>
    [DataMember(Name = "tooltip", EmitDefaultValue = false)]
    public string Tooltip { get; set; }

    /// <summary>
    ///     Gets or Sets GoldCost
    /// </summary>
    [DataMember(Name = "goldCost", EmitDefaultValue = false)]
    public string GoldCost { get; set; }

    /// <summary>
    ///     Gets or Sets IconPath
    /// </summary>
    [DataMember(Name = "iconPath", EmitDefaultValue = false)]
    public string IconPath { get; set; }

    /// <summary>
    ///     Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    /// <summary>
    ///     Gets or Sets MythiumCost
    /// </summary>
    [DataMember(Name = "mythiumCost", EmitDefaultValue = false)]
    public string MythiumCost { get; set; }

    /// <summary>
    ///     Gets or Sets DescriptionId
    /// </summary>
    [DataMember(Name = "descriptionId", EmitDefaultValue = false)]
    public string DescriptionId { get; set; }

    /// <summary>
    ///     Gets or Sets GoldCostPerLevel
    /// </summary>
    [DataMember(Name = "goldCostPerLevel", EmitDefaultValue = false)]
    public string GoldCostPerLevel { get; set; }

    /// <summary>
    ///     Gets or Sets MythiumCostPerLevel
    /// </summary>
    [DataMember(Name = "mythiumCostPerLevel", EmitDefaultValue = false)]
    public string MythiumCostPerLevel { get; set; }

    /// <summary>
    ///     Returns true if Research instances are equal
    /// </summary>
    /// <param name="input">Instance of Research to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Research input)
    {
        if (input == null)
        {
            return false;
        }

        return (Id == input.Id || (Id != null && Id.Equals(input.Id))) && (Name == input.Name || (Name != null && Name.Equals(input.Name))) && (Category == input.Category || (Category != null && Category.Equals(input.Category))) && (LegionId == input.LegionId || (LegionId != null && LegionId.Equals(input.LegionId))) && (Levels == input.Levels || (Levels != null && Levels.Equals(input.Levels))) && (Tooltip == input.Tooltip || (Tooltip != null && Tooltip.Equals(input.Tooltip))) && (GoldCost == input.GoldCost || (GoldCost != null && GoldCost.Equals(input.GoldCost))) && (IconPath == input.IconPath || (IconPath != null && IconPath.Equals(input.IconPath))) && (Description == input.Description || (Description != null && Description.Equals(input.Description))) && (MythiumCost == input.MythiumCost || (MythiumCost != null && MythiumCost.Equals(input.MythiumCost))) && (DescriptionId == input.DescriptionId || (DescriptionId != null && DescriptionId.Equals(input.DescriptionId))) && (GoldCostPerLevel == input.GoldCostPerLevel || (GoldCostPerLevel != null && GoldCostPerLevel.Equals(input.GoldCostPerLevel))) && (MythiumCostPerLevel == input.MythiumCostPerLevel || (MythiumCostPerLevel != null && MythiumCostPerLevel.Equals(input.MythiumCostPerLevel)));
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
        sb.Append("class Research {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  LegionId: ").Append(LegionId).Append("\n");
        sb.Append("  Levels: ").Append(Levels).Append("\n");
        sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
        sb.Append("  GoldCost: ").Append(GoldCost).Append("\n");
        sb.Append("  IconPath: ").Append(IconPath).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  MythiumCost: ").Append(MythiumCost).Append("\n");
        sb.Append("  DescriptionId: ").Append(DescriptionId).Append("\n");
        sb.Append("  GoldCostPerLevel: ").Append(GoldCostPerLevel).Append("\n");
        sb.Append("  MythiumCostPerLevel: ").Append(MythiumCostPerLevel).Append("\n");
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
        return Equals(input as Research);
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

            if (Category != null)
            {
                hashCode = hashCode * 59 + Category.GetHashCode();
            }

            if (LegionId != null)
            {
                hashCode = hashCode * 59 + LegionId.GetHashCode();
            }

            if (Levels != null)
            {
                hashCode = hashCode * 59 + Levels.GetHashCode();
            }

            if (Tooltip != null)
            {
                hashCode = hashCode * 59 + Tooltip.GetHashCode();
            }

            if (GoldCost != null)
            {
                hashCode = hashCode * 59 + GoldCost.GetHashCode();
            }

            if (IconPath != null)
            {
                hashCode = hashCode * 59 + IconPath.GetHashCode();
            }

            if (Description != null)
            {
                hashCode = hashCode * 59 + Description.GetHashCode();
            }

            if (MythiumCost != null)
            {
                hashCode = hashCode * 59 + MythiumCost.GetHashCode();
            }

            if (DescriptionId != null)
            {
                hashCode = hashCode * 59 + DescriptionId.GetHashCode();
            }

            if (GoldCostPerLevel != null)
            {
                hashCode = hashCode * 59 + GoldCostPerLevel.GetHashCode();
            }

            if (MythiumCostPerLevel != null)
            {
                hashCode = hashCode * 59 + MythiumCostPerLevel.GetHashCode();
            }

            return hashCode;
        }
    }
}