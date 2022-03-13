using AutoMapper;
using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
              //  config.CreateMap<ProductDto, Product>().ReverseMap(); // can be done using reverseMap
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
