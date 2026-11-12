using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LocationVoitures.Web.Models;
using LocationVoitures.Web.Repositories;

namespace LocationVoitures.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVoitureRepository _voitureRepository;

        public HomeController(ILogger<HomeController> logger, IVoitureRepository voitureRepository)
        {
            _logger = logger;
            _voitureRepository = voitureRepository;
        }

        public IActionResult Index()
        {
            var voitures = _voitureRepository.GetAll();
            return View(voitures);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}