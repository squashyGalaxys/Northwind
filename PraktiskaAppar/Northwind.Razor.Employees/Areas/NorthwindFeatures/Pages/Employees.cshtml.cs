using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Northwind.Razor.Employees.MyFeature.Pages
{
    public class EmployeesModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Northwind App - Employees";
            //TODO: Implementera kod för att hämta 
            //employees från databasen, sortera med LastName sen FirstName
        }
    }
}
