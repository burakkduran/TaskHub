using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskHub.Models;
using TaskHub.ViewModels;
using System.Threading.Tasks;
using System.Linq;

public class LessonsController : Controller
{
    private readonly AppDbContext _context;

    public LessonsController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var lessons = await _context.Lessons
            .Select(l => new LessonViewModel
            {
                Id = l.Id,
                Title = l.Title
            })
            .ToListAsync();

        return View(lessons);
    }
}