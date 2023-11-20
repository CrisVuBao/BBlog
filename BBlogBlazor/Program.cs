using BBlogBlazor;
using BBlogBlazor.Services;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped<IPostClient, PostClient>();
builder.Services.AddScoped<ICategoryClient, CategoryClient>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5000/") });


await builder.Build().RunAsync();
