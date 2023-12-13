using BBlogBlazor;
using BBlogBlazor.Services;
using BBlogBlazor.Services.IRepository;
using BBlogBlazor.Services.IServices;
using Blazored.LocalStorage;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped<IPostClient, PostClient>();
builder.Services.AddScoped<ICategoryClient, CategoryClient>();
builder.Services.AddScoped<IAccountClient, AccountClient>();
builder.Services.AddSweetAlert2(opt => opt.Theme = SweetAlertTheme.Default);
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5000/") });
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

await builder.Build().RunAsync();
