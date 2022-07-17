using Acc.Services.ProductAPI.Models.Dto;
using Acc.Services.ProductAPI.Models.Dtos;
using AutoMapper;

namespace Acc.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
