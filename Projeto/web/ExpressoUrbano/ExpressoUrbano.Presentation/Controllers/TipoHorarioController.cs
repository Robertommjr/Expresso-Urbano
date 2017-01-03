using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ExpressoUrbano.Domain.Entities;
using ExpressoUrbano.Presentation.Models.TipoHorario;
using ExpressoUrbano.Service.Services;

namespace ExpressoUrbano.Presentation.Controllers
{
    public class TipoHorarioController : Controller
    {
        private readonly TipoHorarioService _tipoHorarioService = new TipoHorarioService();

        [HttpGet]
        public ActionResult Gerenciar()
        {
            var tipoHorarioVM = new TipoHorarioViewModel();

            tipoHorarioVM.Horarios =
                Mapper.Map<IList<TipoHorario>, ICollection<TipoHorarioViewModel>>(_tipoHorarioService.ObterTodos());

            return View(tipoHorarioVM);
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
                var tipoHorario = Mapper.Map<TipoHorarioViewModel, TipoHorario>(tipoHorarioViewModel);

                _tipoHorarioService.Salvar(tipoHorario);
                TempData["Message"] = new[] {Resources.cadastrar_sucesso, "sucesso"};

                return RedirectToAction("Gerenciar", "TipoHorario");
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