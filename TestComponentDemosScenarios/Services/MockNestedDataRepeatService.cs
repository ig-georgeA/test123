using ComponentDemosScenarios.Models.NestedDataRepeat;

namespace ComponentDemosScenarios.NestedDataRepeat
{
    public class MockNestedDataRepeatService : INestedDataRepeatService
    {
        public Task<NestedDataType> GetNestedData()
        {
            return Task.FromResult<NestedDataType>(new());
        }
    }
}
