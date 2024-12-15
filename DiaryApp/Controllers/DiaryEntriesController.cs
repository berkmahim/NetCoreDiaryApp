using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    
    private readonly ApplicationDbContext _context;

    public DiaryEntriesController(ApplicationDbContext context)
    {
        _context = context;   
    }
    
    // GET
    public IActionResult Index()
    {
        List<DiaryEntry> entries = _context.DiaryEntries.ToList();
        return View(entries);
    }
}