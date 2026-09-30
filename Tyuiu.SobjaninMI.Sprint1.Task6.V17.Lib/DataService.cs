using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SobjaninMI.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string reversed = new string(value.Reverse().ToArray());
            return value == reversed;
        }
    }
}