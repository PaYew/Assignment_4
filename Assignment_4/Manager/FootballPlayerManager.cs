using Assignment_1;
using Assignment_4;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Assignment_4.Managers
{
    public class FootballPlayerManager
    {
        private static int id = 0;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer{ Id = id++, Name = "Levandovski", Age = 20, ShirtNumber = 5 },
            new FootballPlayer{ Id = id++, Name = "Messi", Age = 30, ShirtNumber = 10 },
            new FootballPlayer{ Id = id++, Name = "Rolando", Age = 40, ShirtNumber = 15 },
            new FootballPlayer{ Id = id++, Name = "Dziagwa", Age = 50, ShirtNumber = 20 },
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }
        public FootballPlayer? GetByID(int id)
        {
            return Data.Find(player => player.Id == id);
        }
        public FootballPlayer Add(FootballPlayer Player)
        {
            Player.Id = id++;

            Data.Add(Player);

            return Player;
        }
        public FootballPlayer? Update(int id, FootballPlayer updates)
        {
            FootballPlayer? player = Data.Find(player1 => player1.Id == id);
            if (player == null)
            {
                return null;
            }
            else
            {
                Data.Remove(player);
                return player;
            }

        }
        public FootballPlayer? Delete(int id)
        {
            FootballPlayer? player = Data.Find(player1 => player1.Id == id);
            if (player == null)
            {
                return null;
            }
            else
            {
                Data.Remove(player);
                return player;
            }
        }
    }
}