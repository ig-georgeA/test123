using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios.Pages;

namespace TestComponentDemosScenarios
{
	[Collection("ComponentDemosScenarios")]
	public class TestInputs
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbDatePickerModule),
				typeof(IgbChipModule),
				typeof(IgbAvatarModule),
				typeof(IgbSliderModule),
				typeof(IgbRangeSliderModule),
				typeof(IgbRatingModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbBadgeModule),
				typeof(IgbSwitchModule),
				typeof(IgbCheckboxModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule));
			var componentUnderTest = ctx.RenderComponent<Inputs>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
