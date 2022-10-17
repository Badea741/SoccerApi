using System.Text;
using AuthenticationServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using Serilog;
using Soccer.Api;
using Soccer.Api.ServiceConfigurations;
using Soccer.Mq;
using Soccer.Mq.Models;
using Soccer.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console();
    lc.WriteTo.File("Logs/log.txt");
    lc.Enrich.WithProperty("SimpleProperty", builder.Configuration.GetValue<string>("SimpleProperty"));
    lc.WriteTo.Seq("http://localhost:5341");
    lc.Enrich.WithProcessName();
});

builder.Services.Configure<RabbitMqConfiguration>(builder.Configuration.GetSection("RabbitMQ"));
builder.Services.AddSingleton<MessageQueueHelper>();


RabbitMqConfiguration rabbit = new RabbitMqConfiguration();
builder.Configuration.GetSection("RabbitMQ").Bind(rabbit);


Console.WriteLine(rabbit.HostName);

// IModel model = connection.CreateModel();
// model.ExchangeDeclare("testExchange1", "direct", true, true);
// model.QueueDeclare("testQueue1", true, false, true);
// model.QueueBind("testQueue1", "testExchange1", "route1");
// model.BasicPublish("testExchange1", "route1", null, Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(rabbit)));







builder.Host.ConfigureAppConfiguration(options =>
{
    options.AddEnvironmentVariables();
});
//ohasdf
// Add services to the container.

builder.Services.AddControllers(options =>
{
    // options.Filters.Add(new AuthorizeFilter());
}).AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCorsConfiguration();
builder.Services.AddSwaggerGenConfiguration(builder.Configuration);
builder.Services.AddAuthenticationConfiguration(builder.Configuration);
builder.Services.AddDbContextConfiguration(builder.Configuration);
builder.Services.AddIdentityConfiguration();
builder.Services.AddRepositories();
builder.Services.AddUnitsOfWork();
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddFluentValidation();
builder.Services.AddLocalizationConfiguration();


var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {

// }

// Log.Logger = new LoggerConfiguration()
//     .WriteTo.Console()
//     .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
//     .Enrich.WithProperty("Application123", "Soccer.Api123")
//     .WriteTo.Seq("http://seq:5341")
//     .CreateLogger();
//add serilog to the services

using (var serviceScope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
{
    var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>()!;

    context.Database.Migrate();

}

app.UseDeveloperExceptionPage();
app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
app.UseCors(CorsConfiguration.CorsPolicyName);
// app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "SoccerApiV1");
    options.RoutePrefix = string.Empty;
});
Jwt jwt = new();
builder.Configuration.GetSection("Jwt").Bind(jwt);
System.Console.WriteLine(jwt.Key);
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
