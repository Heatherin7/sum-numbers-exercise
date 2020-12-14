using NUnit.Framework;
using SumNumbers;

namespace SumNumbersTests
{
	[TestFixture]
	public class SumCalculatorTests
	{
		private SumCalculator _calculator;

		[SetUp]
		public void Setup()
		{
			_calculator = new SumCalculator();
		}

		[Test]
		public void Adds_Numbers()
		{
			var result = _calculator.CalcluateSum(2, 4);
			Assert.AreEqual(6, result);
		}
	}
}