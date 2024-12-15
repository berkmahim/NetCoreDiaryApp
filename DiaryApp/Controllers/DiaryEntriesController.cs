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

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(DiaryEntry entry)
    {
        if (entry != null && entry.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 characters long");
        }

        if (ModelState.IsValid)
        {
            DiaryEntry newEntry = new DiaryEntry();
            newEntry.Title = entry.Title.Trim();
            newEntry.Content = entry.Content.Trim();
            newEntry.Created = entry.Created;
        
            _context.DiaryEntries.Add(newEntry);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(entry);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        Console.WriteLine(id);
        DiaryEntry entryToDelete = _context.DiaryEntries.Find(id);
        _context.DiaryEntries.Remove(entryToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        DiaryEntry? entry = _context.DiaryEntries.Find(id);
        if (entry == null)
        {
            return NotFound();
        }
        return View(entry);
    }
    
    [HttpPost]
    public IActionResult Edit(DiaryEntry entry)
    {
        if (entry != null && entry.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 characters long");
        }

        if (entry.Title.Trim().Length>3)
        {

            _context.DiaryEntries.Update(entry);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(entry);
    }
}