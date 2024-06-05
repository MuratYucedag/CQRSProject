using CQRSProject.CQRS.Commands;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly Context _context;
        public RemoveCategoryCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }
    }
}
