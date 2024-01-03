
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace HackerRank.DataStructures.C_.ArrayAndList.Challenge1
{
    [TestFixture]
    public class Challenge1Tests
    {
        [Test]
        public void TestBirthdayCakeCandles()
        {
            List<int> candles = new() { 1, 4, 2, 3 };
            int result = Challenge1.BirthdayCakeCandles( candles );
            ClassicAssert.AreEqual( 1, result );
        }

        [Test]
        public void TestBirthdayCakeCandles2()
        {
            List<int> candles = new() { 1, 4, 2, 3, 4, 3, 4 };
            int result = Challenge1.BirthdayCakeCandles( candles );
            ClassicAssert.AreEqual( 3, result );
        }

        [Test]
        public void TestBirthdayCakeCandles_WithZeroCandles()
        {
            List<int> candles = new() { };
            int result = Challenge1.BirthdayCakeCandles( candles );
            ClassicAssert.AreEqual( 0, result );
        }

        [Test]
        public void TestIsCandleOkay_WithValidCandle()
        {
            int candle = 5;
            bool result = Challenge1.IsCandleOkay( candle );
            ClassicAssert.IsTrue( result );
        }

        [Test]
        public void TestIsCandleOkay_WithInvalidCandle()
        {
            int candle = 15;
            bool result = Challenge1.IsCandleOkay( candle );
            ClassicAssert.IsFalse( result );
        }
    }

}

