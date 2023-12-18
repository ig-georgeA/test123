using ComponentDemosScenarios.Models.FinTech_API;

namespace ComponentDemosScenarios.FinTech_API
{
    public interface IFinTech_APIService
    {
        Task<Stock> GetStock(string symbol = "PLCE");
        Task<List<Stock>> GetStockList();
        Task<List<StockData>> GetStockDataList(string symbol = "UNH");
    }
}
