using System.Web.Mvc;
using AutoMapper;

namespace ExpressoUrbano.Presentation.Areas.Admin.Controllers
{
    public class MapController : Controller
    {
        public MapperConfiguration AutomMapperConfig { get; set; }
        public IMapper Mapper { get; set; }

        public virtual ActionResult Index()
        {
            return RedirectToAction("Gerenciar");
        }
    }
}