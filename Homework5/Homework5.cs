using System;
using HomeworkHelper;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(CyclesHelper.GetLargestDivisorOfA(10));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
