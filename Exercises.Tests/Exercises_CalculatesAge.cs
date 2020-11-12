using System;
using Xunit;

namespace Exercises.UnitTests
{
    public class Exercises_CalculatesAge
    {
        DateTime dateNow = DateTime.Now;
        
        [Fact]        
        public void CalculatesAge_Input365_Return1Year()
        {
            DateTime test = DateTime.Today.Subtract(TimeSpan.FromDays(365.2425));       
            Assert.Equal(1, Exercise.CalculatesAge(test));
        }

        [Fact]
        public void CalculatesAge_Input364_Return0Year()
        {
            DateTime test = DateTime.Today.AddDays(-1);
            Assert.Equal(0, Exercise.CalculatesAge(test));
        }

        [Fact]
        public void CalculatesAge_InputNegativeDay_Return0()
        {
            DateTime test = DateTime.Today.AddDays(1);
            Assert.Equal(0, Exercise.CalculatesAge(test));
        }
    }
}
