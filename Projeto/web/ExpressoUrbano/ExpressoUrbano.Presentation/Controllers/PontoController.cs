using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpressoUrbano.Presentation.Models.Ponto;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class PontoController : Controller
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
        public ActionResult Cadastrar(PontoViewModel pontoViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(pontoViewModel);
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return PartialView("PartialGrid");
        }

        [HttpPost]
        public ActionResult Pesquisar(PontoViewModel pontoViewModel)
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
        public ActionResult Editar(PontoViewModel pontoViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(pontoViewModel);
        }

    }
}