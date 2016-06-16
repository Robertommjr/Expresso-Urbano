using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ExpressoUrbano.Presentation.Map
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(m =>
            {
                m.AddProfile<DomainToViewModelMapping>();
                m.AddProfile<ViewModelToDomainMapping>();
            });
        }
    }
}