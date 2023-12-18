using System.Net.Http.Json;
using ComponentDemosScenarios.Models.NestedDataRepeat;

namespace ComponentDemosScenarios.NestedDataRepeat
{
    public class NestedDataRepeatService: INestedDataRepeatService
    {
        private readonly HttpClient _http;

        public NestedDataRepeatService(HttpClient http)
        {
            _http = http;
        }

        public async Task<NestedDataType> GetNestedData()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://raw.githubusercontent.com/zdrawku/data/master/IGDSC-Library.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<NestedDataType>().ConfigureAwait(false);
            }

            return new NestedDataType();
        }
    }
}
