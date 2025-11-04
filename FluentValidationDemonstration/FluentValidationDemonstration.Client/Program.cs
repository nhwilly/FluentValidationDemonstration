using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FluentValidation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
await builder.Build().RunAsync();
