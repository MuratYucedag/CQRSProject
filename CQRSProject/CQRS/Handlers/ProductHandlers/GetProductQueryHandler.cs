using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;
        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductName = x.ProductName,
                ProductId = x.ProductId,
                ProductPrice = x.ProductPrice
            });
            return values.ToList();
        }
    }
}
