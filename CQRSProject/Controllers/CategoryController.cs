using CQRSProject.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        public CategoryController(GetCategoryQueryHandler getCategoryQueryHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
        }
        public IActionResult CategoryList()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}