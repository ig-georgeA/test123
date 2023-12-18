using ComponentDemosScenarios.Models.Financial;

namespace ComponentDemosScenarios.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }

        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }

        public Task<List<GlobalElectricityDemandType>> GetGlobalElectricityDemand()
        {
            return Task.FromResult<List<GlobalElectricityDemandType>>(new());
        }

        public Task<List<TradingType>> GetTrading()
        {
            return Task.FromResult<List<TradingType>>(new());
        }
    }
}
