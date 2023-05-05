using application.features.products.queries.get_all_products;
using context;
using FluentValidation;
using infastructure;
using infrastructure;
using Microsoft.EntityFrameworkCore;
using qena.api.contracts;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("itilabb3")));

builder.Services.AddMediatR(config =>
{ config.RegisterServicesFromAssembly(typeof(FilterproductQuery).Assembly); });


builder.Services.AddValidatorsFromAssembly(typeof(FilterproductQuery).Assembly);
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddControllers()
                    .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

/////////////////////////////////////
var app = builder.Build();
/////////////////////////////////////
///
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();

app.Run();




//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<DbContextWebApiTest>(options => options
//                            .UseSqlServer(builder.Configuration.GetConnectionString("SqlserverConnect")));

//builder.Services.AddMediatR(config =>
//{ config.RegisterServicesFromAssembly(typeof(FilterCategoriesQuery).Assembly); });


//builder.Services.AddValidatorsFromAssembly(typeof(FilterCategoriesQuery).Assembly);

//builder.Services.AddControllers();

//builder.Services.AddControllers()
//            .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddScoped<IProductRepository, ProductRepository>();
////builder.Services.AddControllers().AddNewtonsoftJson(
////    options => { options.SerializerSettings.ContractResolver = new DefaultContractResolver(); });
////Configuration with swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.MapControllers();

//app.MapGet("/", () => "Hello World!");
////app.MapControllerRoute("asd", "api/{controller}/{action}");

//app.Run();
//    }
//}


//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<QenaDbContext>(options =>
//{
//    options.UseLazyLoadingProxies();
//    options.UseSqlServer(builder.Configuration.GetConnectionString("QenaDbConnectionString"));
//}
//);
//builder.Services.AddMediatR(config =>
//{
//    config.RegisterServicesFromAssembly(typeof(FilterCategoriesQuery).Assembly);
//});
//builder.Services.AddValidatorsFromAssembly(typeof(FilterCategoriesQuery).Assembly);
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

///////////////////////////////////////
//var app = builder.Build();
////////////////////////////////////////

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.MapControllers();

/////////////////////////////////////////////
app.Run();
