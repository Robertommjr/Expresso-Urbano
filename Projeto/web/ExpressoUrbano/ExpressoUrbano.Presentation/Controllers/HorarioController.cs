using System.Web.Mvc;
using ExpressoUrbano.Presentation.Models.Horario;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class HorarioController : Controller
    {
        [HttpGet]
        public ActionResult Gerenciar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(HorarioViewModel horarioViewModel)
        {
            if (ModelState.IsValid)
            {
            }

            return View(horarioViewModel);
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return PartialView("PartialGrid");
        }

        [HttpPost]
        public ActionResult Pesquisar(HorarioViewModel horarioViewModel)
        {
            if (ModelState.IsValid)
            {
            }

            return PartialView("PartialGrid");
        }

        [HttpGet]
        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(HorarioViewModel horarioViewModel)
        {
            if (ModelState.IsValid)
            {
            }

            return View(horarioViewModel);
        }
    }
}