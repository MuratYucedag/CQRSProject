using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly Context _context;
        public GetCategoryQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
            return values;
        }
    }
}
