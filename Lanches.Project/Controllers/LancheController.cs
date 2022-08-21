using Lanches.Project.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Project.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lanchesRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lanchesRepository = lancheRepository;
        }
        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lanchesRepository.Lanches;

            var totalLanches = lanches.Count();
            ViewBag.Total = "Total de lanches:";
            ViewBag.TotalLanches = totalLanches;


            return View(lanches);
        }
    }
}
