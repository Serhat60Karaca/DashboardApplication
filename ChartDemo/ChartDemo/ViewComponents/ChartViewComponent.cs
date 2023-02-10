using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChartDemo.ViewComponents
{
    public class ChartViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public ChartViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var salesData = await _context.Sales.ToListAsync();
            return View(salesData);
        }

    }
}