using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DmiConsulting.Eshop.Core.Entities;
using DmiConsulting.Eshop.ViewModels;

namespace DmiConsulting.Eshop.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(p => p.Category, org => org.MapFrom(s => s.Category.Name));
            //CreateMap<IReadOnlyCollection<Product>, IReadOnlyCollection<ProductViewModel>>();

        }
    }
}
