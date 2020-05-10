using System;
using System.Collections.Generic;
namespace gradeBook
{
    public class Book
    {
        public Book (string nameValue) 
        {
            Name = nameValue;
            grades = new List<double>();
                   
        }
        public void addGrades (double grade){
           if (grade <= 100.0)
           {
            grades.Add(grade);
           }
           else{
               throw new ArgumentException($"Invalid grade : {grade}");
           }
        }
        public Statistics GetStats (){ 
            var result = new Statistics();
            // var min = double.MaxValue;
            result.low = double.MaxValue;
            // var max = double.MinValue;
            result.high = double.MinValue;
            result.average = 0.0;
            
            foreach (double grade in grades){
                //max = Math.Max(max,grade);
                result.high = Math.Max(result.high,grade);
                result.low = Math.Min(result.low,grade);
                result.average += grade;
                
            }
            result.average /= grades.Count;
            
            switch (result.average){
                case var d when d>=90.0 :
                    result.letter = 'A';
                    break;
                case var d when d>=80.0:
                    result.letter = 'B';
                    break;
                case var d when d>=70.0:
                    result.letter = 'C';
                    break;
                default :
                    result.letter = 'F';
                    break;        
            }
            return result;
        }
        private List<double> grades;
        public string Name{
            get;
            private set;    
        }
        public readonly string category = "Science";
    }
}
