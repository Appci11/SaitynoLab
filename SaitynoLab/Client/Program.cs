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
// pasalinus paskutini user'i refresh'o bug'as bet greiciau overall...
builder.Services.AddScoped<IUsersService, UsersService>();
// same story...
builder.Services.AddScoped<IOrdersService, OrdersService>();
// daznokai gali paskutinis pradingt - transient
builder.Services.AddTransient<IFurnitureService, FurnitureService>();
builder.Services.AddTransient<IPartsService, PartsService>();

await builder.Build().RunAsync();
