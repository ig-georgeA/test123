using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;
using ComponentDemosScenarios.NorthwindAPIv2;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestRoute_details
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbComboModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAvatarModule),
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule),
				typeof(IgbListModule));
			ctx.Services.AddScoped<INorthwindAPIv2Service>(sp => new MockNorthwindAPIv2Service());
			var componentUnderTest = ctx.RenderComponent<Route_details>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
