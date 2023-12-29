using Xunit;
using Allure.Xunit;
using Allure.Commons;
using Allure.Xunit.Attributes;
using Calc;
namespace Test
{
    [Collection("MyCollection")]
    public class UnitTest1
    {
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("ucsmdeeeee")]
        [Xunit.Fact]
        public void Equation()
        {
            Form2 form = new Form2();
            double a = 1;
            double b = 4;
            double c = 4;
            double expected = 2;
            double result = form.Equation(a, b, c);
            Xunit.Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("ucsmdeeeee")]
        [Fact]
        public void Average()
        {
            Form1 form = new Form1();
            double a = 10;
            double b = 20;
            double expected = 15;
            double result = form.Average(a, b);
            Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("ucsmdeeeee")]
        [Fact]
        public void Sqrt()
        {
            Form1 form = new Form1();
            double a = 4;
            double expected = 2;
            double result = form.Sqrt(a);
            Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("ucsmdeeeee")]
        [Fact]
        public void PI()
        {
            Form1 form = new Form1();
            double expected = Math.PI;
            double result = form.PI();
            Assert.Equal(expected, result);
        }
    }
}