using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TKBoisvert.Berries.Tests
{
    [TestFixture]
    public class When_playing_with_berries
    {
        [Test]
        public void should_be_Squish()
        {
            Berry berry = new Berry(true, "purple", "asdf");

            berry.Squish();

            bool didISquishIt = berry.IsTheBerrySquished();

            Assert.AreEqual(true, didISquishIt);
        }

        [Test]
        public void should_not_be_squished()
        {
            Berry berry = new Berry(true, "purple", "asdf");

            bool didISquishIt = berry.IsTheBerrySquished();

            Assert.AreEqual(false, didISquishIt);
        }
    }
}
