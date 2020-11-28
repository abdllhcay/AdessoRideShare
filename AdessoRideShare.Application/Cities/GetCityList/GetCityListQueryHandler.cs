using AdessoRideShare.Application.Cities.Dto;
using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Cities.GetCityList
{
    public class GetCityListQueryHandler : IRequestHandler<GetCityListQuery, IEnumerable<CityDto>>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public GetCityListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CityDto>> Handle(GetCityListQuery request, CancellationToken cancellationToken)
        {
            var cities = await context.Cities.ToListAsync();

            return mapper.Map<List<City>, List<CityDto>>(cities);
        }
    }
}
