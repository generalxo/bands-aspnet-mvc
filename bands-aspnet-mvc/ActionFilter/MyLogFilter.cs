using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace bands_aspnet_mvc.ActionFilter
{
	public class MyLogFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			string message = "Executing";
			context.HttpContext.Items["CustomeMsg"] = message;
			Debug.WriteLine("Executing");
		}
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			Debug.WriteLine("Done");
		}
	}
}
