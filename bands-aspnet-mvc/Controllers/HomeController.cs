using bands_aspnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bands_aspnet_mvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<BandModel> bands = new();
			bands.Add(new BandModel { BandId = 1, Name = "The Beatles" });
			bands.Add(new BandModel { BandId = 2, Name = "The Rolling Stones" });
			bands.Add(new BandModel { BandId = 3, Name = "The Who" });

			return View(bands);
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