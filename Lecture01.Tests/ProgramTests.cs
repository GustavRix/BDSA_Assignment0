using System;
using Xunit;
using System.IO;

namespace Lecture01.Tests
{
     public class ProgramTests
    {
       /* [Fact]
        public void Main_given_leap_and_year_returnsboolyay()
        {
           
            var textWriter = new StringWriter();
            Console.SetOut(textWriter);
            var testVsThisString = "yay";
            var array = new [] {"leap","2020"};
            Program.Main(array);
            var result = textWriter.GetStringBuilder().ToString().Trim();
            Assert.Equal(testVsThisString, result);
        }*/
        [Fact]
        public void Main_given_leap_and_year_returnsboolyay()
        {
           
            var textWriter = new StringWriter();
            Console.SetOut(textWriter);
            var testVsThisString = "yay";
            var array = new [] {"2020"};
            Program.Main(array);
            var result = textWriter.GetStringBuilder().ToString().Trim();
            Assert.Equal(testVsThisString, result);
        }
         [Fact]
        public void Main_given_leap_and_year_returnsboolnay()
        {
           
            var textWriter = new StringWriter();
            Console.SetOut(textWriter);
            var testVsThisString = "nay";
            var array = new [] {"2019"};
            Program.Main(array);
            var result = textWriter.GetStringBuilder().ToString().Trim();
            Assert.Equal(testVsThisString, result);
        }
         [Fact]
        public void Main_given_bad_arguments_prints_help()
        {
             var textWriter = new StringWriter();
               Console.SetOut(textWriter);
            var testVsThisString = "Your current input is not valid.";
            var array = new [] {"test"};
            Program.Main(array);
            var result = textWriter.GetStringBuilder().ToString().Trim();
            Assert.Equal(testVsThisString, result);
        }
    }
}
