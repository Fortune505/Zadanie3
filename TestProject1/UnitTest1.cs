namespace TestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        [Test]
        public void GetEncryptedTextTest()
        {
            string text = "Ћетит муха";
            string expectedResult = "Ћетит слон";
            string encryptedText = Logic.GetEncryptedText(text);

            Assert.That(encryptedText, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetEncryptedTextTestWithoutFlies()
        {
            string text = "Ћетит кто-то в две башни";
            string expectedResult = "Ћетит кто-то в две башни";
            string encryptedText = Logic.GetEncryptedText(text);

            Assert.That(encryptedText, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetEncryptedTextNoText()
        {
            string text = null;
            string expectedResult = "";
            string encryptedText = Logic.GetEncryptedText(text);

            Assert.That(encryptedText, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetEncryptedTextTestLotFlies()
        {
            string text = "муха, муха, муха, муха, комар!";
            string expectedResult = "слон, слон, слон, слон, комар!";
            string encryptedText = Logic.GetEncryptedText(text);

            Assert.That(encryptedText, Is.EqualTo(expectedResult));
        }
    }
}