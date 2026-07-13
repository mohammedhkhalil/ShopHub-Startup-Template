using AutoMapper;
using BLL.DTOs;
using DAL.Models;

namespace BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                .ReverseMap();
            CreateMap<OrderHeader, OrderHeaderDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();

            CreateMap<ShoppingCart, ShoppingCartDTO>()
                .ReverseMap();

        }

        
    }
}