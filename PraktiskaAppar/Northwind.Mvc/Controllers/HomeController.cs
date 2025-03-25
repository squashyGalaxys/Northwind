using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels;
using Northwind.Mvc.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization; // f�r att anv�nda authorize attribute

namespace Northwind.Mvc.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindDatabaseContext db;

        public HomeController(ILogger<HomeController> logger, 
            NorthwindDatabaseContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new(
                
                VisitorCount: Random.Shared.Next(1, 1001),
                Categories: db.Categories.ToList(),
                Products: db.Products.ToList()

            );

            return View(model);
        }
        
        public IActionResult ProductDetail(int? id)
        {
            if(!id.HasValue)
            {
                return BadRequest("You must pass a product ID in the route, " +
                    "for example, /Home/ProductDetail/21");
            }
            Product? model = db.Products.SingleOrDefault(p => p.ProductId == id);
            if(model is null)
            {
                return NotFound($"ProductId{id} not found");
            }

            return View(model);
        }

        public IActionResult ModelBinding()
        {
            return View(); //sida med formul�r
        }
        [HttpPost]
        public IActionResult ModelBinding(Thing thing)
        {
            HomeModelBindningViewModel model= new(
                thing,
                HasErrors: !ModelState.IsValid,
                ValidationErrors: ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage)
            );
            
            return View(thing); //en sida som visar vad anv�ndaren skickade
            
        }
        [Authorize] //M�ste logga in f�r att se denna sida 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //F�r att kunna �ppna upp view f�r category
        public IActionResult Category(int id)
        {
            var category =db.Categories.SingleOrDefault(c => c.CategoryId == id);
            if (category is null) 
            {
                return NotFound($"Category with id {id} not found. Try again.");
            }
            var model = new HomecategoryViewModel
            {
                Categories = new List<Category> { category }
            };
            return View(model);

            
        }

    }
}
