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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace TaF.LegionTD2Api.Model
{
    /// <summary>
    ///     PlayerMatchdetails
    /// </summary>
    [DataContract]
    public class PlayerMatchdetails : IEquatable<PlayerMatchdetails>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PlayerMatchdetails" /> class.
        /// </summary>
        /// <param name="playerId">playerId.</param>
        /// <param name="playerName">playerName.</param>
        /// <param name="playerSlot">playerSlot.</param>
        /// <param name="legion">legion.</param>
        /// <param name="workers">workers.</param>
        /// <param name="value">value.</param>
        /// <param name="cross">cross.</param>
        /// <param name="gameResult">gameResult.</param>
        /// <param name="overallElo">overallElo.</param>
        /// <param name="classicElo">classicElo.</param>
        /// <param name="fighters">fighters.</param>
        /// <param name="mercenaries">mercenaries.</param>
        /// <param name="stayedUntilEnd">stayedUntilEnd.</param>
        /// <param name="chosenSpell">chosenSpell.</param>
        /// <param name="chosenSpellLocation">chosenSpellLocation.</param>
        /// <param name="partySize">partySize.</param>
        /// <param name="firstWaveFighters">firstWaveFighters.</param>
        /// <param name="rolls">rolls.</param>
        /// <param name="eco">eco.</param>
        /// <param name="legionSpecificElo">legionSpecificElo.</param>
        /// <param name="partyMembers">partyMembers.</param>
        /// <param name="partyMembersId">partyMembersId.</param>
        /// <param name="mvpScore">mvpScore.</param>
        /// <param name="netWorthPerWave">netWorthPerWave.</param>
        /// <param name="workersPerWave">workersPerWave.</param>
        /// <param name="incomePerWave">incomePerWave.</param>
        /// <param name="mercenariesSentPerWave">mercenariesSentPerWave.</param>
        /// <param name="mercenariesReceivedPerWave">mercenariesReceivedPerWave.</param>
        /// <param name="leaksPerWave">leaksPerWave.</param>
        /// <param name="buildPerWave">buildPerWave.</param>
        /// <param name="leakValue">leakValue.</param>
        /// <param name="leaksCaughtValue">leaksCaughtValue.</param>
        /// <param name="leftAtSeconds">leftAtSeconds.</param>
        /// <param name="kingUpgradesPerWave">kingUpgradesPerWave.</param>
        /// <param name="receivedKingUpgradesPerWave">receivedKingUpgradesPerWave.</param>
        public PlayerMatchdetails(string playerId = default, string playerName = default, int playerSlot = default,
            string legion = default, int workers = default, int value = default, bool cross = default,
            string gameResult = default, int overallElo = default, int classicElo = default, string fighters = default,
            string mercenaries = default, bool stayedUntilEnd = default, string chosenSpell = default,
            string chosenSpellLocation = default, int partySize = default, string firstWaveFighters = default,
            string rolls = default, bool eco = default, int legionSpecificElo = default,
            List<string> partyMembers = default, List<string> partyMembersId = default, int mvpScore = default,
            List<int> netWorthPerWave = default, List<int> workersPerWave = default, List<int> incomePerWave = default,
            List<string> mercenariesSentPerWave = default, List<string> mercenariesReceivedPerWave = default,
            List<string> leaksPerWave = default, List<string> buildPerWave = default, int leakValue = default,
            int leaksCaughtValue = default, int leftAtSeconds = default, List<string> kingUpgradesPerWave = default,
            List<string> receivedKingUpgradesPerWave = default)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            PlayerSlot = playerSlot;
            Legion = legion;
            Workers = workers;
            Value = value;
            Cross = cross;
            GameResult = gameResult;
            OverallElo = overallElo;
            ClassicElo = classicElo;
            Fighters = fighters;
            Mercenaries = mercenaries;
            StayedUntilEnd = stayedUntilEnd;
            ChosenSpell = chosenSpell;
            ChosenSpellLocation = chosenSpellLocation;
            PartySize = partySize;
            FirstWaveFighters = firstWaveFighters;
            Rolls = rolls;
            Eco = eco;
            LegionSpecificElo = legionSpecificElo;
            PartyMembers = partyMembers;
            PartyMembersId = partyMembersId;
            MvpScore = mvpScore;
            NetWorthPerWave = netWorthPerWave;
            WorkersPerWave = workersPerWave;
            IncomePerWave = incomePerWave;
            MercenariesSentPerWave = mercenariesSentPerWave;
            MercenariesReceivedPerWave = mercenariesReceivedPerWave;
            LeaksPerWave = leaksPerWave;
            BuildPerWave = buildPerWave;
            LeakValue = leakValue;
            LeaksCaughtValue = leaksCaughtValue;
            LeftAtSeconds = leftAtSeconds;
            KingUpgradesPerWave = kingUpgradesPerWave;
            ReceivedKingUpgradesPerWave = receivedKingUpgradesPerWave;
        }

        /// <summary>
        ///     Gets or Sets PlayerId
        /// </summary>
        [DataMember(Name = "playerId", EmitDefaultValue = false)]
        public string PlayerId { get; set; }

        /// <summary>
        ///     Gets or Sets PlayerName
        /// </summary>
        [DataMember(Name = "playerName", EmitDefaultValue = false)]
        public string PlayerName { get; set; }

        /// <summary>
        ///     Gets or Sets PlayerSlot
        /// </summary>
        [DataMember(Name = "playerSlot", EmitDefaultValue = false)]
        public int PlayerSlot { get; set; }

        /// <summary>
        ///     Gets or Sets Legion
        /// </summary>
        [DataMember(Name = "legion", EmitDefaultValue = false)]
        public string Legion { get; set; }

        /// <summary>
        ///     Gets or Sets Workers
        /// </summary>
        [DataMember(Name = "workers", EmitDefaultValue = false)]
        public int Workers { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int Value { get; set; }

        /// <summary>
        ///     Gets or Sets Cross
        /// </summary>
        [DataMember(Name = "cross", EmitDefaultValue = false)]
        public bool Cross { get; set; }

        /// <summary>
        ///     Gets or Sets GameResult
        /// </summary>
        [DataMember(Name = "gameResult", EmitDefaultValue = false)]
        public string GameResult { get; set; }

        /// <summary>
        ///     Gets or Sets OverallElo
        /// </summary>
        [DataMember(Name = "overallElo", EmitDefaultValue = false)]
        public int OverallElo { get; set; }

        /// <summary>
        ///     Gets or Sets ClassicElo
        /// </summary>
        [DataMember(Name = "classicElo", EmitDefaultValue = false)]
        public int ClassicElo { get; set; }

        /// <summary>
        ///     Gets or Sets Fighters
        /// </summary>
        [DataMember(Name = "fighters", EmitDefaultValue = false)]
        public string Fighters { get; set; }

        /// <summary>
        ///     Gets or Sets Mercenaries
        /// </summary>
        [DataMember(Name = "mercenaries", EmitDefaultValue = false)]
        public string Mercenaries { get; set; }

        /// <summary>
        ///     Gets or Sets StayedUntilEnd
        /// </summary>
        [DataMember(Name = "stayedUntilEnd", EmitDefaultValue = false)]
        public bool StayedUntilEnd { get; set; }

        /// <summary>
        ///     Gets or Sets ChosenSpell
        /// </summary>
        [DataMember(Name = "chosenSpell", EmitDefaultValue = false)]
        public string ChosenSpell { get; set; }

        /// <summary>
        ///     Gets or Sets ChosenSpellLocation
        /// </summary>
        [DataMember(Name = "chosenSpellLocation", EmitDefaultValue = false)]
        public string ChosenSpellLocation { get; set; }

        /// <summary>
        ///     Gets or Sets PartySize
        /// </summary>
        [DataMember(Name = "partySize", EmitDefaultValue = false)]
        public int PartySize { get; set; }

        /// <summary>
        ///     Gets or Sets FirstWaveFighters
        /// </summary>
        [DataMember(Name = "firstWaveFighters", EmitDefaultValue = false)]
        public string FirstWaveFighters { get; set; }

        /// <summary>
        ///     Gets or Sets Rolls
        /// </summary>
        [DataMember(Name = "rolls", EmitDefaultValue = false)]
        public string Rolls { get; set; }

        /// <summary>
        ///     Gets or Sets Eco
        /// </summary>
        [DataMember(Name = "eco", EmitDefaultValue = false)]
        public bool Eco { get; set; }

        /// <summary>
        ///     Gets or Sets LegionSpecificElo
        /// </summary>
        [DataMember(Name = "legionSpecificElo", EmitDefaultValue = false)]
        public int LegionSpecificElo { get; set; }

        /// <summary>
        ///     Gets or Sets PartyMembers
        /// </summary>
        [DataMember(Name = "partyMembers", EmitDefaultValue = false)]
        public List<string> PartyMembers { get; set; }

        /// <summary>
        ///     Gets or Sets PartyMembersId
        /// </summary>
        [DataMember(Name = "partyMembersId", EmitDefaultValue = false)]
        public List<string> PartyMembersId { get; set; }

        /// <summary>
        ///     Gets or Sets MvpScore
        /// </summary>
        [DataMember(Name = "mvpScore", EmitDefaultValue = false)]
        [Obsolete]
        public int MvpScore { get; set; }

        /// <summary>
        ///     Gets or Sets NetWorthPerWave
        /// </summary>
        [DataMember(Name = "netWorthPerWave", EmitDefaultValue = false)]
        public List<int> NetWorthPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets WorkersPerWave
        /// </summary>
        [DataMember(Name = "workersPerWave", EmitDefaultValue = false)]
        public List<int> WorkersPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets IncomePerWave
        /// </summary>
        [DataMember(Name = "incomePerWave", EmitDefaultValue = false)]
        public List<int> IncomePerWave { get; set; }

        /// <summary>
        ///     Gets or Sets MercenariesSentPerWave
        /// </summary>
        [DataMember(Name = "mercenariesSentPerWave", EmitDefaultValue = false)]
        public List<string> MercenariesSentPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets MercenariesReceivedPerWave
        /// </summary>
        [DataMember(Name = "mercenariesReceivedPerWave", EmitDefaultValue = false)]
        public List<string> MercenariesReceivedPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets LeaksPerWave
        /// </summary>
        [DataMember(Name = "leaksPerWave", EmitDefaultValue = false)]
        public List<string> LeaksPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets BuildPerWave
        /// </summary>
        [DataMember(Name = "buildPerWave", EmitDefaultValue = false)]
        public List<string> BuildPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets LeakValue
        /// </summary>
        [DataMember(Name = "leakValue", EmitDefaultValue = false)]
        public int LeakValue { get; set; }

        /// <summary>
        ///     Gets or Sets LeaksCaughtValue
        /// </summary>
        [DataMember(Name = "leaksCaughtValue", EmitDefaultValue = false)]
        public int LeaksCaughtValue { get; set; }

        /// <summary>
        ///     Gets or Sets LeftAtSeconds
        /// </summary>
        [DataMember(Name = "leftAtSeconds", EmitDefaultValue = false)]
        public int LeftAtSeconds { get; set; }

        /// <summary>
        ///     Gets or Sets KingUpgradesPerWave
        /// </summary>
        [DataMember(Name = "kingUpgradesPerWave", EmitDefaultValue = false)]
        public List<string> KingUpgradesPerWave { get; set; }

        /// <summary>
        ///     Gets or Sets ReceivedKingUpgradesPerWave
        /// </summary>
        [DataMember(Name = "receivedKingUpgradesPerWave", EmitDefaultValue = false)]
        public List<string> ReceivedKingUpgradesPerWave { get; set; }

        /// <summary>
        ///     Returns true if PlayerMatchdetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerMatchdetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerMatchdetails input)
        {
            if (input == null)
                return false;

            return
                (
                    PlayerId == input.PlayerId ||
                    (PlayerId != null &&
                     PlayerId.Equals(input.PlayerId))
                ) &&
                (
                    PlayerName == input.PlayerName ||
                    (PlayerName != null &&
                     PlayerName.Equals(input.PlayerName))
                ) &&
                (
                    PlayerSlot == input.PlayerSlot ||
                    (PlayerSlot != null &&
                     PlayerSlot.Equals(input.PlayerSlot))
                ) &&
                (
                    Legion == input.Legion ||
                    (Legion != null &&
                     Legion.Equals(input.Legion))
                ) &&
                (
                    Workers == input.Workers ||
                    (Workers != null &&
                     Workers.Equals(input.Workers))
                ) &&
                (
                    Value == input.Value ||
                    (Value != null &&
                     Value.Equals(input.Value))
                ) &&
                (
                    Cross == input.Cross ||
                    (Cross != null &&
                     Cross.Equals(input.Cross))
                ) &&
                (
                    GameResult == input.GameResult ||
                    (GameResult != null &&
                     GameResult.Equals(input.GameResult))
                ) &&
                (
                    OverallElo == input.OverallElo ||
                    (OverallElo != null &&
                     OverallElo.Equals(input.OverallElo))
                ) &&
                (
                    ClassicElo == input.ClassicElo ||
                    (ClassicElo != null &&
                     ClassicElo.Equals(input.ClassicElo))
                ) &&
                (
                    Fighters == input.Fighters ||
                    (Fighters != null &&
                     Fighters.Equals(input.Fighters))
                ) &&
                (
                    Mercenaries == input.Mercenaries ||
                    (Mercenaries != null &&
                     Mercenaries.Equals(input.Mercenaries))
                ) &&
                (
                    StayedUntilEnd == input.StayedUntilEnd ||
                    (StayedUntilEnd != null &&
                     StayedUntilEnd.Equals(input.StayedUntilEnd))
                ) &&
                (
                    ChosenSpell == input.ChosenSpell ||
                    (ChosenSpell != null &&
                     ChosenSpell.Equals(input.ChosenSpell))
                ) &&
                (
                    ChosenSpellLocation == input.ChosenSpellLocation ||
                    (ChosenSpellLocation != null &&
                     ChosenSpellLocation.Equals(input.ChosenSpellLocation))
                ) &&
                (
                    PartySize == input.PartySize ||
                    (PartySize != null &&
                     PartySize.Equals(input.PartySize))
                ) &&
                (
                    FirstWaveFighters == input.FirstWaveFighters ||
                    (FirstWaveFighters != null &&
                     FirstWaveFighters.Equals(input.FirstWaveFighters))
                ) &&
                (
                    Rolls == input.Rolls ||
                    (Rolls != null &&
                     Rolls.Equals(input.Rolls))
                ) &&
                (
                    Eco == input.Eco ||
                    (Eco != null &&
                     Eco.Equals(input.Eco))
                ) &&
                (
                    LegionSpecificElo == input.LegionSpecificElo ||
                    (LegionSpecificElo != null &&
                     LegionSpecificElo.Equals(input.LegionSpecificElo))
                ) &&
                (
                    PartyMembers == input.PartyMembers ||
                    (PartyMembers != null &&
                     input.PartyMembers != null &&
                     PartyMembers.SequenceEqual(input.PartyMembers))
                ) &&
                (
                    PartyMembersId == input.PartyMembersId ||
                    (PartyMembersId != null &&
                     input.PartyMembersId != null &&
                     PartyMembersId.SequenceEqual(input.PartyMembersId))
                ) &&
                (
                    MvpScore == input.MvpScore ||
                    (MvpScore != null &&
                     MvpScore.Equals(input.MvpScore))
                ) &&
                (
                    NetWorthPerWave == input.NetWorthPerWave ||
                    (NetWorthPerWave != null &&
                     input.NetWorthPerWave != null &&
                     NetWorthPerWave.SequenceEqual(input.NetWorthPerWave))
                ) &&
                (
                    WorkersPerWave == input.WorkersPerWave ||
                    (WorkersPerWave != null &&
                     input.WorkersPerWave != null &&
                     WorkersPerWave.SequenceEqual(input.WorkersPerWave))
                ) &&
                (
                    IncomePerWave == input.IncomePerWave ||
                    (IncomePerWave != null &&
                     input.IncomePerWave != null &&
                     IncomePerWave.SequenceEqual(input.IncomePerWave))
                ) &&
                (
                    MercenariesSentPerWave == input.MercenariesSentPerWave ||
                    (MercenariesSentPerWave != null &&
                     input.MercenariesSentPerWave != null &&
                     MercenariesSentPerWave.SequenceEqual(input.MercenariesSentPerWave))
                ) &&
                (
                    MercenariesReceivedPerWave == input.MercenariesReceivedPerWave ||
                    (MercenariesReceivedPerWave != null &&
                     input.MercenariesReceivedPerWave != null &&
                     MercenariesReceivedPerWave.SequenceEqual(input.MercenariesReceivedPerWave))
                ) &&
                (
                    LeaksPerWave == input.LeaksPerWave ||
                    (LeaksPerWave != null &&
                     input.LeaksPerWave != null &&
                     LeaksPerWave.SequenceEqual(input.LeaksPerWave))
                ) &&
                (
                    BuildPerWave == input.BuildPerWave ||
                    (BuildPerWave != null &&
                     input.BuildPerWave != null &&
                     BuildPerWave.SequenceEqual(input.BuildPerWave))
                ) &&
                (
                    LeakValue == input.LeakValue ||
                    (LeakValue != null &&
                     LeakValue.Equals(input.LeakValue))
                ) &&
                (
                    LeaksCaughtValue == input.LeaksCaughtValue ||
                    (LeaksCaughtValue != null &&
                     LeaksCaughtValue.Equals(input.LeaksCaughtValue))
                ) &&
                (
                    LeftAtSeconds == input.LeftAtSeconds ||
                    (LeftAtSeconds != null &&
                     LeftAtSeconds.Equals(input.LeftAtSeconds))
                ) &&
                (
                    KingUpgradesPerWave == input.KingUpgradesPerWave ||
                    (KingUpgradesPerWave != null &&
                     input.KingUpgradesPerWave != null &&
                     KingUpgradesPerWave.SequenceEqual(input.KingUpgradesPerWave))
                ) &&
                (
                    ReceivedKingUpgradesPerWave == input.ReceivedKingUpgradesPerWave ||
                    (ReceivedKingUpgradesPerWave != null &&
                     input.ReceivedKingUpgradesPerWave != null &&
                     ReceivedKingUpgradesPerWave.SequenceEqual(input.ReceivedKingUpgradesPerWave))
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
            sb.Append("class PlayerMatchdetails {\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  PlayerName: ").Append(PlayerName).Append("\n");
            sb.Append("  PlayerSlot: ").Append(PlayerSlot).Append("\n");
            sb.Append("  Legion: ").Append(Legion).Append("\n");
            sb.Append("  Workers: ").Append(Workers).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Cross: ").Append(Cross).Append("\n");
            sb.Append("  GameResult: ").Append(GameResult).Append("\n");
            sb.Append("  OverallElo: ").Append(OverallElo).Append("\n");
            sb.Append("  ClassicElo: ").Append(ClassicElo).Append("\n");
            sb.Append("  Fighters: ").Append(Fighters).Append("\n");
            sb.Append("  Mercenaries: ").Append(Mercenaries).Append("\n");
            sb.Append("  StayedUntilEnd: ").Append(StayedUntilEnd).Append("\n");
            sb.Append("  ChosenSpell: ").Append(ChosenSpell).Append("\n");
            sb.Append("  ChosenSpellLocation: ").Append(ChosenSpellLocation).Append("\n");
            sb.Append("  PartySize: ").Append(PartySize).Append("\n");
            sb.Append("  FirstWaveFighters: ").Append(FirstWaveFighters).Append("\n");
            sb.Append("  Rolls: ").Append(Rolls).Append("\n");
            sb.Append("  Eco: ").Append(Eco).Append("\n");
            sb.Append("  LegionSpecificElo: ").Append(LegionSpecificElo).Append("\n");
            sb.Append("  PartyMembers: ").Append(PartyMembers).Append("\n");
            sb.Append("  PartyMembersId: ").Append(PartyMembersId).Append("\n");
            sb.Append("  MvpScore: ").Append(MvpScore).Append("\n");
            sb.Append("  NetWorthPerWave: ").Append(NetWorthPerWave).Append("\n");
            sb.Append("  WorkersPerWave: ").Append(WorkersPerWave).Append("\n");
            sb.Append("  IncomePerWave: ").Append(IncomePerWave).Append("\n");
            sb.Append("  MercenariesSentPerWave: ").Append(MercenariesSentPerWave).Append("\n");
            sb.Append("  MercenariesReceivedPerWave: ").Append(MercenariesReceivedPerWave).Append("\n");
            sb.Append("  LeaksPerWave: ").Append(LeaksPerWave).Append("\n");
            sb.Append("  BuildPerWave: ").Append(BuildPerWave).Append("\n");
            sb.Append("  LeakValue: ").Append(LeakValue).Append("\n");
            sb.Append("  LeaksCaughtValue: ").Append(LeaksCaughtValue).Append("\n");
            sb.Append("  LeftAtSeconds: ").Append(LeftAtSeconds).Append("\n");
            sb.Append("  KingUpgradesPerWave: ").Append(KingUpgradesPerWave).Append("\n");
            sb.Append("  ReceivedKingUpgradesPerWave: ").Append(ReceivedKingUpgradesPerWave).Append("\n");
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
            return Equals(input as PlayerMatchdetails);
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
                if (PlayerId != null)
                    hashCode = hashCode * 59 + PlayerId.GetHashCode();
                if (PlayerName != null)
                    hashCode = hashCode * 59 + PlayerName.GetHashCode();
                if (PlayerSlot != null)
                    hashCode = hashCode * 59 + PlayerSlot.GetHashCode();
                if (Legion != null)
                    hashCode = hashCode * 59 + Legion.GetHashCode();
                if (Workers != null)
                    hashCode = hashCode * 59 + Workers.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (Cross != null)
                    hashCode = hashCode * 59 + Cross.GetHashCode();
                if (GameResult != null)
                    hashCode = hashCode * 59 + GameResult.GetHashCode();
                if (OverallElo != null)
                    hashCode = hashCode * 59 + OverallElo.GetHashCode();
                if (ClassicElo != null)
                    hashCode = hashCode * 59 + ClassicElo.GetHashCode();
                if (Fighters != null)
                    hashCode = hashCode * 59 + Fighters.GetHashCode();
                if (Mercenaries != null)
                    hashCode = hashCode * 59 + Mercenaries.GetHashCode();
                if (StayedUntilEnd != null)
                    hashCode = hashCode * 59 + StayedUntilEnd.GetHashCode();
                if (ChosenSpell != null)
                    hashCode = hashCode * 59 + ChosenSpell.GetHashCode();
                if (ChosenSpellLocation != null)
                    hashCode = hashCode * 59 + ChosenSpellLocation.GetHashCode();
                if (PartySize != null)
                    hashCode = hashCode * 59 + PartySize.GetHashCode();
                if (FirstWaveFighters != null)
                    hashCode = hashCode * 59 + FirstWaveFighters.GetHashCode();
                if (Rolls != null)
                    hashCode = hashCode * 59 + Rolls.GetHashCode();
                if (Eco != null)
                    hashCode = hashCode * 59 + Eco.GetHashCode();
                if (LegionSpecificElo != null)
                    hashCode = hashCode * 59 + LegionSpecificElo.GetHashCode();
                if (PartyMembers != null)
                    hashCode = hashCode * 59 + PartyMembers.GetHashCode();
                if (PartyMembersId != null)
                    hashCode = hashCode * 59 + PartyMembersId.GetHashCode();
                if (MvpScore != null)
                    hashCode = hashCode * 59 + MvpScore.GetHashCode();
                if (NetWorthPerWave != null)
                    hashCode = hashCode * 59 + NetWorthPerWave.GetHashCode();
                if (WorkersPerWave != null)
                    hashCode = hashCode * 59 + WorkersPerWave.GetHashCode();
                if (IncomePerWave != null)
                    hashCode = hashCode * 59 + IncomePerWave.GetHashCode();
                if (MercenariesSentPerWave != null)
                    hashCode = hashCode * 59 + MercenariesSentPerWave.GetHashCode();
                if (MercenariesReceivedPerWave != null)
                    hashCode = hashCode * 59 + MercenariesReceivedPerWave.GetHashCode();
                if (LeaksPerWave != null)
                    hashCode = hashCode * 59 + LeaksPerWave.GetHashCode();
                if (BuildPerWave != null)
                    hashCode = hashCode * 59 + BuildPerWave.GetHashCode();
                if (LeakValue != null)
                    hashCode = hashCode * 59 + LeakValue.GetHashCode();
                if (LeaksCaughtValue != null)
                    hashCode = hashCode * 59 + LeaksCaughtValue.GetHashCode();
                if (LeftAtSeconds != null)
                    hashCode = hashCode * 59 + LeftAtSeconds.GetHashCode();
                if (KingUpgradesPerWave != null)
                    hashCode = hashCode * 59 + KingUpgradesPerWave.GetHashCode();
                if (ReceivedKingUpgradesPerWave != null)
                    hashCode = hashCode * 59 + ReceivedKingUpgradesPerWave.GetHashCode();
                return hashCode;
            }
        }
    }
}