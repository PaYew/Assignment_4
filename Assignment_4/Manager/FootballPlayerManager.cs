using Assignment_1;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Assignment_4.Managers
{
    public class FootballPlayerManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer(_nextId++, "Ronaldo", 32, 7),
            new FootballPlayer(_nextId++, "Messi", 28, 10),
            new FootballPlayer(_nextId++, "Kacper", 20, 99),
            new FootballPlayer(_nextId++, "Pawel", 90, 69),
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }
        public FootballPlayer GetByID(int id)
        {
            return Data.Find(player => player.ID == id);
        }
        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.ID = _nextId++;
            Data.Add(newPlayer);
            return newPlayer;
        }
        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer player = Data.Find(player1 => player1.ID == id);
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
        public FootballPlayer Delete(int id)
        {
            FootballPlayer book = Data.Find(player1 => player1.Id == id);
            if (book == null)
            {
                return null;
            }
            else
            {
                Data.Remove(book);
                return book;
            }
        }
    }
}