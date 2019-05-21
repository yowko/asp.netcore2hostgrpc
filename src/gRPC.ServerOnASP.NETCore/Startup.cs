using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core.Interceptors;
using gRPC.Message;
using Jaeger;
//using Jaeger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenTracing.Contrib.Grpc.Interceptors;
using Microsoft.Extensions.Configuration.FileExtensions;

namespace gRPC.ServerOnASP.NETCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            var serviceName = "gRPC.ServerOnASP.NETCore";
            Tracer tracer = TracingHelper.InitTracer(serviceName, loggerFactory);
            ServerTracingInterceptor tracingInterceptor = new ServerTracingInterceptor(tracer);

            var host = "127.0.0.1";
            var port = 50051;
            
            services.AddSingleton<gRPCService.gRPCServiceBase, gRPCServiceImpl>();
            
            var Services = services.BuildServiceProvider();
            services.AddSingleton(
                new gRPCServer(host, port,
                    gRPCService.BindService(Services.GetRequiredService<gRPCService.gRPCServiceBase>()).Intercept(tracingInterceptor)
                ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}