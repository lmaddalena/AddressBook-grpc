using System;
using System.Net.Http;
using System.Threading.Tasks;
using AddressBookServices;
using Grpc.Net.Client;

namespace AddressBookClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            /*
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            */

            // create the channel
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new ManageAddress.ManageAddressClient(channel);

            // add Person
            System.Console.WriteLine("Add Person:");
            var addPersonReply = await client.AddPersonAsync(
                              new AddPersonRequest { 
                                      Fname = "John",
                                      Lname = "Smith",
                                      Addess = "Boulevard of Broken Dreams"
                                });

            Console.WriteLine("Person Added. Id: " + addPersonReply.Id);

            // del Person
            var delPersonReply = await client.DelPersonAsync (
                new DelPersonRequest() {
                    Id = addPersonReply.Id
                }
            );
            System.Console.WriteLine("Person deleted");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }   
    }
}