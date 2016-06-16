using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ExpressoUrbano.Domain.Entities;
using ExpressoUrbano.Presentation.Models.TipoHorario;

namespace ExpressoUrbano.Presentation.Map
{
    public class ViewModelToDomainMapping : Profile
    {
        public override string ProfileName => "DomainToViewModelMapping";

        protected override void Configure()
        {
            Mapper.CreateMap<TipoHorarioViewModel, TipoHorario>();
        }
    }
}