using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ComponentDemosScenarios;
using ComponentDemosScenarios.FinTech_API;
using ComponentDemosScenarios.NorthwindAPIv2;
using ComponentDemosScenarios.Northwind;
using ComponentDemosScenarios.Financial;
using ComponentDemosScenarios.NestedDataRepeat;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFinTech_APIService, FinTech_APIService>();
builder.Services.AddScoped<INorthwindAPIv2Service, NorthwindAPIv2Service>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INestedDataRepeatService, NestedDataRepeatService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbFinancialChartModule),
        typeof(IgbGridModule),
        typeof(IgbComboModule),
        typeof(IgbButtonModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbChipModule),
        typeof(IgbActionStripModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbCalendarModule),
        typeof(IgbInputModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbTreeModule),
        typeof(IgbCheckboxModule),
        typeof(IgbAccordionModule),
        typeof(IgbStepperModule),
        typeof(IgbTreeGridModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbPieChartModule),
        typeof(IgbDatePickerModule),
        typeof(IgbSliderModule),
        typeof(IgbRangeSliderModule),
        typeof(IgbRatingModule),
        typeof(IgbBadgeModule),
        typeof(IgbSwitchModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbSelectModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownHeaderModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbSnackbarModule)
    );
}