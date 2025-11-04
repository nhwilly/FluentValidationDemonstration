using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FluentValidation;
using Morris.Blazor.Validation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddFormValidation(config =>
  config
    .AddDataAnnotationsValidation()
    .AddFluentValidation(typeof(Program).Assembly)
);
await builder.Build().RunAsync();
