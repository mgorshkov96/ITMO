using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPNET.WebForms.RSVP.App_Code
{
    public class ResponseRepository
    {
        private static ResponseRepository repository= new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>();

        public static ResponseRepository GetResponse()
        {
            return repository;
        }

        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }

        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}