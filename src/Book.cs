using System;
using System.Collections.Generic;
namespace gradeBook
{
    public class Book
    {
        public Book (string name) 
        {
            this.name = name;
            grades = new List<double>();
        }
        public void addGrades (double grade){
            grades.Add(grade);
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
            
            return result;
        }
        private List<double> grades;
        private string name;
    }
}
