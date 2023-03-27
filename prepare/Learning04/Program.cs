using System;

namespace Inheritance
{


  class Program
  {
    static void Main(string[] args)
    {
      //Inheritance
      Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
      Console.WriteLine(assignment.GetSummary());

      MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
      Console.WriteLine(mathAssignment.GetSummary());
      Console.WriteLine(mathAssignment.GetHomeworkList());


      WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
      Console.WriteLine(writingAssignment.GetSummary());
      Console.WriteLine(writingAssignment.GetWritingInformation());
    }
  }
}