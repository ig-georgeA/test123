using ComponentDemosScenarios.Models.NorthwindAPIv2;

namespace ComponentDemosScenarios.NorthwindAPIv2
{
    public interface INorthwindAPIv2Service
    {
        Task<List<CustomerDto>> GetCustomerDtoList();
        Task<CustomerDto> GetCustomerDto(string id);
        Task<List<OrderDto>> GetOrderDtoList(string id = "ALFKI");
        Task<List<ProductDto>> GetProductDtoList(string id);
        Task<List<OrderDetailDto>> GetOrderDetailDtoList(string id);
        Task<List<EmployeeDto>> GetEmployeeDtoList();
        Task<CustomerDto> DeleteCustomerDto(string id);
        Task<CustomerDto> PostCustomerDto(object data);
        Task<CustomerDto> PutCustomerDto(object data);
    }
}
