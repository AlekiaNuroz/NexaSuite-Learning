using NexaSuite.Application;
using NexaSuite.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.Services.AddApplication(); // <— MediatR & Application layer
builder.Services.AddInfrastructure(builder.Configuration);

// builder.Services.AddInfrastructure(builder.Configuration); // will add in Step 3

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
