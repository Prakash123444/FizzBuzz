using TestApplication_ForAccenture.BusinessComponents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
  
builder.Services.AddScoped<TestFizz>();
builder.Services.AddScoped<TestBuzz>();
builder.Services.AddScoped<TestFizzBuzz>();
builder.Services.AddScoped<IFizzBuzzFactory, FizzBuzzFactory>();

builder.Services.AddCors(X => {
    X.AddPolicy("Policy", policy => {

        policy.WithOrigins("*");
    });
});

var app = builder.Build();
app.Services.GetService<IHttpContextAccessor>();
//var logservice = app.Services.GetService<ILoggerFactory>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
