using AdessoRideShare.Application.Cities.Dto;
using MediatR;
using System.Collections.Generic;

namespace AdessoRideShare.Application.Cities.GetCityList
{
    public class GetCityListQuery : IRequest<IEnumerable<CityDto>>
    {
    }
}
