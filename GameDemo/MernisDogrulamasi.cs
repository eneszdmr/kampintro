using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class MernisDogrulamasi : IUserValidationService
    {
        public bool Validate(Player player)
        {
            return true;
        }
    }
}
