using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpressoUrbano.Presentation.Models.Rota;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class RotaController : Controller
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
        public ActionResult Cadastrar(RotaViewModel rotaViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(rotaViewModel);
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return PartialView("PartialGrid");
        }

        [HttpPost]
        public ActionResult Pesquisar(RotaViewModel rotaViewModel)
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
        public ActionResult Editar(RotaViewModel rotaViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(rotaViewModel);
        }

    }
}