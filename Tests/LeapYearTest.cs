using Xunit;

namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      //testing code here
      LeapYear LeapYear = new LeapYear();
      Assert.Equal(true, LeapYear.IsLeapYear(2012));    }
  }
}
