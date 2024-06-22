using CQRSNight.CQRSDesingPattern.Commands.CategoryCommands;
using CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

        public CategoryController(GetCategoryQueryHandler getCategoryQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler = null, UpdateCategoryCommandHandler updateCategoryCommandHandler = null)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }
        public IActionResult CategoryList()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryCommand command)
        {
            _createCategoryCommandHandler.Handle(command);

            return RedirectToAction("CategoryList");
        }
        public IActionResult RemoveCategory(int id)
        {
            _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return RedirectToAction("CategoryList");
        }

    }
}
