using KASHOP.DAl.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KASHOP.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoresController : ControllerBase
    {private readonly ApplicationDbContext _context;
        public CategoresController(ApplicationDbContext context)
        {
            _context = context;
        }

       
    }
}
