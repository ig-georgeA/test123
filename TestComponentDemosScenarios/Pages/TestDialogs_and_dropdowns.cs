using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestDialogs_and_dropdowns
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownHeaderModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbIconButtonModule),
				typeof(IgbInputModule),
				typeof(IgbSnackbarModule));
			var componentUnderTest = ctx.RenderComponent<Dialogs_and_dropdowns>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
