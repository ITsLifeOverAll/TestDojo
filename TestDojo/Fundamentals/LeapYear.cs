namespace TestDojo.Fundamentals
{
    public class LeapYear
    {
        // google: leap year formula 
        // There's a bug in this code. Can you find it?
        
        public bool IsLeapYear(int year) {
            if (year % 4 == 0) return true;
            return false;
        }
    }
}
