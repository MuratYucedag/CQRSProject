using CQRSProject.CQRS.Queries;
using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly Context _context;
        public GetCategoryByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
