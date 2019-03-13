using System;
using System.Threading.Tasks;
using gRPC.Message;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Jaeger;
using Microsoft.Extensions.Logging;
using OpenTracing.Contrib.Grpc.Interceptors;

namespace gRPC.Client
{
    public class Program
    {
        const string Server = "localhost";
        const int Port = 50051;

        public static async Task Main(string[] args)
        {
            var loggerFactory =new LoggerFactory().AddConsole();
            Tracer tracer = TracingHelper.InitTracer("client", loggerFactory);
            ClientTracingInterceptor tracingInterceptor = new ClientTracingInterceptor(tracer);


            Channel channel = new Channel($"{Server}:{Port}", ChannelCredentials.Insecure);

            var client = new gRPCService.gRPCServiceClient(channel.Intercept(tracingInterceptor));
            string user = "yowko";

            var reply = client.SayHello(new HelloRequest {Name = user,SendDate = DateTime.UtcNow.ToTimestamp()});
            Console.WriteLine("Greeting: " + reply.ResponseMsg);


            var response = client.SayGoodbye(new GoodByeRequest() {Name = user});
            Console.WriteLine("Response: " + response.ResponseMsg);

            await channel.ShutdownAsync();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}