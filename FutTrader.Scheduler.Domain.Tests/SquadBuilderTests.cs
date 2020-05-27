using System;
using System.Collections.Generic;
using FutTrader.Domain.FutTraderPlayerApi;
using FutTrader.Domain.SquadBuilder;
using Xunit;

namespace FutTrader.Scheduler.Domain.Tests
{
    public class SquadBuilderTests
    {
        public static object[][] TestSquadData =
        {
            new object[]
            {
                new Squad()
                {
                    SquadPositions =
                    {
                        new SquadPosition()
                        {
                            Id = 1,
                            Position = Position.GK,
                            Card = new Card
                            {
                                Name = "Ter Stegen",
                                Position = Position.GK,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 1 // Germany
                            },
                            LinkIds = new List<int> {3, 4},
                        },
                        new SquadPosition()
                        {
                            Id = 2,
                            Position = Position.LB,
                            Card = new Card
                            {
                                Name = "Junior Firpo",
                                HasLoyalty = true,
                                Position = Position.LB,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 2 // Spain
                            },
                            LinkIds = new List<int> {3, 6}
                        },
                        new SquadPosition()
                        {
                            Id = 3,
                            Position = Position.CB,
                            Card = new Card
                            {
                                Name = "Eder Militao",
                                Position = Position.CB,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 2, // Real Madrid
                                NationId = 3 // Brazil
                            },
                            LinkIds = new List<int> {1, 2, 4, 7}
                        },
                        new SquadPosition()
                        {
                            Id = 4,
                            Position = Position.CB,
                            Card = new Card
                            {
                                Name = "Mario Hermoso",
                                Position = Position.CB,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 3, // Atletico
                                NationId = 2 // Spain
                            },
                            LinkIds = new List<int> {1, 3, 5, 8}
                        },
                        new SquadPosition()
                        {
                            Id = 5,
                            Position = Position.RB,
                            Card = new Card
                            {
                                Name = "Wan Bissaka",
                                Position = Position.RB,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 4, // Man Utd
                                NationId = 4 // England
                            },
                            LinkIds = new List<int> {4, 9}
                        },
                        new SquadPosition()
                        {
                            Id = 6,
                            Position = Position.LM,
                            Card = new Card
                            {
                                Name = "Lemar",
                                Position = Position.LM,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 3, // Atletico
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {2, 7, 10}
                        },
                        new SquadPosition()
                        {
                            Id = 7,
                            Position = Position.CM,
                            Card = new Card
                            {
                                Name = "Sissoko",
                                Position = Position.CM,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 5, // Spurs
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {3, 6, 8, 10}
                        },
                        new SquadPosition()
                        {
                            Id = 8,
                            Position = Position.CM,
                            Card = new Card
                            {
                                Name = "NDombele",
                                Position = Position.CM,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 5, // Spurs
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {4, 7, 9, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 9,
                            Position = Position.RM,
                            Card = new Card
                            {
                                Name = "Promes",
                                Position = Position.LW,
                                HasLoyalty = true,
                                LeagueId = 3, // Eridversie
                                ClubId = 6, // Ajax
                                NationId = 6 // Netherlands
                            },
                            LinkIds = new List<int> {5, 8, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 10,
                            Position = Position.ST,
                            Card = new Card
                            {
                                Name = "Ben Yedder",
                                Position = Position.ST,
                                HasLoyalty = true,
                                LeagueId = 4, // Ligue 1
                                ClubId = 7, // Monaco
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {6, 7, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 11,
                            Position = Position.ST,
                            Card = new Card
                            {
                                Name = "Lucas",
                                Position = Position.CF,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 5, // Spurs
                                NationId = 2 // Brazil
                            },
                            LinkIds = new List<int> {8, 9, 10}
                        }
                    }
                },
                82
            },
            new object[]
            {
                new Squad()
                {
                    SquadPositions =
                    {
                        new SquadPosition()
                        {
                            Id = 1,
                            Position = Position.GK,
                            Card = new Card
                            {
                                Name = "Ter Stegen",
                                Position = Position.GK,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 1 // Germany
                            },
                            LinkIds = new List<int> {3, 4},
                        },
                        new SquadPosition()
                        {
                            Id = 2,
                            Position = Position.LB,
                            Card = new Card
                            {
                                Name = "Junior Firpo",
                                HasLoyalty = true,
                                Position = Position.LB,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 2 // Spain
                            },
                            LinkIds = new List<int> {3, 6}
                        },
                        new SquadPosition()
                        {
                            Id = 3,
                            Position = Position.CB,
                            Card = new Card
                            {
                                Name = "Eder Militao",
                                Position = Position.CB,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 2, // Real Madrid
                                NationId = 3 // Brazil
                            },
                            LinkIds = new List<int> {1, 2, 4, 7}
                        },
                        new SquadPosition()
                        {
                            Id = 4,
                            Position = Position.CB,
                            Card = new Card
                            {
                                Name = "Mario Hermoso",
                                Position = Position.CB,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 3, // Atletico
                                NationId = 2 // Spain
                            },
                            LinkIds = new List<int> {1, 3, 5, 8}
                        },
                        new SquadPosition()
                        {
                            Id = 5,
                            Position = Position.RB,
                            Card = new Card
                            {
                                Name = "Nelson Semedo",
                                Position = Position.RB,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 6 // Portugal
                            },
                            LinkIds = new List<int> {4, 9}
                        },
                        new SquadPosition()
                        {
                            Id = 6,
                            Position = Position.LM,
                            Card = new Card
                            {
                                Name = "Lemar",
                                Position = Position.LM,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 3, // Atletico
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {2, 7, 10}
                        },
                        new SquadPosition()
                        {
                            Id = 7,
                            Position = Position.CM,
                            Card = new Card
                            {
                                Name = "Sissoko",
                                Position = Position.CM,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 5, // Spurs
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {3, 6, 8, 10}
                        },
                        new SquadPosition()
                        {
                            Id = 8,
                            Position = Position.CM,
                            Card = new Card
                            {
                                Name = "NDombele",
                                Position = Position.CM,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 5, // Spurs
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {4, 7, 9, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 9,
                            Position = Position.RM,
                            Card = new Card
                            {
                                Name = "Dembele",
                                Position = Position.RW,
                                HasLoyalty = true,
                                LeagueId = 1, // La Liga
                                ClubId = 1, // Barcelona
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {5, 8, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 10,
                            Position = Position.ST,
                            Card = new Card
                            {
                                Name = "Ben Yedder",
                                Position = Position.ST,
                                HasLoyalty = true,
                                LeagueId = 4, // Ligue 1
                                ClubId = 7, // Monaco
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {6, 7, 11}
                        },
                        new SquadPosition()
                        {
                            Id = 11,
                            Position = Position.ST,
                            Card = new Card
                            {
                                Name = "Haller",
                                Position = Position.ST,
                                HasLoyalty = true,
                                LeagueId = 2, // EPL
                                ClubId = 8, // West Ham
                                NationId = 5 // France
                            },
                            LinkIds = new List<int> {8, 9, 10}
                        }
                    }
                },
                100
            }
        };


        [Theory]
        [MemberData(nameof(TestSquadData))]
        public void Calculate_82ChemistryTeam_Has82Chemistry(Squad squad, int expectedChemistry)
        {
            var squadBuilder = new SquadBuilder();
            var squadChemistry = squadBuilder.CalculateSquadChemistry(squad);

            Assert.Equal(expectedChemistry, squadChemistry);
        }
    }
}