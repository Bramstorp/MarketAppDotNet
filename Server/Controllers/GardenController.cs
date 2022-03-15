using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MarketAppDotNet.Server.Data;
using MarketAppDotNet.Shared.Models;


namespace MarketAppDotNet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardenController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public GardenController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var devs = await _context.Gardens.ToListAsync();
            return Ok(devs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.Gardens.FirstOrDefaultAsync(a=>a.Id ==id);
            return Ok(dev);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Garden garden)
        {
            _context.Add(garden);
            await _context.SaveChangesAsync();
            return Ok(garden.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Garden garden)
        {
            _context.Entry(garden).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new Garden { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}