using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData6Demo.Api.Models;
using OData6Demo.Api.Services;

namespace OData6Demo.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //added edm model for odata api 
            IEdmModel GetEdmModel()
            {
                var edmBuilder = new ODataConventionModelBuilder();
                edmBuilder.EntitySet<Student>("Students");
                return edmBuilder.GetEdmModel();
            }

            services.AddControllers().AddOData(options => 
                options.Select()
                    .Expand()
                    .OrderBy()
                    .SetMaxTop(default)
                    .Count()
                    .Filter()
                    .SkipToken()
                    .AddRouteComponents("odata",GetEdmModel()));


            services.AddTransient<IStudentService, StudentService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
