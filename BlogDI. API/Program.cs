using BlogDI._API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// adding my dependancies

builder.Services.AddTransient<IBlogRepository , NewBlogRepository>(); // response eke errors awoth me deka danna

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
