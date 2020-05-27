namespace FutTrader.Domain.SquadBuilder
{
    public class Card
    {
        public string Name { get; set; }
        public int LeagueId { get; set; }
        public int ClubId { get; set; }
        public int NationId { get; set; }
        public bool HasLoyalty { get; set; }
        public Position Position { get; set; }
    }
}