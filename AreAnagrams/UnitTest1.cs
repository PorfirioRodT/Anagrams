using NUnit.Framework;

namespace AreAnagrams
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreAnagramas()
        {

            Program anagrams = new Program(); 

            Assert.That(() => anagrams.IsAnAnagram("Juan", "nuja"), Is.True);

        }


    }
}