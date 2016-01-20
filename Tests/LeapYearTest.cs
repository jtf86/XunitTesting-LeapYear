using Xunit;
using Xunit.Abstractions;

namespace LeapYear
{
    public class LeapYearTest
    {
        private readonly ITestOutputHelper output;

        public LeapYearTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void IsLeapYear_ForNumberDivisibleByFour_true()
        {
            //testing code here
            LeapYear LeapYear = new LeapYear();

            var year = 80;
            var result = LeapYear.IsLeapYear(year);
            output.WriteLine("The result of the expression with " + year + " was " + result.ToString());

            Assert.Equal(true, LeapYear.IsLeapYear(2012));
        }

        [Fact]
        public void IsLeapYear_ForNumberNotDivisibleByFour_false()
        {
            LeapYear LeapYear = new LeapYear();
            Assert.Equal(false, LeapYear.IsLeapYear(1999));
        }

        [Fact]
        public void IsLeapYear_ForMultiplesOfOneHundred_false()
        {
            LeapYear LeapYear = new LeapYear();
            Assert.Equal(false, LeapYear.IsLeapYear(1900));
        }

        [Fact]
        public void IsLeapYear_ForMultiplesOfFourHundred_true()
        {
            LeapYear LeapYear = new LeapYear();
            Assert.Equal(true, LeapYear.IsLeapYear(2000));
        }

    }
}
