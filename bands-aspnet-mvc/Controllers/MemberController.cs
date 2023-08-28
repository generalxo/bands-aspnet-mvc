using bands_aspnet_mvc.ActionFilter;
using bands_aspnet_mvc.Models;
using bands_aspnet_mvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bands_aspnet_mvc.Controllers
{
	public class MemberController : Controller
	{
		[MyLogFilter] // Can also be added to the class to add a filter on all Controller Actions.
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

			string? customMessage = HttpContext.Items["CustomeMsg"] as string;
			ViewBag.CustomMessage = customMessage;

			return View(meberList);
		}

		public IActionResult Create()
		{
			var model = new BandModel();
			var viewModel = new CreateBandViewModel
			{
				Name = model.Name
			};

			return View(viewModel);
		}

	}
}
