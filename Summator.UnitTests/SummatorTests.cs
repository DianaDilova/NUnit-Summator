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
            var nums = new double[] { 5, 10, 15 };
            var expected = 10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageNegativeNumbers()
        {
            var nums = new double[] { -5, -10, -15 };
            var expected = -10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageTwoNumbers()
        {
            var nums = new double[] { 5, 15 };
            var expected = 10;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageBigNumbers()
        {
            var nums = new double[] { 1000000, 1500000 };
            var expected = 1250000;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageBigNegativeNumbers()
        {
            var nums = new double[] { -1000000, -1500000 };
            var expected = -1250000;

            var actual = Summator.Average(nums);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_AverageThreeBigNumbers()
        {
            var nums = new double[] { 100000.5, 150000.5, 150000.5 };
            var expected = 133333.83333333334;

            var actual = Summator.Average(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_MultiplyTwoNumbers()
        {
            var nums = new double[] { 100, 200 };
            var expected = 20000;

            var actual = Summator.Multiply(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_MultiplyTwoNegativeNumbers()
        {
            var nums = new double[] { -2, -5 };
            var expected = 10;

            var actual = Summator.Multiply(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_MultiplyOneNegativeOnePositive()
        {
            var nums = new double[] { -2.5, 5 };
            var expected = -12.5;

            var actual = Summator.Multiply(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_MultiplyOneNumber()
        {
            var nums = new double[] { 5.5 };
            var expected = 5.5;

            var actual = Summator.Multiply(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_MultiplyEmptyArray()
        {
            var nums = new double[] { };
            var expected = 0;

            var actual = Summator.Multiply(nums);


            Assert.That(expected, Is.EqualTo(actual));
        }

    }
}