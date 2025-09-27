using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignUpApi.EFCore;
using SignUpApi.Model;

namespace SignUpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OperatorController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Operator>>> GetOprators()
        {
            return await _context.Operators.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Operator>> PostOperator(Operator op)
        {
            _context.Operators.Add(op);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOperator", new {id=op.Id},op);
        }

    }
}
