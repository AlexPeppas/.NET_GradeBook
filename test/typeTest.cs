using System;
using Xunit;
namespace gradeBook.Tests
{
    public class bookType
    {
       
        [Fact]
        public void BookNameByRef()
        {
            var book1 = GetBook("Tolkin");
            SetNameByRef(ref book1,"LOTR");
            //Assert (Expected,Actual)
            Assert.Equal("LOTR",book1.Name);
        }

        private void SetNameByRef(ref Book book1, string name)
        {
            book1 = new Book(name); //constructing a new one, fails.
        }

        [Fact]
        public void BookNameByValue()
        {
            var book1 = GetBook("Tolkin");
            SetNameByValue(book1,"LOTR");
            //Assert (Expected,Actual)
            Assert.Equal("LOTR",book1.Name);
            
        }

        private void SetNameByValue(Book book1, string name)
        {
            book1 = new Book(name); //constructing a new one, fails.
            book1.Name = name ; //forcefully fails too.
        }
        [Fact]
        public void BookName()
        {
            var book1 = GetBook("Tolkin");
            SetName(book1,"LOTR");
            //Assert (Expected,Actual)
            Assert.Equal("LOTR",book1.Name);
            
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        [Fact]
        public void TypeTest()
        {
            var book1 = GetBook("Tolkin");
            var book2 = GetBook("SteveJobs");

            //Assert (Expected,Actual)
            Assert.Equal("Tolkin",book1.Name);
            Assert.Equal("SteveJobs",book2.Name);
        }
        [Fact]
        public void canTwoVariablesPointToTheSameObject()
        {
            var book1 = GetBook("Tolkin");
            var book2 = book1;

            Assert.Same(book2,book1);
            Assert.True(Object.ReferenceEquals(book1,book2));
        }
        Book GetBook(string name){
           return new Book(name);
        }
    }
}
