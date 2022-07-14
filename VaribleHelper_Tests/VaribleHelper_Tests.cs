using HomeworkHelper;
using NUnit.Framework;

namespace VaribleHelper_Tests
{
    public class Tests
    {
        [TestCase(1,60)]
        [TestCase(2, 120)]
        public void ConvertHoursIntoMinutes_WhenHoursNotZero_ShouldConversHoursInMinutes(int hours, int expected)
        {
            var actual = Varible_Helpers.ConvertHoursIntoMinutes(hours);

            Assert.AreEqual(expected, actual);
        }
    }
}
