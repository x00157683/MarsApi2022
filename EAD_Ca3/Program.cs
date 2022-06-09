using EAD_Ca3;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Havit.Blazor.Components.Web;        // <------ ADD THIS LINE
using Havit.Blazor.Components.Web.Bootstrap;
using EAD_Ca3.HttpRepository;
using Microsoft.AspNetCore.Components.Authorization;
using EAD_Ca3.AuthProviders;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddHxServices();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
await builder.Build().RunAsync();
