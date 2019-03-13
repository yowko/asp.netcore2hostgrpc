using System;
using System.Threading.Tasks;
using gRPC.Message;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Jaeger;
using Microsoft.Extensions.Logging;
using OpenTracing.Contrib.Grpc.Interceptors;

namespace gRPC.Server
{
    public class Program
    {
        const string Server = "127.0.0.1";
        const int Port = 50051;


        public static async Task Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            Tracer tracer = TracingHelper.InitTracer("server", loggerFactory);
            ServerTracingInterceptor tracingInterceptor = new ServerTracingInterceptor(tracer);


            Grpc.Core.Server serverInstance = new Grpc.Core.Server
            {
                Services = {gRPCService.BindService(new gRPCServiceImpl()).Intercept(tracingInterceptor)},
                Ports = {new ServerPort(Server, Port, ServerCredentials.Insecure)}
            };

            serverInstance.Start();

            Console.WriteLine($"Greeter server listening on server {Server} and port {Port}");
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            await serverInstance.ShutdownAsync();
        }
    }
}