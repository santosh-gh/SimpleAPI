using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            var returnvalue =   controller.Get();
            Assert.Equal("Santosh", "Santosh");

        }
    }
}
