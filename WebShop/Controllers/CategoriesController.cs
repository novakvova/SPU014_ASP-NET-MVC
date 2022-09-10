using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebShop.Data;
using WebShop.Data.Entities;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly MyAppContext _appContext;
        public CategoriesController(MyAppContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            var list = _appContext.Categories.Select(x => new CategoryItemViewModel
            {
                Name = x.Name,
                Id = x.Id
            }).ToList();

            return View(list);
        }
        //Показуємо сторіннку стоврення категорії
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Зберігаємо категорію в БД
        [HttpPost]
        public IActionResult Create(CategoryCreateViewModel model)
        {
            CategoryEntity entity = new CategoryEntity()
            {
                Name = model.Name
            };
            _appContext.Categories.Add(entity);
            _appContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
