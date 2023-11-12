using API.Core.DbModels;
using API.Dtos;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(x => x.ProductBrand, a => a.MapFrom(b => b.ProductBrand!.Name))
            .ForMember(x => x.ProductType, a => a.MapFrom(b => b.ProductType!.Name))
            .ForMember(x => x.PictureUrl, a => a.MapFrom<ProductUrlResolver>());
        }
    }
}
