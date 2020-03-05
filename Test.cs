using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;

namespace Project1
{
    public class TennisTest
    {
        private static Tennis _tennis;

        public static void Main()
        {
            object i = new object();
            object ed = new Object();
            Console.WriteLine($"{i.GetType()},{ed.ToString()}");
            Console.ReadLine();
        }

        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }

        [Test]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            _tennis.SetFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            _tennis.SetFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Forty_Love()
        {
            _tennis.SetFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        [Test]
        public void Love_Fifteen()
        {
            _tennis.SetFirstPlayerScore(0);
            _tennis.SetSecondPlayerScore(1);
            ScoreShouldBe("Love Fifteen");
        }

        [Test]
        public void Love_Thirty()
        {
            _tennis.SetFirstPlayerScore(0);
            _tennis.SetSecondPlayerScore(2);
            ScoreShouldBe("Love Thirty");
        }

        [Test]
        public void Fifteen_All()
        {
            _tennis.SetFirstPlayerScore(1);
            _tennis.SetSecondPlayerScore(1);
            ScoreShouldBe("Fifteen All");
        }

        [Test]
        public void Thirty_All()
        {
            _tennis.SetFirstPlayerScore(2);
            _tennis.SetSecondPlayerScore(2);
            ScoreShouldBe("Thirty All");
        }

        [Test]
        public void Forty_All()
        {
            _tennis.SetFirstPlayerScore(3);
            _tennis.SetSecondPlayerScore(3);
            ScoreShouldBe("Forty All");
        }

        [Test]
        public void Deuce()
        {
            _tennis.SetFirstPlayerScore(4);
            _tennis.SetSecondPlayerScore(4);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void Deuce_5()
        {
            _tennis.SetFirstPlayerScore(5);
            _tennis.SetSecondPlayerScore(5);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void First_Adv()
        {
            _tennis.SetFirstPlayerScore(4);
            _tennis.SetSecondPlayerScore(3);
            ScoreShouldBe("Rainy Adv");
        }

        [Test]
        public void Second_Adv()
        {
            _tennis.SetFirstPlayerScore(3);
            _tennis.SetSecondPlayerScore(4);
            ScoreShouldBe("Korone Adv");
        }

        [Test]
        public void Other_Deuce()
        {
            _tennis.SetFirstPlayerScore(4);
            _tennis.SetSecondPlayerScore(4);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void Win()
        {
            _tennis.SetFirstPlayerScore(5);
            _tennis.SetSecondPlayerScore(3);
            ScoreShouldBe("Rainy Win");
        }

        private static void ScoreShouldBe(string except)
        {
            Assert.AreEqual(_tennis.Score(), except);
        }
    }
}
