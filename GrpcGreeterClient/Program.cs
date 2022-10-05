using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");

            Greeter.GreeterClient client = new Greeter.GreeterClient(channel);

            HelloReply reply = await client.SayHelloAsync(new HelloRequest { Name = "Abdullah" });
            Console.WriteLine("Greeting: " + reply.Message);

            //Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}