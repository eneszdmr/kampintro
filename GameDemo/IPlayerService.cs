using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IPlayerService
    {
        void create(Player player);
        void read(Player player);
        void update(Player player);
        void delete(Player player);

    }
}
