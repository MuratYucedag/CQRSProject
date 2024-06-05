namespace CQRSProject.CQRS.Queries
{
    public class GetCategoryByIdQuery
    {
        public int Id { get; set; }
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}