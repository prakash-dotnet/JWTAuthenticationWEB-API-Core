using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "prakash_admin", EmailAddress = "prakash.admin@email.com", Password = "prakash123", GivenName = "Prakash", Surname = "G", Role = "Administrator" },
            new UserModel() { Username = "surya_seller", EmailAddress = "surya.seller@email.com", Password = "surya123", GivenName = "Surya", Surname = "G", Role = "Seller" },
        };
    }
}
