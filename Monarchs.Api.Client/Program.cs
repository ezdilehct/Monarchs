using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Monarchs.Api.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var baseUrl = "http://localhost:5000";
            var httpClient = new HttpClient();
            var getlongestRullerResponse = await httpClient.GetAsync($"{baseUrl}/api/monarch/longest-ruller");
            var longestRuller = JObject.Parse(await getlongestRullerResponse.Content.ReadAsStringAsync().ConfigureAwait(false));

            var getMonarchsCountResponse = await httpClient.GetAsync($"{baseUrl}/api/monarchs/count");
            var monarchsCount = int.Parse(await getMonarchsCountResponse.Content.ReadAsStringAsync().ConfigureAwait(false));

            var getMostCommonNameResponse = await httpClient.GetAsync($"{baseUrl}/api/monarchs/fristnames/most-common");
            var mostCommonName = await getMostCommonNameResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            var getLongestRullerHouseResponse = await httpClient.GetAsync($"{baseUrl}/api/houses/longest-ruller");
            var longestRullerHouse = JObject.Parse(await getLongestRullerHouseResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
    }
}
