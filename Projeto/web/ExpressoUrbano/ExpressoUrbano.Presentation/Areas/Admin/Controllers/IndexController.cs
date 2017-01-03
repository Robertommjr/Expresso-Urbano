using System.Web.Mvc;
using AutoMapper;
using ExpressoUrbano.Presentation.Areas.Admin.ViewModels.Index;

namespace ExpressoUrbano.Presentation.Areas.Admin.Controllers
{
    public class IndexController : MapController
    {
        public IndexController()
        {
            AutomMapperConfig = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<DEMANDA, DemandaViewModel>();
                //cfg.CreateMap<DemandaViewModel, DEMANDA>();
            });
            Mapper = AutomMapperConfig.CreateMapper();
        }

        // GET: Admin/Index
        public override ActionResult Index()
        {
            var indexViewModel = new IndexViewModel();
            return View(indexViewModel);
        }
    }
}