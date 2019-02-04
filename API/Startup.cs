using GMAO.BusinessLogicLayer;
using GMAO.BusinessLogicLayer.Contracts;
using GMAO.Context;
using GMAO.DataAccessLayer.Contracts;
using GMAO.DataAccessLayer.Repository;
using GMAO.DataAccessLayer.UnitOfWork;
using GMAO.Entities;
using GMAO.Service.Binding;
using GMAO.Service.Interfaces.Invoice;
using GMAO.Service.Invoice;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using System.Net;

namespace API
{
    public class Startup
    {
        private static string _applicationPath = string.Empty;
        private static string _contentRootPath = string.Empty;
        public static decimal _timbreFiscale;
        public static string _connectionName;
        internal static int _etatNonValider;
        internal static int _factureReguliere;
        internal static int _taxe;
        internal static int _pourcentage;
        internal static int _gratuitSiSuperieur;
        internal static int _rangLicenceGratuit;
        internal static int _gratuitSiClientAUnAutreProduit;
        internal static int _gratuitSiInferieur;

        public static string _connectionReporting;

        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            Configuration = ConfigurationHelper.ReadConfiguration(env.ContentRootPath);

            _applicationPath = env.WebRootPath;
            _contentRootPath = env.ContentRootPath;
          
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           

           AutoMapperConfiguration.Configure();

            services.AddDbContext<GMAODbContext>(options =>
                options.UseSqlServer(Configuration["Data:GMAOConnection:ConnectionString"], b => b.MigrationsAssembly("API")));

            //Injections
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<GMAODbContext>();

            //service
        
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMembershipService, MembershipService>();
            services.AddScoped<IUsersInRolesService, UsersInRolesService>();

            //BLL
         
            services.AddScoped<IGenericBLL<User>, GenericBLL<User>>();
            services.AddScoped<IGenericBLL<Role>, GenericBLL<Role>>();
            services.AddScoped<IGenericBLL<Membership>, GenericBLL<Membership>>();
            services.AddScoped<IGenericBLL<UsersInRoles>, GenericBLL<UsersInRoles>>();

            //Repositories
        
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Role>, RoleRepository>();
            services.AddScoped<IRepository<Membership>, MemberShipRepository>();
            services.AddScoped<IRepository<UsersInRoles>, UsersInRolesRepository>();

            // Enable Cors
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "GMAO", Version = "v1" });
            });
            // Add MVC services to the services container.
            services.AddMvc()
                .AddJsonOptions(opts =>
                {
                    // Force Camel Case to JSON
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            //Json Serialisation Prov
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            // Add MVC to the request pipeline.
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());

            app.UseAuthentication();

            app.UseExceptionHandler(
              builder =>
              {
                  builder.Run(
                    async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                        context.Response.Headers.Add("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept, Authorization");
                        context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, PATCH");

                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null)
                        {
                            //context.Response.AddApplicationError(error.Error.Message);

                            //await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                        }
                    });
              });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                // Uncomment the following line to add a route for porting Web API 2 controllers.
                //routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");
            });
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
         


        }
    }


    public static class ConfigurationHelper
    {
        public static IConfiguration ReadConfiguration(string baseDirectory)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(baseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
