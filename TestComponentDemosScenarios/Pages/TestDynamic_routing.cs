using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;
using ComponentDemosScenarios.NorthwindAPIv2;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestDynamic_routing
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindAPIv2Service>(sp => new MockNorthwindAPIv2Service());
			var componentUnderTest = ctx.RenderComponent<Dynamic_routing>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
