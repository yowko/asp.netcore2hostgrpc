using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using gRPC.Message;
using Grpc.Core;

namespace gRPC.Server
{
    public class gRPCServiceImpl : gRPCService.gRPCServiceBase
    {
        public override Task<Response> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Response
                {
                    IsSuccess = true,
                    ResponseMsg = $"Hi {request.Name} @ {request.SendDate.ToDateTime()} !!!"
                }
            );
        }

        public override Task<Response> SayGoodbye(GoodByeRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Response
                {
                    IsSuccess = true,
                    ResponseMsg = $"Bye,{request.Name}"
                }
            );
        }
    }
}