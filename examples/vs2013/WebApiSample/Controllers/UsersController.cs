using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            return SampleUsers.GetUsers();
        }

        [HttpGet]
        [Route("api/users/firstName/autocomplete")]
        public IEnumerable<string> FirstNameAutocomplete(string term)
        {
            return SampleUsers
                .GetUsers()
                .Where(u => u.FirstName.ToLower().Contains(term.ToLower()))
                .Select(s=> s.FirstName)
                .Distinct()
                .Take(10);
        }
        
        [HttpGet]
        [Route("api/users/autocomplete")]
        public IEnumerable<User> Autocomplete(string term)
        {
            return SampleUsers
                .GetUsers()
                .Where(u => u.FirstName.ToLower().Contains(term.ToLower()) ||
                            u.LastName.ToLower().Contains(term.ToLower()) ||
                            u.Username.ToLower().Contains(term.ToLower()))
                .Take(10);
        }
    }
}