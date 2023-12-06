﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Explorer.Payments.API.Dtos.ShoppingCartDtos;
using Explorer.Payments.Core.Domain.ShoppingCarts;

namespace Explorer.Payments.Core.Mappers
{
    public class PaymentsProfile : Profile
    {
        public PaymentsProfile() {

            CreateMap<ShoppingCartDto, ShoppingCart>().ReverseMap();   //ShoppingCart
            CreateMap<OrderItemDto, OrderItem>().ReverseMap();
            CreateMap<TourPurchaseTokenDto, TourPurchaseToken>().ReverseMap();
            CreateMap<WalletDto, Wallet>().ReverseMap();

        }
        
    }
}
