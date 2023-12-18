using ComponentDemosScenarios.Models.NorthwindAPIv2;

namespace ComponentDemosScenarios.NorthwindAPIv2
{
    public class MockNorthwindAPIv2Service : INorthwindAPIv2Service
    {
        public Task<List<CustomerDto>> GetCustomerDtoList()
        {
            return Task.FromResult<List<CustomerDto>>(new());
        }

        public Task<CustomerDto> GetCustomerDto(string id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<List<OrderDto>> GetOrderDtoList(string id)
        {
            return Task.FromResult<List<OrderDto>>(new());
        }

        public Task<List<ProductDto>> GetProductDtoList(string id)
        {
            return Task.FromResult<List<ProductDto>>(new());
        }

        public Task<List<OrderDetailDto>> GetOrderDetailDtoList(string id)
        {
            return Task.FromResult<List<OrderDetailDto>>(new());
        }

        public Task<List<EmployeeDto>> GetEmployeeDtoList()
        {
            return Task.FromResult<List<EmployeeDto>>(new());
        }

        public Task<CustomerDto> DeleteCustomerDto(string id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> PostCustomerDto(object data)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> PutCustomerDto(object data)
        {
            return Task.FromResult<CustomerDto>(new());
        }
    }
}
