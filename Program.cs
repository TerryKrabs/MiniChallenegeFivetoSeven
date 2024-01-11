using MiniChallenegeFivetoSeven.Services.MadLibService;
using MiniChallenegeFivetoSeven.Services.OddOrEvenService;
using MiniChallenegeFivetoSeven.Services.reverseIntService;
using MiniChallenegeFivetoSeven.Services.reverseStringService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ImadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IreverseIntService, reverseIntService>();
builder.Services.AddScoped<IreverseStringService, reverseStringService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
