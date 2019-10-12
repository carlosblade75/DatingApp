using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Values;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase { 

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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetValues(int id)
    {
        var values = await _context.Values.Where( x => x.Id == id).FirstOrDefaultAsync();

        return Ok(values);
    }
}