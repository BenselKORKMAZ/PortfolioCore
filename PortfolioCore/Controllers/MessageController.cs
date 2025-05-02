using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
	public class MessageController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult MessageList()
		{
			var values = context.Messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		public IActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
			return View(value);
		}
	}
}