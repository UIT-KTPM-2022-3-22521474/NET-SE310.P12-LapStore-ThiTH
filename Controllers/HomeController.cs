using LaptopStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Productstore.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context;
		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var Products = await _context.Products.ToListAsync();
			return View(Products);
		}
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var motorbike = await _context.Products
				.FirstOrDefaultAsync(m => m.ProductId == id);

			if (motorbike == null)
			{
				return NotFound();
			}

			return View(motorbike);
		}

		public IActionResult Privacy()
		{
			return View();
		}




		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
