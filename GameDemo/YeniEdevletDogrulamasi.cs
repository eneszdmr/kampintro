using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class YeniEdevletDogrulamasi : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.FirstName=="a" && player.LastName=="b" && player.IdentityNumber=="1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
