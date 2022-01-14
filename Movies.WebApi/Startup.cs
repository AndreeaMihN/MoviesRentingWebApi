using System.Reflection;
using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.Persistance;
using Microsoft.EntityFrameworkCore;
using Movies.Persistance.Repositories;
using Movies.Domain.Interfaces;

namespace MoviesWebApi
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add Repositories
            RegisterRepositories(typeof(Repository<>).GetTypeInfo().Assembly, services);

            // Add AutoMapper
            services.AddAutoMapper();

            //Add UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Add DbContext using SQL Server Provider
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            // Customize default API behavior
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMvc();
        }

        private void RegisterRepositories(Assembly assembly, IServiceCollection services)
        {

            var repositories = assembly.GetTypes().Where(type =>
                type.GetTypeInfo().IsClass &&
                !type.GetTypeInfo().IsAbstract &&
                type.Name.EndsWith("Repository"));

            foreach (var repository in repositories)
            {
                var interfaces = repository.GetInterfaces();
                var mainInterfaces = interfaces.Except
                        (interfaces.SelectMany(t => t.GetInterfaces()));
                foreach (var @interface in mainInterfaces)
                {
                    services.AddScoped(@interface, repository);
                }
            }
        }
    }
}
