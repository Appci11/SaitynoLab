global using Microsoft.AspNetCore.Components.Authorization;
global using SaitynoLab.Client.Services.UsersService;
global using SaitynoLab.Shared;
using Blazored.LocalStorage;
using Blazored.Modal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SaitynoLab.Client;
using SaitynoLab.Client.Policies;
using SaitynoLab.Client.Services.FurnitureService;
using SaitynoLab.Client.Services.OrdersService;
using SaitynoLab.Client.Services.PartsService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddAuthorizationCore(config =>
{
    config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
    config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
});

builder.Services.AddBlazoredModal();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<IFurnitureService, FurnitureService>();
builder.Services.AddScoped<IPartsService, PartsService>();

await builder.Build().RunAsync();
