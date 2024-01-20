
using DropdownCheck.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;

    public HomeController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var people = _dbContext.People.ToList();
        ViewBag.PeopleList = new SelectList(people, "Id", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult DisplayInfo(int personId)
    {
        var person = _dbContext.People.FirstOrDefault(p => p.Id == personId);
        return PartialView("_PersonInfoPartial", person);
    }
}
