using CQRSProject.CQRS.Commands;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly Context _context;
        public CreateCategoryCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            _context.SaveChanges();
        }
    }
}
