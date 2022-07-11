using System;

namespace HomeworkHelper
{
    public class Varible_Helpers
    {
        public static int ConvertHoursIntoMinutes(int hours)
        {
            if (hours <= 0)
            {
                throw new ArithmeticException("Numbers under 0 cannot convert in minutes");
            }
            return hours * 60;
        }
        public static float CalculateFormula(int a, int b)
        {
            if ((b - a) == 0)
            {
                throw new ArithmeticException("Cannot delete on zero!");
            }

            return (float)(5 * a + b * b) / (b - a);
        }

        public static (int a, int b) Swap_a_and_b(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (double dividing, double divisionRemainder) CalculateDividingAndDivisionRemainder(double a, double b)
        {
            if (b == 0)
            {
                throw new ArithmeticException("Cannot delete on zero!");
            }

            double dividing = a / b;
            double divisionRemainder = a % b;

            return (dividing, divisionRemainder);
        }

        public static double CalculateExpressionByFormula(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArithmeticException("Cannot delete on zero!");
            }

            return c - b / a;
        }

        public static (float a, float b) GetLineEquation(float x1, float y1, float x2, float y2)
        {
            if ((x1 - x2) == 0)
            {
                throw new ArithmeticException("Cannot delete on zero!");
            }

            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;

            return (a, b);
        }

        public static int GetSummOfInputBySymbol(int userValue)
        {
            int firstNumber = userValue / 10;
            int secondNumber = userValue % 10;

            if (firstNumber >= 10)
            {
                throw new ArgumentOutOfRangeException("To long or to short value!");
            }

            return firstNumber + secondNumber;
        }
    }

    public class NumbersHelper
    {
        public static int CalculateTheResult(int a, int b)
        {
            int result = a;

            if (a > b)
            {
                result += b;
            }
            else if (a == b)
            {
                result *= b;
            }
            else
            {
                result -= b;
            }

            return result;
        }

        public static int FindQuaterWithYAndX(int x, int y)
        {

            if (x == 0 || y == 0)
            {
                throw new ArgumentException("You are in the center of the quaters");
            }

            int result;

            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;
        }

        public static (int smalest, int medium, int bigest) PrintFromSmalesToBigest(int a, int b, int c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }

            if (a > c)
            {
                Swap(ref a, ref c);
            }

            if (b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        public static (double x1, double x2) PrintTheSolutionOfQuatricEcuetion(float a, float b, float c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double sqrtOfDiscriminant = Math.Sqrt((b * b) - (4 * a * c));

            if (double.IsNaN(sqrtOfDiscriminant))
            {
                throw new ArgumentException("Discriminant cannot be less then zero!");
            }

            if (sqrtOfDiscriminant >= 0)
            {
                x1 = (-b + sqrtOfDiscriminant) / (2 * a);
                x2 = (-b - sqrtOfDiscriminant) / (2 * a);
            }

            return (x1, x2);
        }

        public static string PrintNumberCapitalization(int userInput)
        {
            int firstNumber = userInput / 10;
            int secondNumber = userInput % 10;

            if (firstNumber >= 10 || userInput <= 0)
            {
                throw new ArgumentException("Input is out of range!");
            }

            if (firstNumber != 1)
            {
                return GetDozens(firstNumber) + GetUnits(secondNumber);
            }
            else
            {
                return GetExeptionalNumbers(secondNumber);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static string GetDozens(int firstNumber)
        {
            string result = string.Empty;
            switch (firstNumber)
            {
                case 2:
                    result = "Twenty";
                    break;
                case 3:
                    result = "Thirty";
                    break;
                case 4:
                    result = "Fourty";
                    break;
                case 5:
                    result = "Fifty";
                    break;
                case 6:
                    result = "Sixty";
                    break;
                case 7:
                    result = "Seventy";
                    break;
                case 8:
                    result = "Eighty";
                    break;
                case 9:
                    result = "Ninety";
                    break;
            }

            return result;
        }

        private static string GetUnits(int secondNumber)
        {
            string result = string.Empty;
            switch (secondNumber)
            {
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
            }

            return result;
        }

        private static string GetExeptionalNumbers(int secondNumber)
        {
            string result = string.Empty;
            switch (secondNumber)
            {
                case 0:
                    result = "Ten";
                    break;
                case 1:
                    result = "Eleven";
                    break;
                case 2:
                    result = "Twelve";
                    break;
                case 3:
                    result = "Thirteen";
                    break;
                case 4:
                    result = "Fourteen";
                    break;
                case 5:
                    result = "Fifteen";
                    break;
                case 6:
                    result = "Sixteen";
                    break;
                case 7:
                    result = "Seventeen";
                    break;
                case 8:
                    result = "Eighteen";
                    break;
                case 9:
                    result = "Nineteen";
                    break;
            }

            return result;
        }
    }

    public class CyclesHelper
    {
        public static int RaiseAToPowerB(int a, int b)
        {
            int result = a;

            for (int i = 1; i < b; i++)
            {
                sum *= number;
            }

            return result;
        }

        public static int GetLessSquareFromA(int a)
        {
            int result = 1;

            for (; result * result < a; ++result)
            {
            }

            return --result;
        }

        public static int GetLargestDivisorOfA(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Number is less or equal to 0");
            }

            int result = default;

            for (int i = a / 2; i > 1; i--)
            {
                if (a % 1 == 0)
                {
                    result += i;
                    break;
                }
            }

            return result;
        }

        public static int GetSummOfRangeDivisibleBySeven(int a, int b)
        {
            if (b < a)
            {
                Swap(ref a, ref b);
            }

            int result = default;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int GetElementOfFibboSeries(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Number is less or equal to 0");
            }

            int a = 1;
            int b = 1;

            for (int i = 1; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public static int GetGreatestDivisiorByEuclid(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a + b;
        }

        public static double GetNumberByBinaryAlgorithm(double a)
        {

            double n = default;
            int min = 1;
            double temp = a;

            while (min <= a)
            {
                double mid = a / 2;
                double cubicValue = mid * mid * mid;
                if (cubicValue > temp)
                {
                    a = mid;
                    continue;
                }
                else if (cubicValue < temp)
                {
                    ++a;
                    continue;
                }
                else
                {
                    n = mid;
                    break;
                }
            }

            return n;
        }

        public static int GetNumberOfOddDigits(int number)
        {
            int count = 0;

            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    count++;
                }

                number /= 10;
            }

            return count;
        }

        public static int ReverseNumber(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public static bool VerifySameDigits(int firstNumber, int secondNumber)
        {
            bool result = false;
            string firstInput = Convert.ToString(firstNumber);
            string secondInput = Convert.ToString(secondNumber);

            for (int i = 0; i < firstInput.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (firstInput[i] == secondInput[j])
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
