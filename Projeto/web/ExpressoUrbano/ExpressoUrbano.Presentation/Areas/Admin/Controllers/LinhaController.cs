using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ExpressoUrbano.Domain.Entities;
using ExpressoUrbano.Domain.Enums;
using ExpressoUrbano.Presentation.Areas.Admin.ViewModels.Linha;
using ExpressoUrbano.Service.Services;
using Newtonsoft.Json;

namespace ExpressoUrbano.Presentation.Areas.Admin.Controllers
{
    public class LinhaController : MapController
    {
        public LinhaController()
        {
            AutomMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Linha, LinhaViewModel>();
                cfg.CreateMap<LinhaViewModel, Linha>();
            });
            Mapper = AutomMapperConfig.CreateMapper();
        }

        readonly LinhaService _linhaService = new LinhaService();

        [HttpGet]
        public ActionResult Gerenciar()
        {
            var linhaViewModel = new LinhaViewModel();
            return View(linhaViewModel);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var linhaViewModel = new LinhaViewModel();

            return View(linhaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Cadastrar(LinhaViewModel linhaViewModel)
        {
            if (ModelState.IsValid)
            {
                var linha = Mapper.Map<LinhaViewModel, Linha>(linhaViewModel);
                
                _linhaService.Salvar(linha);

                TempData["Message"] = new[] { Resources.cadastrar_sucesso, "sucesso" };

                return RedirectToAction("Gerenciar", "Linha");
            }
            return View(linhaViewModel);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var linha = _linhaService.ObterPorId(id);
            var linhaViewModel = Mapper.Map<Linha, LinhaViewModel>(linha);

            return View(linhaViewModel);
        }

        //POST do Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Editar(LinhaViewModel linhaViewModel)
        {
            if (ModelState.IsValid)
            {
                var linha = Mapper.Map<LinhaViewModel, Linha>(linhaViewModel);

                _linhaService.Atualiza(linha);

                TempData["Message"] = new[] {Resources.editar_sucesso, "sucesso"};
                return RedirectToAction("Gerenciar", "Linha");
            }
            return View(linhaViewModel);
        }

        [HttpPost]
        public ActionResult Desativar(int id)
        {
            var msg = string.Empty;
            var tipo = string.Empty;
            var linha = _linhaService.ObterPorId(id);

            linha.Status = false;
            _linhaService.Atualiza(linha);
            msg = Resources.desativar_sucesso;
            tipo = "sucesso";

            if (Request.IsAjaxRequest())
            {
                return Json(new
                {
                    status = true,
                    url = Url.Action("Gerenciar"),
                    MsgSucesso = msg,
                    tipoMsg = tipo
                });
            }
            msg = Resources.desativar_erro;
            tipo = "erro";
            return RedirectToAction("Gerenciar", "Linha");
        }

        public ActionResult Visualizar(int id)
        {
            var linha = _linhaService.ObterPorId(id);
            var linhaViewModel = Mapper.Map<Linha, LinhaViewModel>(linha);
            
            return View(linhaViewModel);
        }

        [HttpGet]
        public string Listar()
        {
            var linhas = Mapper.Map<ICollection<Linha>, ICollection<LinhaViewModel>>(_linhaService.ObterTodos());

            return JsonConvert.SerializeObject(linhas);
        }
    }
}