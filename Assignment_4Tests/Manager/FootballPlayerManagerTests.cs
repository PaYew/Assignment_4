using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using MandaAssig_1;

namespace Assignment_4.Managers.Tests
{
    [TestClass()]
    public class FootballPlayerManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager();

            List<FootballPlayer> allPlayers = manager.GetAll();
            Assert.AreEqual(2, allPlayers.Count);

            FootballPlayer player = manager.GetByID(1);
            Assert.AreEqual("Ronaldo", player.Title);

            Assert.IsNull(manager.GetByID(100));

            FootballPlayer newPlayer = new FootballPlayer(4, "Pepe", 24, 17);
            FootballPlayer addedPlayer = manager.Add(newPlayer);
            Assert.AreEqual(3, addedPlayer.ID);
            Assert.AreEqual(3, manager.GetAll().Count);

            FootballPlayer newPlayer1 = new FootballPlayer(3, "Modric", 22, 14);
            FootballPlayer updatedPlayer = manager.Update(3, updates);
            Assert.AreEqual("Modric", updatedPlayer.Title);

            Assert.IsNull(manager.Update(100, updates));

            FootballPlayer deletedPlayer = manager.Delete(3);
            Assert.AreEqual("Modric", deletedPlayer.Title);
            Assert.AreEqual(2, manager.GetAll().Count);

            Assert.IsNull(manager.Delete(100));
        }
    }
}