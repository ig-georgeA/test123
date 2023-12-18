using ComponentDemosScenarios.Models.Financial;

namespace ComponentDemosScenarios.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
        Task<List<SalesType>> GetSales();
        Task<List<GlobalElectricityDemandType>> GetGlobalElectricityDemand();
        Task<List<TradingType>> GetTrading();
    }
}
