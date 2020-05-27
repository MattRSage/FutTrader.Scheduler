using System.Collections.Generic;

namespace FutTrader.Domain.SquadBuilder
{
    public class SquadPosition
    {
        public int Id { get; set; }
        public List<int> LinkIds { get; set; }
        public Position Position { get; set; }
        public Card Card { get; set; }
        public int Chemistry { get; set; }

        public int PositionChemistryPoints
        {
            get
            {
                if (Position == Card.Position)
                {
                    return 3;
                }

                switch (Position)
                {
                    case Position.LWB when Card.Position == Position.LB:
                    case Position.LB when Card.Position == Position.LWB:
                    case Position.RWB when Card.Position == Position.RB:
                    case Position.RB when Card.Position == Position.RWB:
                    case Position.CM when Card.Position == Position.CDM:
                    case Position.CDM when Card.Position == Position.CM:
                    case Position.CM when Card.Position == Position.CAM:
                    case Position.CAM when Card.Position == Position.CM:
                    case Position.CAM when Card.Position == Position.CF:
                    case Position.CF when Card.Position == Position.CAM:
                    case Position.CF when Card.Position == Position.ST:
                    case Position.ST when Card.Position == Position.CF:
                    case Position.RW when Card.Position == Position.RM:
                    case Position.RM when Card.Position == Position.RW:
                    case Position.LW when Card.Position == Position.LM:
                    case Position.LM when Card.Position == Position.LW:
                    case Position.RF when Card.Position == Position.RW:
                    case Position.RW when Card.Position == Position.RF:
                    case Position.LF when Card.Position == Position.LW:
                    case Position.LW when Card.Position == Position.LF:
                        return 2;
                    case Position.RB when Card.Position == Position.CB:
                    case Position.CB when Card.Position == Position.RB:
                    case Position.LB when Card.Position == Position.CB:
                    case Position.CB when Card.Position == Position.LB:
                    case Position.CB when Card.Position == Position.CDM:
                    case Position.CDM when Card.Position == Position.CB:
                    case Position.CB when Card.Position == Position.LB:
                    case Position.LB when Card.Position == Position.CB:
                    case Position.LWB when Card.Position == Position.LM:
                    case Position.LM when Card.Position == Position.LWB:
                    case Position.LWB when Card.Position == Position.RWB:
                    case Position.RWB when Card.Position == Position.LWB:
                    case Position.LWB when Card.Position == Position.LW:
                    case Position.LW when Card.Position == Position.LWB:
                    case Position.LB when Card.Position == Position.LM:
                    case Position.LM when Card.Position == Position.LB:
                    case Position.LB when Card.Position == Position.RB:
                    case Position.RB when Card.Position == Position.LB:
                    case Position.RWB when Card.Position == Position.RM:
                    case Position.RM when Card.Position == Position.RWB:
                    case Position.RWB when Card.Position == Position.RW:
                    case Position.RW when Card.Position == Position.RWB:
                    case Position.CM when Card.Position == Position.LM:
                    case Position.LM when Card.Position == Position.CM:
                    case Position.CM when Card.Position == Position.RM:
                    case Position.RM when Card.Position == Position.CM:
                    case Position.CDM when Card.Position == Position.CAM:
                    case Position.CAM when Card.Position == Position.CDM:
                    case Position.CF when Card.Position == Position.LF:
                    case Position.LF when Card.Position == Position.CF:
                    case Position.CF when Card.Position == Position.RF:
                    case Position.RF when Card.Position == Position.CF:
                    case Position.ST when Card.Position == Position.LF:
                    case Position.LF when Card.Position == Position.ST:
                    case Position.ST when Card.Position == Position.RF:
                    case Position.RF when Card.Position == Position.ST:
                    case Position.RF when Card.Position == Position.LF:
                    case Position.LF when Card.Position == Position.RF:
                    case Position.RF when Card.Position == Position.RM:
                    case Position.RM when Card.Position == Position.RF:
                    case Position.RW when Card.Position == Position.LW:
                    case Position.LW when Card.Position == Position.RW:
                        return 1;
                    default:
                        return -4;
                }
            }
        }
    }
}