using System;
using VaribleHelper;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Varible_Helpers.ConvertHoursIntoMinutes(-55));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
