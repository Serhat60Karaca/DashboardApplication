using ChartDemo.Models;
using Microsoft.AspNetCore.Mvc;
namespace ChartDemo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Deneme()
        {
            var salesdata = _context.Sales.ToList();
            return View(salesdata);
        }
        public IActionResult Index()
        {
            var salesdata = _context.Sales.ToList();
            return View(salesdata);
        }
        [HttpGet]
        public IActionResult AddSales()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSales(Sales sale)
        {
            sale.CreatedDate = DateTime.Now;
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return View();
        }
        public IActionResult Lists()
        {
            var salesdata = _context.Sales.ToList();
            return View(salesdata);
        }
        public IActionResult Delete(int id)
        {
            var sale = _context.Sales.FirstOrDefault(i => i.Id == id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                _context.SaveChanges();
            }
            return View();
        }
        public PartialViewResult ChartPartialView()
        {
            ;
            return PartialView("ChartPartialView", _context.Sales.ToList());
        }
    }
}
