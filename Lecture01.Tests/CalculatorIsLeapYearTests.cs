using System;
using Xunit;

namespace Lecture01.Tests
{
    public partial class CalculatorTests
    {

    
        [Fact]
        public void IsLeapYear_before_1582()
        {
             /* */
             Assert.Throws<ArgumentException>(() => Calculator.IsLeapYear(1581));
        }
        [Fact]
        public void IsLeapYear_after_9999()
        {
             Assert.Throws<ArgumentException>(() => Calculator.IsLeapYear(10000));
        }
        [Fact]
        public void IsLeapYear_dvisible_by_4()
        {
             Assert.True(Calculator.IsLeapYear(2020));
        }
        
        [Fact]
        public void IsLeapYear_isnt_divisible_by_4()
        {
             Assert.False(Calculator.IsLeapYear(2021));
        }

        [Fact]
        public void IsLeapYear_isnt_divisible_by_100()
        {
             Assert.True(Calculator.IsLeapYear(2020));
        }

        [Fact]
        public void IsLeapYear_isnt_divisible_by_400()
        {
             Assert.False(Calculator.IsLeapYear(2021));
        }
    }
}