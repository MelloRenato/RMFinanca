
using Microsoft.Extensions.Configuration;
using RMFinanca;
using RMFinanca.Data;

var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

using var context = new FinancaDataContext();

var ctx = new FinancaDataContext();



ctx.services.AddDbContext<FinancaDataContext>(
                options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("RMFinanca.Migrations")));

//app.Run();


