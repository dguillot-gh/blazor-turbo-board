using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurboKanban.Data;
namespace TurboKanban.Controllers;
[Route("parts")]
[ApiController]
public class PartsController : Controller
{
    private readonly PartsContext _db;

    public PartsController(PartsContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Parts>>> GetParts()
    {
        return (await _db.Parts.ToListAsync()).OrderByDescending(s => s.IsAccquired).ToList();
    }
}
