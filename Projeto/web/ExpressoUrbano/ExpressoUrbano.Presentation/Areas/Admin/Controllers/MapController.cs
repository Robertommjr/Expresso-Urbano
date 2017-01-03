﻿
using System.IO;
using System.Web.Mvc;
using AutoMapper;


namespace Voluntariado.Apresentacao.MVC.Areas.Admin.Controllers
{
    public class MapController : Controller
    {
        public MapperConfiguration AutomMapperConfig { get; set; }
        public IMapper Mapper { get; set; }

        public virtual ActionResult Index()
        {
            return RedirectToAction("Gerenciar");
        }

        public byte[] Upload(string filefield = "file", bool edicao = false)
            {
            var myFile = Request.Files[filefield];
            byte[] fileData = null;
            if (myFile != null && myFile.ContentLength != 0)
            {
                using (var binaryReader = new BinaryReader(myFile.InputStream))
                {
                    fileData = binaryReader.ReadBytes(myFile.ContentLength);
                }
            }
            else if (!edicao)
            {
                fileData = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/img/img_padrao.jpg"));
            }
            return fileData;
        }
    }


}