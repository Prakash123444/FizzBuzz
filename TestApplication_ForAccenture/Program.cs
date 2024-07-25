using TestApplication_ForAccenture.BusinessComponents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<ITest>();
//builder.Services.AddTransient<FizzBuzzFactory>();
//builder.Services.AddTransient<IFizzBuzzFactory>();

//builder.Services.BuildServiceProvider();

builder.Services.AddTransient<TestFizz>();
builder.Services.AddTransient<TestBuzz>();
builder.Services.AddTransient<TestFizzBuzz>();
builder.Services.AddTransient<IFizzBuzzFactory, FizzBuzzFactory>();

var serviceProvider = builder.Services.BuildServiceProvider();

var fizzBuzzFactory = serviceProvider.GetService<IFizzBuzzFactory>();
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
