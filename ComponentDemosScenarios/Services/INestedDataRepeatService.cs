using ComponentDemosScenarios.Models.NestedDataRepeat;

namespace ComponentDemosScenarios.NestedDataRepeat
{
    public interface INestedDataRepeatService
    {
        Task<NestedDataType> GetNestedData();
    }
}
