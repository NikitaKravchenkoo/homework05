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
                Console.WriteLine(ArrayHelper.GetMinElement());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
