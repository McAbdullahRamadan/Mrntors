using Infrastructure;
using MrntorsClone.Application.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Controllers
builder.Services.AddControllers();

// Application Layer
builder.Services.AddApplication();

// Infrastructure Layer (DbContext + Identity + Repos)
builder.Services.AddInfrastructure(builder.Configuration);

// Authentication & Authorization
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

// OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();