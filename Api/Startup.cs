﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace NetCoreApiDockerHelloWorld
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
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info 
                { 
                    Title = "NET Core API Hello World docker hosted", 
                    Version = "v1", 
                    Description = "A Hello World example ASP.NET Core Web API which is hosted on docker",
                    TermsOfService = "None",
                    Contact = new Contact 
                    {
                        Name = "David Sedman", 
                        Email = "", 
                        Url = "https://github.com/DavidSedman/NetCoreApiDockerHelloWorld" 
                    },
                    License = new License 
                    { 
                        Name = "Use under GNU GENERAL PUBLIC LICENSE", 
                        Url = "https://raw.githubusercontent.com/DavidSedman/NetCoreApiDockerHelloWorld/master/LICENSE" 
                    }
                });

                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "NetCoreApiDockerHelloWorld.xml"); 
                c.IncludeXmlComments(xmlPath);
            });

             
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();
        }
    }
}
