using System.Linq;

namespace FutTrader.Domain.SquadBuilder
{
    public class SquadBuilder
    {
        
        
        
        public int CalculateSquadChemistry(Squad squad)
        {
            foreach (var position in squad.SquadPositions)
            {
                var chemMultiplier = 0d;
                var cardLinks = squad.SquadPositions.Where(x => position.LinkIds.Contains(x.Id));
                
				foreach(var cardLink in cardLinks) {
                    if (cardLink.Card.LeagueId == position.Card.LeagueId)
                    {
                        chemMultiplier += 1;
                    }
                    
                    if (cardLink.Card.NationId == position.Card.NationId)
                    {
                        chemMultiplier += 1;
                    }
                    
                    if (cardLink.Card.ClubId == position.Card.ClubId)
                    {
                        chemMultiplier += 1;
                    }
                }

                var chemistryLines = GetChemistryLines(chemMultiplier, position.PositionChemistryPoints, position.LinkIds.Count);
                
                var chemistrySum = position.PositionChemistryPoints + chemistryLines;

                if (chemistrySum < 0)
                {
                    chemistrySum = 0;
                }

                if (chemistrySum > 10)
                {
                    chemistrySum = 10;
                }
                
                chemistrySum += position.Card.HasLoyalty ? 1 : 0;

                position.Chemistry = chemistrySum;
            }

            var squadChemistry = squad.SquadPositions.Sum(x => x.Chemistry);

            if (squadChemistry > 100)
            {
                squadChemistry = 100;
            }

            return squadChemistry;
        }

        private int GetChemistryLines(double chemistryLinksScore, int chemistryPositionScore, int numberOfLinks)
        {
            var divide = chemistryLinksScore / numberOfLinks;
            int chemLines;
            
            if (divide > 1.6)
            {
                chemLines = 7;
            }
            else if (divide >= 1)
            {
                chemLines = 6;
            }
            else if (divide > 0.32)
            {
                chemLines = 3;
            }
            else
            {
                chemLines = 0;
            }
                
            if (chemistryPositionScore == 1 && chemLines > 5) {
                chemLines = 4;
            }
            if (chemistryPositionScore == 1 && chemLines == 3) {
                chemLines = 2;
            }
            if (chemistryPositionScore == -4 && chemLines == 3) {
                chemLines = 5;
            }
            if (chemistryPositionScore == -4 && chemLines == 7) {
                chemLines = 6;
            }

            return chemLines;
        }
    }
    
    public enum Position
    {
        GK,
        LWB,
        LB,
        CB,
        RB,
        RWB,
        CDM,
        CM,
        CAM,
        LM,
        LW,
        LF,
        RM,
        RW,
        RF,
        CF,
        ST
    }
}