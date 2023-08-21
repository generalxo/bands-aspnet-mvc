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
		public IActionResult Member(int id)
		{
			List<BandMemberModel> bandMember = new();
			bandMember.Add(new BandMemberModel { BandId = 1, Name = "John Lennon" });
			bandMember.Add(new BandMemberModel { BandId = 1, Name = "Paul McCartney" });
			bandMember.Add(new BandMemberModel { BandId = 1, Name = "George Harrison" });
			bandMember.Add(new BandMemberModel { BandId = 1, Name = "Ringo Starr" });
			bandMember.Add(new BandMemberModel { BandId = 2, Name = "Mick Jagger" });
			bandMember.Add(new BandMemberModel { BandId = 2, Name = "Keith Richards" });
			bandMember.Add(new BandMemberModel { BandId = 2, Name = "Charlie Watts" });
			bandMember.Add(new BandMemberModel { BandId = 2, Name = "Ronnie Wood" });
			bandMember.Add(new BandMemberModel { BandId = 3, Name = "Roger Daltrey" });
			bandMember.Add(new BandMemberModel { BandId = 3, Name = "Pete Townshend" });
			bandMember.Add(new BandMemberModel { BandId = 3, Name = "John Entwistle" });


			List<BandMemberModel> meberList = new();
			foreach (var item in bandMember)
			{
				if (item.BandId == id)
				{
					meberList.Add(item);
				}
			}

			return View(meberList);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}