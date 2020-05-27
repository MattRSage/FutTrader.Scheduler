using System.Collections.Generic;

namespace FutTrader.Domain.SquadBuilder
{
    public class Squad
    {
        public List<SquadPosition> SquadPositions { get; set; } = new List<SquadPosition>();
    }
}