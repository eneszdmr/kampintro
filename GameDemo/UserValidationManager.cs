using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.FirstName=="enes" && player.LastName=="demir" && player.IdentityNumber=="123456" )
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
