
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
           playerManager.create(new Player
            {
                Id=1,
                FirstName="enes", LastName="demir",IdentityNumber="123456"
            });

            PlayerManager pmanager = new PlayerManager(new YeniEdevletDogrulamasi());
            pmanager.create(new Player {
            Id=2,FirstName="a",LastName="b",IdentityNumber="2"
            });
        }
    }
}
