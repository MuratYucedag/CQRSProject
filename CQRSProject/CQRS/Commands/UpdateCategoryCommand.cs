namespace CQRSProject.CQRS.Commands
{
    public class UpdateCategoryCommand
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
