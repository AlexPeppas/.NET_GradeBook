using System;
using Xunit;
namespace gradeBook.Tests
{
   
   public class BookValidation {

      [Fact]
      public void StringsBehaveLikeValues(){
      string name ="Alex";
      var upperName = NameToUpper(name);

      Assert.Same("ALEX",upperName);
      }
      private string NameToUpper(string argument){
         return argument.ToUpper();
      }

      [Fact]
      public void checkValues(){
         int x = getInt();
         setInt(x);

         Assert.Equal(3,x);
      }

        private void setInt(int x)
        {
            x=3;
        }

        private int getInt()
        {
            return 4;
        }

        [Fact]
      public void BookValidity (){
         Book book = new Book("First");
         CheckBookValidity(out book,"Second");    

         Assert.Same(book.Name,"Second");      
      }

      private void CheckBookValidity (out Book book, string name){
      book = new Book ("Second");
      }




   }
}
