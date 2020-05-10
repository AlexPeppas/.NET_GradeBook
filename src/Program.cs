using System;
using System.Collections.Generic;

namespace gradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Goldman Sachs - The Bank");
            // book.addGrades(77.5);
            // book.addGrades(50.0);
            // book.addGrades(33.9);
            // book.addGrades(99.1);
            // book.addGrades(99.2);
            // book.addGrades(01.105);
            // book.addGrades(20.1);
            // book.addGrades(63.93);
            for (var i=0;i<2;i++){
                Console.WriteLine("Pass an input : \n");
                var input = Console.ReadLine();
                var inputParsed = double.Parse(input);
                try{
                    book.addGrades(inputParsed);
                }
                catch (ArgumentException exe) {
                    //Console.WriteLine(exe.Source);
                    Console.WriteLine(exe.Message); 
                }
                catch (FormatException exe){
                    Console.WriteLine(exe.Message);
                }
                
            }
            Console.WriteLine("Book's Name : " + book.Name);
            //book.Name= "";
            Console.WriteLine("Book's category : " + book.category);

            var stats = book.GetStats();

            Console.WriteLine($"Highest value : {stats.high} , Lowest value : {stats.low} , Average value : {stats.average}");
            Console.WriteLine($"The letter of the average is {stats.letter}");
            


        }
    }
}
