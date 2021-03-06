using System;
using Xunit;
namespace gradeBook.Tests
{
    public class bookTest
    {
        [Fact]
        public void Test1()
        {
        //arrange
           var book = new Book("");
           book.addGrades(81.2);
           book.addGrades(71.2);
           book.addGrades(61.2);
           book.addGrades(51.2);
           book.addGrades(20.0);

        //act   
           var testStats = book.GetStats();

        //assert
           Assert.Equal(57,testStats.average,1);
           Assert.Equal(81.2,testStats.high);
           Assert.Equal(20.0,testStats.low);

        }
    }
}
