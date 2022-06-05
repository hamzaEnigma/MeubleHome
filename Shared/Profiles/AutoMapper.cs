using AutoMapper;
using Domain.Entities;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Profiles
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ProductProduct, ProductDTO>()
               .ReverseMap();
            CreateMap<IEnumerable<ProductProduct>, IEnumerable<ProductDTO>>()

    .ReverseMap();


        }

    }
}
