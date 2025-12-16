
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using DevConnect.Contexts;
using Microsoft.EntityFrameworkCore;
using DevConnect.Models;


namespace DevConnect.Controllers
{

    public class FeedController : Controller
    {
        private readonly DevConnectContext _context;

        private readonly ILogger<FeedController> _logger;



        public FeedController(ILogger<FeedController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // List<TbPostagem> publicacoes = await _context.TbPostagem.ToListAsync();
            // var publicacoes = await _context.TbPostagem.
            try
            {
            List<TbPostagem> publicacoes = await _context.TbPostagem
            .Include(p => p.IdUsuarioNavigation)
            .ToListAsync();
            return View(publicacoes);         
             }
            catch (System.Exception)
            {

                throw;
            }
            

            // ViewBag.PublicacaoNovaCadastro = "";
            
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbPostagem novaPublicacao = new TbPostagem
            {
                Descricao = form["Descricao"].ToString(),
                DataPostagem = DateOnly.FromDateTime(DateTime.Now)
            };

            if (form.Files.Count > 0)
            {

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/publicacoes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novaPublicacao.ImagemUrl = file.FileName;
            }

            try
            {

                _context.Add(novaPublicacao);
                await _context.SaveChangesAsync();


                ViewBag.PublicacaoNovaCadastro = "Cadastrado";
                return RedirectToAction("Index", "Feed");
            }
            catch (System.Exception)
            {
                ViewBag.PublicacaoNovaCadastro = "Nao cadastrado";
                return View();

            }


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View("Error!");
        }
    }

}


