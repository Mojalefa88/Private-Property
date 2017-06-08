using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP.Model;
using Plugin.RestClient;

namespace MPP.Services
{
   public class UserServices
    { 
        public async Task<List<User>> GetUserAsync()
        {
            RestClient<User> restClient = new RestClient<User>();

            var userList = await restClient.GetAsync();

            return userList;
        }
    }
}
