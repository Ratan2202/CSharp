using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers=new[] {10.23,9.77,10.50};
            
            double result=0;
            double avg=0;

            foreach (var item in numbers)
            {
                result=result+item;
            }
            Console.WriteLine(result);
            result=0;


            List<double> grade=new List<double>();

            grade.Add(56.69);
            grade.Add(69.69);
            grade.Add(100.05);

            foreach (var item in grade)
            {
                result+=item;
            }  
            
            System.Console.WriteLine(result);
            avg=result/grade.Count;

            System.Console.WriteLine($"Average Grade is = {avg:N2}");


            // String interpolation
            if (args.Length>0 )
            {
                 Console.WriteLine($"Hello, {args[0]}  !");
            }
            else
            {
                 Console.WriteLine("Hello  !");
            }
           
        }
    }
}
