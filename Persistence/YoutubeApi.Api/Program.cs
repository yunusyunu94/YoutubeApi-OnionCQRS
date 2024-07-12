
//1
using YoutubeApi.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//------------------------------------------------------------------

//apsettings.json deki devolopment ve production lari atýrmamýz icn ;

var env = builder.Environment;
builder.Configuration
	.SetBasePath(env.ContentRootPath)
	.AddJsonFile("appsettings.json", optional:false)
	.AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional:true);

//------------------------------------------------------------------



//------------------------------------------------------------------

//1
// Registation daki ismi verdik ama yukarýya usin olarak ekledik
builder.Services.AddPersistance(builder.Configuration);

//------------------------------------------------------------------



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
