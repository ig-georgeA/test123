using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;
using ComponentDemosScenarios.FinTechAPI;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestFinancial_chart
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbFinancialChartModule));
			ctx.Services.AddScoped<IFinTechAPIService>(sp => new MockFinTechAPIService());
			var componentUnderTest = ctx.RenderComponent<Financial_chart>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
