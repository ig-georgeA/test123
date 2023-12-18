using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;
using ComponentDemosScenarios.NorthwindAPIv2;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestGrid_and_Tree_grid
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule),
				typeof(IgbTreeGridModule));
			ctx.Services.AddScoped<INorthwindAPIv2Service>(sp => new MockNorthwindAPIv2Service());
			var componentUnderTest = ctx.RenderComponent<Grid_and_Tree_grid>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
