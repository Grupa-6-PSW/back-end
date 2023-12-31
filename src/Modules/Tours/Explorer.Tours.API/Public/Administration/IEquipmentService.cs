﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Tours.API.Dtos;
using FluentResults;
using System.Collections.ObjectModel;

namespace Explorer.Tours.API.Public.Administration;

public interface IEquipmentService
{
    Result<PagedResult<EquipmentDto>> GetPaged(int page, int pageSize);
    Result<EquipmentDto> Create(EquipmentDto equipment);
    Result<EquipmentDto> Update(EquipmentDto equipment);
    Result Delete(int id);
    Result<ObservableCollection<EquipmentDto>> GetTouristEquipment(List<int> ids);
    Result<ObservableCollection<EquipmentDto>> GetOtherEquipment(List<int> ids);
}