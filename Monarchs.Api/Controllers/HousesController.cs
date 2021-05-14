using Microsoft.AspNetCore.Mvc;
using Monarchs.Api.Models;
using Monarchs.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Monarchs.Api.Controllers
{
    public class HousesController : Controller
    {
        private readonly List<Monarch> _monarchs;

        public HousesController(List<Monarch> monarchs) 
            => _monarchs = monarchs;

        [HttpGet("/api/houses/longest-ruller")]
        public HouseReadModel GetLongestRullerHouse()
        {
            var longestRullerHouseId = 
                _monarchs
                        .GroupBy(it => it.HouseId)
                        .Select(it => new { houseId = it.Key, ruledFor = it.Sum(g => g.RuledTill - g.RuledFrom) })
                        .OrderByDescending(it => it.ruledFor)
                        .First()
                        .houseId;

            return new HouseReadModel(_monarchs.First(it => it.HouseId == longestRullerHouseId).House);
        }
    }
}