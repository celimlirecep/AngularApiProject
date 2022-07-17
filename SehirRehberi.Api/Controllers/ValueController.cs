using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.Api.Concreate;
using SehirRehberi.Api.Model;

namespace SehirRehberi.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValueController : ControllerBase
    {
        private Context _context;

        public ValueController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var values = await _context.Values.FirstOrDefaultAsync(i=>i.Id==id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> GetValue(string name)
        {
            Value model = new Value();
            model.Name = name;
            var values = await _context.Values.AddAsync(model);
            _context.SaveChanges();
            return Ok(values);
        }

    }
}