global using BlazorWebAsApp.Shared;
global using BlazorWebAsApp.Client.Services.ProductService;
global using BlazorWebAsApp.Client.Services.CategoryService;
global using BlazorWebAsApp.Client.Services.AuthService;
global using BlazorWebAsApp.Client.Services.CartService;
global using BlazorWebAsApp.Client.Services.OrderService;
global using BlazorWebAsApp.Client.Services.AddressService;
global using BlazorWebAsApp.Client.Services.ProductTypeService;
using Blazored.LocalStorage;
using BlazorWebasApp.Client;
using BlazorWebAsApp.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();