using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAngularAppWithJWTAuth.Models
{
    public class TokenResponse
    {
        public string Token { get; set; } // jwt token
        public DateTime Expiration { get; set; } // expiry time
        public string Refresh_Token { get; set; } // refresh token
        public string Roles { get; set; } // user role
        public string UserName { get; set; } // user name
    }
}
