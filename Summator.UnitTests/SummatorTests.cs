using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2 };
            var expected = 3;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumber()
        {
            var nums = new int[] { -1, -99 };
            var expected = -100;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var nums = new int[] { 6 };
            var expected = 6;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumZeroNumber()
        {
            var nums = new int[] { };
            var expected = 0;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var expected = 6000000000;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumOnePositiveAndOneNegative()
        {
            var nums = new int[] { 5, -3 };
            var expected = 2;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumOnePositiveAndTwoNegative()
        {
            var nums = new int[] { 5, -3, -2 };
            var expected = 0;

            var actual = Summator.Sum(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AveragePositiveNumbers()
        {
            var nums = new int[] { 5, 10, 15 };
            var expected = 10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageNegativeNumbers()
        {
            var nums = new int[] { -5, -10, -15 };
            var expected = -10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageTwoNumbers()
        {
            var nums = new int[] { 5, 15 };
            var expected = 10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageBigNumbers()
        {
            var nums = new int[] { 1000000, 1500000 };
            var expected = 1250000;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }
        public void Test_Summator_AverageBigNegativeNumbers()
        {
            var nums = new int[] { -1000000, -1500000 };
            var expected = -1250000;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}