
using Microsoft.AspNetCore.Mvc;
using CadastroAluno.Models;



namespace CadastroAluno
{
 
    public class Frutas : Controller
    {
        private readonly ILogger<Frutas> _logger;

        public Frutas(ILogger<Frutas> logger)
        {
            _logger = logger;
        }

        private List<Fruta> frutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Maca", Cor = "Vermelho", Categoria = "Tropical"},
            new Fruta{ Id = 2, Nome = "Banana", Cor = "Amarelo", Categoria = "Tropical"},
            new Fruta{ Id = 3, Nome = "Uva", Cor = "Roxa", Categoria = "Tropical"},
            new Fruta{ Id = 4, Nome = "Limao", Cor = "Verde", Categoria = "Citrica"},
            new Fruta{ Id = 5, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Citrica"},
        };

        public IActionResult Index()
        {
            return View(frutas);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Fruta fruta)
        {
            fruta.Id = frutas.Max(f => f.Id) + 1;
            frutas.Add(fruta);
            return RedirectToAction("Index");
        }
        public IActionResult FrutasTropicais()
        {
            return View(frutas);
        }

        public IActionResult FrutasCitricas()
        {
            return View(frutas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}