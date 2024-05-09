namespace CQRSProject.CQRS.Results
{
    public class GetProductQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}