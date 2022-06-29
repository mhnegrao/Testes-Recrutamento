namespace TradeCategory.Model
{
    public class Business
    {
        public int IdBusiness { get; set; }
        public DateTime DateRef { get; set; }
        public List<Trade> Trades { get; set; } = new List<Trade>();
    }
}