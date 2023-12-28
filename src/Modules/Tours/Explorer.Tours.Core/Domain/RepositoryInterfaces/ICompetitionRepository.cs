﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Tours.Core.Domain.Competitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Core.Domain.RepositoryInterfaces
{
	public interface ICompetitionRepository
	{
		PagedResult<Competition> GetAll(int page, int pageSize);
	}
}
