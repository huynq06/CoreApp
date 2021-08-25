using AutoMapper;
using CoreApp.Application.ViewModels.Products;
using CoreApp.Application.ViewModels.System;
using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}
