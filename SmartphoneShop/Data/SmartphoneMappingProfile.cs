using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartphoneShop.Data.Entities;
using SmartphoneShop.ViewModels;

namespace SmartphoneShop.Data
{
    public class SmartphoneMappingProfile : Profile
    {
        public SmartphoneMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
              .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
              .ReverseMap();

            CreateMap<OrderItem, OrderItemViewModel>()
              .ReverseMap();
        }
    }
}
