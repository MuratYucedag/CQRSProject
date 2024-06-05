using CQRSProject.CQRS.Commands;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly Context _context;
        public UpdateCategoryCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateCategoryCommand command)
        {
            var value = _context.Categories.Find(command.CategoryId);
            value.CategoryName=command.CategoryName;
            _context.SaveChanges();
        }
    }
}
