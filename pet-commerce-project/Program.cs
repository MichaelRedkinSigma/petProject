using System.Text.Json;
using System.Text.Json.Serialization;
using Pet.Commerce.Project.DevTools;

var builder = WebApplication.CreateSlimBuilder(args);
_ = builder.Services.AddControllers()
    .AddApplicationPart(typeof(DevToolsController).Assembly)
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
_ = builder.Services.AddSwaggerGen();

var app = builder.Build();

_ = app.MapControllers();
_ = app.UseSwagger();
_ = app.UseSwaggerUI();

app.Run();
