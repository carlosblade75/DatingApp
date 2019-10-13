using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase 
{ 
    private readonly DataContext _context;
    public ValuesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetValues()
    {
        var values =await _context.Values.ToListAsync();

        return Ok(values);
    }

    //Cualquiera puede entrar, no hace falta token
    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetValues(int id)
    {
        var values = await _context.Values.Where( x => x.Id == id).FirstOrDefaultAsync();

        return Ok(values);
    }
}