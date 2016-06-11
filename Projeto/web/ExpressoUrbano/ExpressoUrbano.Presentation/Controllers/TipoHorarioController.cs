using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpressoUrbano.Presentation.Models.TipoHorario;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class TipoHorarioController : Controller
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
        public ActionResult Cadastrar(TipoHorarioViewModel tipoHorarioViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(tipoHorarioViewModel);
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return PartialView("PartialGrid");
        }

        [HttpPost]
        public ActionResult Pesquisar(TipoHorarioViewModel tipoHorarioViewModel)
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
        public ActionResult Editar(TipoHorarioViewModel tipoHorarioViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(tipoHorarioViewModel);
        }

    }
}