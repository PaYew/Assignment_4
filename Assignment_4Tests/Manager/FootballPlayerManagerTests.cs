using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using Assignment_1;

namespace Assignment_4.Managers.Tests
{
    [TestClass()]
    public class FootballPlayerManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager();
            FootballPlayer? player = manager.GetByID(2);
            Assert.AreEqual(30, player.Age);
        }

        [TestMethod()]
        public void Test()
        {
            FootballPlayerManager manager = new FootballPlayerManager();
            FootballPlayer PlayerTest = new FootballPlayer{ Id = 5, Name = "Maradona", Age = 35, ShirtNumber = 5 };
            FootballPlayer player = manager.Add(PlayerTest);
            Assert.AreEqual("Maradona", player.Name);
        }
    }
}