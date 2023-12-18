using System.Net.Http.Json;
using ComponentDemosScenarios.Models.NorthwindAPIv2;

namespace ComponentDemosScenarios.NorthwindAPIv2
{
    public class NorthwindAPIv2Service: INorthwindAPIv2Service
    {
        private readonly HttpClient _http;

        public NorthwindAPIv2Service(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CustomerDto>> GetCustomerDtoList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CustomerDto>>().ConfigureAwait(false);
            }

            return new List<CustomerDto>();
        }

        public async Task<CustomerDto> GetCustomerDto(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return new CustomerDto();
        }

        public async Task<List<OrderDto>> GetOrderDtoList(string id = "ALFKI")
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}/Orders", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrderDto>>().ConfigureAwait(false);
            }

            return new List<OrderDto>();
        }

        public async Task<List<ProductDto>> GetProductDtoList(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Orders/{id}/Products", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ProductDto>>().ConfigureAwait(false);
            }

            return new List<ProductDto>();
        }

        public async Task<List<OrderDetailDto>> GetOrderDetailDtoList(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Orders/{id}/Details", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrderDetailDto>>().ConfigureAwait(false);
            }

            return new List<OrderDetailDto>();
        }

        public async Task<List<EmployeeDto>> GetEmployeeDtoList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Employees", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeeDto>>().ConfigureAwait(false);
            }

            return new List<EmployeeDto>();
        }

        public async Task<CustomerDto> DeleteCustomerDto(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return new CustomerDto();
        }

        public async Task<CustomerDto> PostCustomerDto(object data)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            request.Content = new StringContent(@"{
  ""customerId"": ""string"",
  ""companyName"": ""string"",
  ""contactName"": ""string"",
  ""contactTitle"": ""string"",
  ""address"": {
    ""street"": ""string"",
    ""city"": ""string"",
    ""region"": ""string"",
    ""postalCode"": ""string"",
    ""country"": ""string"",
    ""phone"": ""string""
  }
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return new CustomerDto();
        }

        public async Task<CustomerDto> PutCustomerDto(object data)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            request.Content = new StringContent(@"{
  ""customerId"": ""string"",
  ""companyName"": ""string"",
  ""contactName"": ""string"",
  ""contactTitle"": ""string"",
  ""address"": {
    ""street"": ""string"",
    ""city"": ""string"",
    ""region"": ""string"",
    ""postalCode"": ""string"",
    ""country"": ""string"",
    ""phone"": ""string""
  }
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return new CustomerDto();
        }
    }
}
