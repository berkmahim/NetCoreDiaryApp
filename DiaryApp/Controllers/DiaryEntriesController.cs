using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}