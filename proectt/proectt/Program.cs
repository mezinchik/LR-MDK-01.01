using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proectt
{
    

    class Programm
    {
        static void PrintPlayer(Player player)
        {
            Console.WriteLine("Имя: " + player.Name);
            Console.WriteLine("Здоровье: " + player.Health);
        }

        static void Main()
        {
            Player player1;

            player1.Name = "Alien";
            player1.Health = 130;

            Player player2 = new Player
            {
                Name = "GreenCat",
                Health = 100
            };

            PrintPlayer(player1);
            PrintPlayer(player2);

            Player[] players = new Player[5];

            players[0] = new Player { Name = "Alien", Health = 130 };
            players[1] = new Player { Name = "GreenCat", Health = 100 };
            players[2] = new Player { Name = "Al", Health = 150 };
            players[3] = new Player { Name = "ien", Health = 180 };
            players[4] = new Player { Name = "li", Health = 80 };
        }
    }
}
