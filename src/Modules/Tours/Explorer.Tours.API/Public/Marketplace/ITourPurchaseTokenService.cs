﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Tours.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Public.Marketplace
{
    public interface ITourPurchaseTokenService
    {
        Result<List<TourDTO>> GetPurchasedTours(int touristId);
        //ovo da bude metoda koja prima listu id-eva koje dobijas onom metodom
        //na ovo se toda ( u parametrima List<...> ids) sto je povratna vrednost onoga
        //sto smo radili


        //dodato zbog recenzija
        Result<PagedResult<TourPurchaseTokenDto>> GetPaged(int page, int pageSize);
        Result<PagedResult<TourPurchaseTokenDto>> GetByUserId(int userId, int page, int pageSize);
        
    }
}
