using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SobjaninMI.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double versts)
        {
            return Math.Round(versts * 1.0668, 3);
        }
    }
}