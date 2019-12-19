using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace AddressBookServices
{
   
    public class ManageAddressService : ManageAddress.ManageAddressBase
    {
        private readonly ILogger<ManageAddressService> _logger;
        public ManageAddressService(ILogger<ManageAddressService> logger)
        {
            _logger = logger;
        }

        public override Task<AddPersonReply> AddPerson(AddPersonRequest request, ServerCallContext context)
        {
            Person p = new Person() {
                Id = Guid.NewGuid().ToString(),
                Lname = request.Lname,
                Fname = request.Fname
            };
            
            _logger.LogInformation("Person {0} {1} inserted with id: {2}", p.Fname, p.Lname, p.Id);

            return Task.FromResult(new AddPersonReply
            {
                Ack = true,
                Id = p.Id
            });
        }

        public override Task<DelPersonReply> DelPerson(DelPersonRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Delete person with id: {0}", request.Id);

            return Task.FromResult(new DelPersonReply() { 
                Ack = true 
            });
        }

        public override Task<UpdPersonReply> UpdPerson(UpdPersonRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Updated person with id: {0}", request.Person.Id);

            return Task.FromResult(new UpdPersonReply() { 
                Ack = true 
            });
        }

    }
}
