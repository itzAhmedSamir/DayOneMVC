using Day_1.DAL.DB;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public IActionResult Index()
        {
            var result = Db.Employees.ToList();
            return View(result);
        }
    }
}
