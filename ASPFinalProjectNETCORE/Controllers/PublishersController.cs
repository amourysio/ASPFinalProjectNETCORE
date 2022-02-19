using ASPFinalProjectNETCORE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ASPFinalProjectNETCORE.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allPublishers = await _context.Publishers.ToListAsync();
            return View(allPublishers);
        }
    }
}
