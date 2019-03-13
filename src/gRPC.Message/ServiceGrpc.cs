// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC.Message {
  public static partial class gRPCService
  {
    static readonly string __ServiceName = "gRPC.Message.gRPCService";

    static readonly grpc::Marshaller<global::gRPC.Message.HelloRequest> __Marshaller_gRPC_Message_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC.Message.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC.Message.Response> __Marshaller_gRPC_Message_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC.Message.Response.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC.Message.GoodByeRequest> __Marshaller_gRPC_Message_GoodByeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC.Message.GoodByeRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPC.Message.HelloRequest, global::gRPC.Message.Response> __Method_SayHello = new grpc::Method<global::gRPC.Message.HelloRequest, global::gRPC.Message.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_gRPC_Message_HelloRequest,
        __Marshaller_gRPC_Message_Response);

    static readonly grpc::Method<global::gRPC.Message.GoodByeRequest, global::gRPC.Message.Response> __Method_SayGoodbye = new grpc::Method<global::gRPC.Message.GoodByeRequest, global::gRPC.Message.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayGoodbye",
        __Marshaller_gRPC_Message_GoodByeRequest,
        __Marshaller_gRPC_Message_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC.Message.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of gRPCService</summary>
    public abstract partial class gRPCServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Message.Response> SayHello(global::gRPC.Message.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC.Message.Response> SayGoodbye(global::gRPC.Message.GoodByeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for gRPCService</summary>
    public partial class gRPCServiceClient : grpc::ClientBase<gRPCServiceClient>
    {
      /// <summary>Creates a new client for gRPCService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public gRPCServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for gRPCService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public gRPCServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected gRPCServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected gRPCServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::gRPC.Message.Response SayHello(global::gRPC.Message.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPC.Message.Response SayHello(global::gRPC.Message.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC.Message.Response> SayHelloAsync(global::gRPC.Message.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC.Message.Response> SayHelloAsync(global::gRPC.Message.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::gRPC.Message.Response SayGoodbye(global::gRPC.Message.GoodByeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayGoodbye(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPC.Message.Response SayGoodbye(global::gRPC.Message.GoodByeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayGoodbye, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC.Message.Response> SayGoodbyeAsync(global::gRPC.Message.GoodByeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayGoodbyeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC.Message.Response> SayGoodbyeAsync(global::gRPC.Message.GoodByeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayGoodbye, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override gRPCServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new gRPCServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(gRPCServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SayGoodbye, serviceImpl.SayGoodbye).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, gRPCServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Message.HelloRequest, global::gRPC.Message.Response>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_SayGoodbye, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Message.GoodByeRequest, global::gRPC.Message.Response>(serviceImpl.SayGoodbye));
    }

  }
}
#endregion
