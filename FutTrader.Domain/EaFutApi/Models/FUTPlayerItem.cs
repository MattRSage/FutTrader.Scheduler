using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Crawler.Models
{
    public class FUTPlayerItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("baseId")]
        public int BaseId { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("commonName")]
        public string CommonName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("league")]
        public FUTLeagueItem League { get; set; }

        [JsonProperty("nation")]
        public FUTNationItem Nation { get; set; }

        [JsonProperty("club")]
        public FUTClubItem Club { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("composure")]
        public int Composure { get; set; }

        [JsonProperty("playStyle")]
        public string PlayStyle { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("birthdate")]
        public string BirthDate { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("acceleration")]
        public int Acceleration { get; set; }

        [JsonProperty("aggression")]
        public int Aggression { get; set; }

        [JsonProperty("agility")]
        public int Agility { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("ballcontrol")]
        public int BallControl { get; set; }

        [JsonProperty("foot")]
        public string Foot { get; set; }

        [JsonProperty("skillmoves")]
        public int SkillMoves { get; set; }

        [JsonProperty("crossing")]
        public int Crossing { get; set; }

        [JsonProperty("curve")]
        public int Curve { get; set; }

        [JsonProperty("dribbling")]
        public int Dribbling { get; set; }

        [JsonProperty("finishing")]
        public int Finishing { get; set; }

        [JsonProperty("freekickaccuracy")]
        public int FreeKickAccuracy { get; set; }

        [JsonProperty("gkdiving")]
        public int GkDiving { get; set; }

        [JsonProperty("gkhandling")]
        public int GkHandling { get; set; }

        [JsonProperty("gkkicking")]
        public int GkKicking { get; set; }

        [JsonProperty("gkpositioning")]
        public int GkPositioning { get; set; }

        [JsonProperty("gkreflexes")]
        public int GkReflexes { get; set; }

        [JsonProperty("headingaccuracy")]
        public int HeadingAccuracy { get; set; }

        [JsonProperty("interceptions")]
        public int Interceptions { get; set; }

        [JsonProperty("jumping")]
        public int Jumping { get; set; }

        [JsonProperty("longpassing")]
        public int LongPassing { get; set; }

        [JsonProperty("longshots")]
        public int LongShots { get; set; }

        [JsonProperty("marking")]
        public int Marking { get; set; }

        [JsonProperty("penalties")]
        public int Penalties { get; set; }

        [JsonProperty("positioning")]
        public int Positioning { get; set; }

        [JsonProperty("potential")]
        public int Potential { get; set; }

        [JsonProperty("reactions")]
        public int Reactions { get; set; }

        [JsonProperty("shortpassing")]
        public int ShortPassing { get; set; }

        [JsonProperty("shotpower")]
        public int ShotPower { get; set; }

        [JsonProperty("slidingtackle")]
        public int SlidingTackle { get; set; }

        [JsonProperty("sprintspeed")]
        public int SprintSpeed { get; set; }

        [JsonProperty("standingtackle")]
        public int StandingTackle { get; set; }

        [JsonProperty("stamina")]
        public int Stamina { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("vision")]
        public int Vision { get; set; }

        [JsonProperty("volleys")]
        public int Volleys { get; set; }

        [JsonProperty("weakFoot")]
        public int WeakFoot { get; set; }

        [JsonProperty("traits")]
        public string[] Traits { get; set; }

        [JsonProperty("specialities")]
        public string[] Specialities { get; set; }

        [JsonProperty("atkWorkRate")]
        public string AttackWorkRate { get; set; }

        [JsonProperty("defWorkRate")]
        public string DefensiveWorkRate { get; set; }

        [JsonProperty("attributes")]
        public List<FUTAttribute> Attributes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarityId")]
        public int RarityId { get; set; }

        [JsonProperty("isIcon")]
        public bool IsIcon { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("isGK")]
        public bool IsGk { get; set; }

        [JsonProperty("positionFull")]
        public string PositionFull { get; set; }

        [JsonProperty("isSpecialType")]
        public string IsSpecialType { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }
    }
}
