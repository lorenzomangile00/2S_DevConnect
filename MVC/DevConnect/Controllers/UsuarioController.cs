
using Microsoft.AspNetCore.Mvc;
using DevConnect.Models;
using DevConnect.Contexts;
using System.Threading.Tasks;


namespace DevConnect.Controllers
{
   
    public class UsuarioController : Controller
    {

        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastro = "";
            TempData["UsuarioCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            // System.Console.WriteLine($"{form["NomeCompleto"]}");
            // System.Console.WriteLine($"{form.Files[0].FileName}");

            TbUsuario novoUsuario = new TbUsuario
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
            

            if (Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            var path = Path.Combine(folder, file.FileName);

             using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            novoUsuario.FotoPerfilUrl = file.FileName;
            }
            else
            {   
            novoUsuario.FotoPerfilUrl = "";
            }
            
            try
            {
                _context.Add(novoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastro"] = "Cadastrado!";
                ViewBag.UsuarioNovoCadastro = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastro = "Nao cadastrado";
                TempData["UsuarioCadastrado"] = "";
                return View();
            }


            
        }
        

        public IActionResult Perfil()
        {
            return View();
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}