using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void create(Player player)
        {
            if (_userValidationService.Validate(player))
            {

                Console.WriteLine("kayıt oluşturuldu "+player.FirstName);
            }
            else
            {
                Console.WriteLine("doğrulama başarısız kayıt oluşturulamadı ");
            }
        }

        public void delete(Player player)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void read(Player player)
        {
            Console.WriteLine("kayıt okundu");
        }

        public void update(Player player)
        {
            Console.WriteLine("kayıt Güncellendi");
        }
    }
}
