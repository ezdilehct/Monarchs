using Microsoft.AspNetCore.Mvc;
using Monarchs.Api.Models;
using Monarchs.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Monarchs.Controllers
{
    public class MonarchsController : Controller
    {
        private readonly List<Monarch> _monarchs;

        public MonarchsController(List<Monarch> monarchs) 
            => _monarchs = monarchs;

        [HttpGet("/api/monarch/longest-ruller")]
        public MonarchReadModel GetLongestRuller()
        {
            var longestRuller = _monarchs.OrderByDescending(it => (it.RuledTill - it.RuledFrom)).First();
            return new MonarchReadModel(longestRuller);

        }

        [HttpGet("/api/monarchs/count")]
        public int GetCount() => _monarchs.Count();


        [HttpGet("/api/monarchs/fristnames/most-common")]
        public string Get() =>
            _monarchs.GroupBy(it => it.FirstName)
                .Select(it => new { it.Key, count = it.Count() })
                .OrderByDescending(it => it.count)
                .First()
                .Key;

    }
}
