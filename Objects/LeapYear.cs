namespace LeapYear
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      //code will go here
      if (year % 100 == 0) {
        return false;
      } else {
        return year % 4 == 0;
      }
    }
  }
}
