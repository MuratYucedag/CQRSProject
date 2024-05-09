namespace CQRSProject.CQRS.Commands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
