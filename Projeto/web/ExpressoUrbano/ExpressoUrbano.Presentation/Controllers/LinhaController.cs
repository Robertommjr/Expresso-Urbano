using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpressoUrbano.Presentation.Models.Linha;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class LinhaController : Controller
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
        public ActionResult Cadastrar(LinhaViewModel linhaViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(linhaViewModel);
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return PartialView("PartialGrid");
        }

        [HttpPost]
        public ActionResult Pesquisar(LinhaViewModel linhaViewModel)
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
        public ActionResult Editar(LinhaViewModel linhaViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(linhaViewModel);
        }

    }
}