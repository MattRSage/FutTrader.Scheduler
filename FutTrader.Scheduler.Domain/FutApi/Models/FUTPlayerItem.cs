using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FutTrader.Domain.FutApi.Models
{
    public class FUTPlayerItem
    {
        public Guid Id { get; set; }
        
        [JsonPropertyName("baseId")]
        public int BaseId { get; set; }
        
        [JsonPropertyName("rating")]
        public int Rating { get; set; }
        
        [JsonPropertyName("commonName")]
        public string CommonName { get; set; }
        
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        // [JsonPropertyName("league")]
        // public FUTLeagueItem League { get; set; }
        //
        // [JsonPropertyName("nation")]
        // public FUTNationItem Nation { get; set; }
        //
        // [JsonPropertyName("club")]
        // public FUTClubItem Club { get; set; }
        
        // [JsonPropertyName("attributes")]
        // public List<FUTAttribute> Attributes { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }
        
        [JsonPropertyName("composure")]
        public int Composure { get; set; }
        
        [JsonPropertyName("playStyle")]
        public string PlayStyle { get; set; }
        
        [JsonPropertyName("height")]
        public int Height { get; set; }
        
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        
        [JsonPropertyName("birthdate")]
        public string BirthDate { get; set; }
        
        [JsonPropertyName("age")]
        public int Age { get; set; }
        
        [JsonPropertyName("acceleration")]
        public int Acceleration { get; set; }
        
        [JsonPropertyName("aggression")]
        public int Aggression { get; set; }
        
        [JsonPropertyName("agility")]
        public int Agility { get; set; }
        
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        
        [JsonPropertyName("ballcontrol")]
        public int BallControl { get; set; }
        
        [JsonPropertyName("foot")]
        public string Foot { get; set; }
        
        [JsonPropertyName("skillmoves")]
        public int SkillMoves { get; set; }
        
        [JsonPropertyName("crossing")]
        public int Crossing { get; set; }
        
        [JsonPropertyName("curve")]
        public int Curve { get; set; }
        
        [JsonPropertyName("dribbling")]
        public int Dribbling { get; set; }
        
        [JsonPropertyName("finishing")]
        public int Finishing { get; set; }
        
        [JsonPropertyName("freekickaccuracy")]
        public int FreeKickAccuracy { get; set; }
        
        [JsonPropertyName("gkdiving")]
        public int GkDiving { get; set; }
        
        [JsonPropertyName("gkhandling")]
        public int GkHandling { get; set; }
        
        [JsonPropertyName("gkkicking")]
        public int GkKicking { get; set; }
        
        [JsonPropertyName("gkpositioning")]
        public int GkPositioning { get; set; }
        
        [JsonPropertyName("gkreflexes")]
        public int GkReflexes { get; set; }
        
        [JsonPropertyName("headingaccuracy")]
        public int HeadingAccuracy { get; set; }
        
        [JsonPropertyName("interceptions")]
        public int Interceptions { get; set; }
        
        [JsonPropertyName("jumping")]
        public int Jumping { get; set; }
        
        [JsonPropertyName("longpassing")]
        public int LongPassing { get; set; }
        
        [JsonPropertyName("longshots")]
        public int LongShots { get; set; }
        
        [JsonPropertyName("marking")]
        public int Marking { get; set; }
        
        [JsonPropertyName("penalties")]
        public int Penalties { get; set; }
        
        [JsonPropertyName("positioning")]
        public int Positioning { get; set; }
        
        [JsonPropertyName("potential")]
        public int Potential { get; set; }
        
        [JsonPropertyName("reactions")]
        public int Reactions { get; set; }
        
        [JsonPropertyName("shortpassing")]
        public int ShortPassing { get; set; }
        
        [JsonPropertyName("shotpower")]
        public int ShotPower { get; set; }
        
        [JsonPropertyName("slidingtackle")]
        public int SlidingTackle { get; set; }
        
        [JsonPropertyName("sprintspeed")]
        public int SprintSpeed { get; set; }
        
        [JsonPropertyName("standingtackle")]
        public int StandingTackle { get; set; }
        
        [JsonPropertyName("stamina")]
        public int Stamina { get; set; }
        
        [JsonPropertyName("strength")]
        public int Strength { get; set; }
        
        [JsonPropertyName("vision")]
        public int Vision { get; set; }
        
        [JsonPropertyName("volleys")]
        public int Volleys { get; set; }
        
        [JsonPropertyName("weakFoot")]
        public int WeakFoot { get; set; }
        
        [JsonPropertyName("traits")]
        public string[] Traits { get; set; }
        
        [JsonPropertyName("specialities")]
        public string[] Specialities { get; set; }
        
        [JsonPropertyName("atkWorkRate")]
        public string AttackWorkRate { get; set; }
        
        [JsonPropertyName("defWorkRate")]
        public string DefensiveWorkRate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("rarityId")]
        public int RarityId { get; set; }
        
        [JsonPropertyName("isIcon")]
        public bool IsIcon { get; set; }
        
        [JsonPropertyName("quality")]
        public string Quality { get; set; }
        
        [JsonPropertyName("isGK")]
        public bool IsGk { get; set; }
        
        [JsonPropertyName("positionFull")]
        public string PositionFull { get; set; }
        
        [JsonPropertyName("itemType")]
        public string ItemType { get; set; }
    }
}
