
using ApiTienTe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiTienTe.Controllers
    
{
    [Route("api/[controller]")]
    [ApiController]
    public class TienTeController : Controller
        
    {
        private readonly TienTeDataContext _context;
        public TienTeController(TienTeDataContext context) {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll() {
        return Ok(_context.TienTes.ToList());
                }
    }
}
