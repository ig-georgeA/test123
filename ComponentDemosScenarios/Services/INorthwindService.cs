using ComponentDemosScenarios.Models.Northwind;

namespace ComponentDemosScenarios.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
        Task<List<EmployeesType>> GetEmployees();
    }
}
