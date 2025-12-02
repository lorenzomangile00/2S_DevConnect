
using Microsoft.AspNetCore.Mvc;
using CadastroAluno.Models;


namespace CadastroAluno.Controllers
{
    
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        private static List<Aluno> alunos = new List<Aluno>
        {
            new CadastroAluno.Models.Aluno{ NomeAluno = "Lorenzo", Idade = 17, Curso = "DEV", Turma = 1},
            new CadastroAluno.Models.Aluno{ NomeAluno = "Figueira", Idade = 18, Curso = "DEV", Turma = 2},
            new CadastroAluno.Models.Aluno{ NomeAluno = "LaHacker", Idade = 17, Curso = "Multimidia", Turma = 1},
            new CadastroAluno.Models.Aluno{ NomeAluno = "G.A", Idade = 16, Curso = "ADM", Turma = 2},
            new CadastroAluno.Models.Aluno{ NomeAluno = "Hugo", Idade = 18, Curso = "ADM", Turma = 1},
        };


        public IActionResult IndexAluno()
        {
            return View(alunos);
        }

        public IActionResult CreateAluno()
        {
            return View();
        }

        public IActionResult CadastrarAluno(Aluno aluno)
        {
            return View(aluno);
        }



        [HttpPost]

        public IActionResult CreateAluno(Aluno aluno)
        {
            aluno.NomeAluno = alunos.Max(a => a.NomeAluno) + 1;
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}