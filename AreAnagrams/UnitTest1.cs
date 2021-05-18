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

        [Test]
        public void AreNotAnagramas()
        {

            Program anagrams = new Program(); 

            Assert.That(() => anagrams.IsAnAnagram("Juan", "pedro"), Is.False /* Throws.Nothing*/);

        }

        [Test]
        public void FirstAnagramWordIsNull()
        {

            Program anagrams = new Program(); 

            Assert.That(() => anagrams.IsAnAnagram(null, "pedro"), Throws.ArgumentNullException);

        }

        [Test]
        public void SecondAnagramWordIsNull()
        {

            Program anagrams = new Program(); 

            Assert.That(() => anagrams.IsAnAnagram("pedro", null), Throws.ArgumentNullException);

        }

        [Test]
        public void BothAnagramWordsAreNull()
        {

            Program anagrams = new Program(); 

            Assert.That(() => anagrams.IsAnAnagram(null, null), Throws.ArgumentNullException);

        }


    }
}