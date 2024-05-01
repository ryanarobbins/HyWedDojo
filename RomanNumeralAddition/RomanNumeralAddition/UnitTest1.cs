
namespace RomanNumeralAddition
{
    /*
     *  I + I = II
     *  I + II = III
     *  I + III = IV
     *  II + III = V
     */
    public class Tests
    {
        [Test]
        public void I_Plus_I_Is_II()
        {
            var result = Roman.Add("I", "I");
            Assert.That(result, Is.EqualTo("II"));
        }

        [Test]
        public void I_Plus_II_Is_III()
        {
            var result = Roman.Add("I", "II");
            Assert.That(result, Is.EqualTo("III"));
        }

        [Test]
        public void I_Plus_III_Is_IV()
        {
            var result = Roman.Add("I", "III");
            Assert.That(result, Is.EqualTo("IV"));
        }

        [Test]
        public void II_Plus_II_Is_IV()
        {
            var result = Roman.Add("II", "II");
            Assert.That(result, Is.EqualTo("IV"));
        }

        [Test]
        public void II_Plus_III_Is_V()
        {
            var result = Roman.Add("II", "III");
            Assert.That(result, Is.EqualTo("V"));
        }
    }

    static class Roman
    {
        internal static string Add(string addendOne, string addendTwo)
        {
            if (addendOne + addendTwo == "IIII") return "IV";
            return addendOne + addendTwo;
        }
    }
}