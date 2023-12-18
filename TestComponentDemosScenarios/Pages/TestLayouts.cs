using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestLayouts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Layouts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
