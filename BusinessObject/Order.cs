namespace BusinessObject
{
    public class Order
    {
        public int Id { get; set; } = -1;
        public int Member_id { get; set; }
        public DateTime Order_date { get; set; }
        public DateTime? Require_date { get; set; }
        public DateTime? Shipped_date { get; set; }
        public decimal? Freight { get; set; }
    }
}
