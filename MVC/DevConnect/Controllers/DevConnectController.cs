using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DevConnect.Controllers
{
   
    public class DevConnectController : Controller
    {
        private readonly db_devconnectContext _context;

        private readonly ILogger<DevConnectController> _logger;

        public DevConnectController(ILogger<DevConnectController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var db_devconnect = await _context.TbPostagems.ToListAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

    internal class db_devconnectContext_context
    {
    }
}