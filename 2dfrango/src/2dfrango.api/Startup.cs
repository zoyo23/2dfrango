using _2dfrango.infra.ioc.Dependency_Injection;
using _2dfrango.infra.repository.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace _2dfrango.api
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            #region Swagger Configuration
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "2DFrango API",
                    Version = "v1",
                    Description = "Api referente ao Projeto desenvonvido no Hackathon Mega Hack."
                });
            });
            #endregion

            services.AddDbContext<_2dFrangoContext>();

            #region CORS
            services.AddCors(c =>
            {
                c.AddPolicy("default", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            #endregion

            #region Social Logins
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddCookie()
                .AddOpenIdConnect("Auth0", config =>
                {
                    config.ClientId = "ZAYaXjVqL1db4m0VSeaUH9SjKSCzNe7h";
                    config.ClientSecret = "ony8grQ4n3N6VA2RP5SVgS43Rsc3Nd0no--SfEDJhL6twiU2gqRRsyMCiMHK3pN_";
                })
                .AddFacebook(config =>
                {
                    config.AppId = "234918024486588";
                    config.AppSecret = "39ce8db252a9e7968fba7b0a302cd9fe";
                })
                .AddGoogle(config =>
                {
                    config.ClientId = "419273351615-a2kp1blvs5f3idt3mlr5vbkeqtqgjvr6.apps.googleusercontent.com";
                    config.ClientSecret = "xkF4sgzzPO8MP9eHmLmp8Gwv";
                });
            #endregion

            DependencyInjectionResolver.RegisterServices(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Swagger Configuration
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "2DFrango API v1");
                c.RoutePrefix = string.Empty;
            });
            #endregion

            #region CORS
            app.UseCors("default");
            #endregion

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
