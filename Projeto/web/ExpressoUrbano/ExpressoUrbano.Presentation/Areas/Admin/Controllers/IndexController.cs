using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Newtonsoft.Json;
using Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.Competencia;
using Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.Demanda;
using Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.Index;
using Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.InstituicaoSocial;
using Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.Periodicidade;
using Voluntariado.Infraestrutura.Entidades;
using Voluntariado.Servico.Servicos;

namespace Voluntariado.Apresentacao.MVC.Areas.Admin.Controllers
{
    public class IndexController : MapController
    {
        public IndexController()
        {
            AutomMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DEMANDA, DemandaViewModel>();
                cfg.CreateMap<DemandaViewModel, DEMANDA>();
                cfg.CreateMap<GerenciarDemandaViewModel, DEMANDA>();
                cfg.CreateMap<DEMANDA, GerenciarDemandaViewModel>();
                cfg.CreateMap<CadEdtDemandaViewModel, DEMANDA>();
                cfg.CreateMap<DEMANDA, CadEdtDemandaViewModel>();
                cfg.CreateMap<VisualizarDemandaViewModel, DEMANDA>();
                cfg.CreateMap<DEMANDA, VisualizarDemandaViewModel>();
                cfg.CreateMap<INSTITUICAO_SOCIAL, InstituicaoSocialViewModel>();
                cfg.CreateMap<InstituicaoSocialViewModel, INSTITUICAO_SOCIAL>();
                cfg.CreateMap<PERIODICIDADE, PeriodicidadeViewModel>();
                cfg.CreateMap<PeriodicidadeViewModel, PERIODICIDADE>();
                cfg.CreateMap<COMPETENCIA, CompetenciaViewModel>();
                cfg.CreateMap<CompetenciaViewModel, COMPETENCIA>();

            });
            Mapper = AutomMapperConfig.CreateMapper();
        }

        readonly DemandaService _demandaService = new DemandaService();

        // GET: Admin/Index
        public override ActionResult Index()
        {
            var inderViewModel = new IndexViewModel();
            var dados = new Dictionary<string, List<int>>();
            for (int i = 3; i >= 0; i--)
            {
                dados.Add(DateTime.Today.Month - i + "/" + DateTime.Today.Year, _demandaService.GraficoDemandaMes(DateTime.Today.Month - i, DateTime.Today.Year));
            }
            inderViewModel.Demandas = dados;
            return View(inderViewModel);
        }

        [HttpGet]
        public string Listar()
        {
            return JsonConvert.SerializeObject(_demandaService.ObterTodosLazyLoad());
        }
    }
}