using System.ComponentModel.DataAnnotations;

namespace bands_aspnet_mvc.Models.ViewModels
{
	public class CreateBandViewModel
	{
		[Required(ErrorMessage = "Band name is required")]
		[Display(Name = "Band Name")]
		public string? Name { get; set; }
	}
}
