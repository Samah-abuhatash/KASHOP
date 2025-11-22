using KASHOP.DAl.Data;
using KASHOP.DAl.DTOS.Request;
using KASHOP.DAl.DTOS.Response;
using KASHOP.DAl.Moadels;
using KASHOP.PLL;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace KASHOP.PLL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoresController : ControllerBase
    { private readonly ApplicationDbContext _context;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public CategoresController(ApplicationDbContext context, IStringLocalizer<SharedResource> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var categories = _context.Catgores.Include(c=>c.translations).ToList();
            var response = categories.Adapt<List<Responsecategory>>();

            // ترجع رسالة "Success" مترجمة
            return Ok(new
            {
                message = _localizer["Success"].Value,
                response

            });

        }
    
    [HttpPost("")]
        public IActionResult Create( CategoryRequest request)
        {
            var categories = request.Adapt<Categores>();
            _context.Add(categories);
              _context.SaveChanges();

            return Ok(new { message = _localizer["Success"].Value});
        }
    }
}