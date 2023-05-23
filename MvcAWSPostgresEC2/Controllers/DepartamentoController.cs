using Microsoft.AspNetCore.Mvc;
using MvcAWSPostgresEC2.Models;
using MvcAWSPostgresEC2.Repositories;

namespace MvcAWSPostgresEC2.Controllers
{
    public class DepartamentoController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentoController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }

        public async Task<IActionResult> Details(int id)
        {
            Departamento departamento = await this.repo.FindDepartamentoAsync(id);
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento departamento)
        {
            await this.repo.InsertDepartamento(departamento.IdDepartamento, departamento.Nombre, departamento.Localidad);
            return RedirectToAction("Index");
        }
    }
}
