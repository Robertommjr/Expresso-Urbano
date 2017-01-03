using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluntariado.Apresentacao.MVC.Areas.Admin.ViewModels.Index
{
    public class IndexViewModel
    {
        public Dictionary<string, List<int>> Demandas { get; set; }
    }
}