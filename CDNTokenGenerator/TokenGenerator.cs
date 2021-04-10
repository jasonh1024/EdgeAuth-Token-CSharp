using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBeat.Akamai.EdgeAuthToken;

namespace CDNTokenGenerator
{
    class TokenGenerator
    {
        public static string GenerateMyToken(long window, string acl, string key)
        {
            var tokenConfig = new AkamaiTokenConfig
            {
                EndTime = DateTimeOffset.Now.AddMinutes(+5).ToUnixTimeSeconds(), // Time to live (in seconds)
                //StartTime = DateTimeOffset.Now.AddMinutes(-5).ToUnixTimeSeconds(), //time to start in seconds
                Window=window,
                Acl = acl, // Access control list containing token permissions
                Key = key // Encryption key
            };

            var tokenGenerator = new AkamaiTokenGenerator();

            var token = tokenGenerator.GenerateToken(tokenConfig);

            return token;
        }
    }
}
