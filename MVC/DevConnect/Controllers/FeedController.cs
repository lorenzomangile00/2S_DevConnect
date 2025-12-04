
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevConnect.Controllers
{
   
    public class FeedController : Controller
    {
        private readonly db_devconnectContext _context;
        
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}