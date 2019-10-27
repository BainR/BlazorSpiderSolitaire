namespace BlazorSpider.Models
{
    public class PlayingCardModel
    {
        private const string CardIds = "A23456789TJQK";
        public int Id { get; set; }
        public int Value { get; set; }
        public Suit Suit { get; set; }
        public string Description { get { return IsFaceDown ? "Back of Card" : CardIds.Substring(Value-1, 1) + " " + Suit.ToString(); } }
        public string ImageUrl { get { return IsFaceDown ? "Images/2B.svg" : "Images/" + CardIds.Substring(Value - 1, 1) + this.Suit.ToString().Substring(0,1) + ".svg"; } }
        public int PileId { get; set; }
        public int DealId { get; set; }
        public int CompletedId { get; set; }
        public int PileSequence { get; set; }
        public bool IsFaceDown { get; set; }
    }
}

public enum Suit
{
    Spade,
    Heart,
    Club,
    Diamond
}
