namespace CQRSProject.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
