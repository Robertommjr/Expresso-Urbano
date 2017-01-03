using System.Web.Mvc;
using AutoMapper;

namespace ExpressoUrbano.Presentation.Areas.User.Controllers
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