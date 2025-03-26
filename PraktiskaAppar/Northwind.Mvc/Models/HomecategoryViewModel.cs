using Northwind.EntityModels;

//Ny model För att använda List av categories och products
namespace Northwind.Mvc.Models
{
    public class HomecategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public HomecategoryViewModel(List<Category> categories, List<Product> products)
        {
            Categories = categories;
            Products = products;
        }
    }
}
