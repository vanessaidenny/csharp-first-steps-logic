using System;
using Xunit;

namespace Exercises.UnitTests
{
    public class Exercises_CalculatesAge
    {
        [Fact]        
        public void CalculatesAge_Input365_Return1Year()
        {
            DateTime test = DateTime.Today.Subtract(TimeSpan.FromDays(365.2425));
            int result = Exercise.CalculatesAge(test);

            Assert.True(result==1);
        }

        [Fact]
        public void CalculatesAge_Input364_Return0Year()
        {
            DateTime test = DateTime.Today.Subtract(TimeSpan.FromDays(364));
            int result = Exercise.CalculatesAge(test);

            Assert.True(result==0);
        }

        [Fact]
        public void CalculatesAge_InputNegativeDay_Return0()
        {
            DateTime test = DateTime.Today.AddDays(-1);
            int result = Exercise.CalculatesAge(test);

            Assert.True(result==0);
        }
    }
}
