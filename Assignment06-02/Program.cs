using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList()
            {
                85,
                92,
                78,
                95,
                88,
            };
            int sum = 0;
            Console.WriteLine("The Student's grades are");
            foreach (int item in studentGrades)
            {
                Console.WriteLine(item);
                sum += item;
            }
            Console.WriteLine("The sum of the grades: "+sum);

            studentGrades.Add(90);
            Console.WriteLine("The Student's updated grades after adding \'90\' are");
            foreach (int item in studentGrades)
            {
                Console.WriteLine(item);
            }

            studentGrades.Remove(78);
            Console.WriteLine("The Student's updated grades after removing \'78\' are");
            foreach (int item in studentGrades)
            {
                Console.WriteLine(item);
            }

            int pos = studentGrades.IndexOf(95);
            studentGrades[pos] = 96;
            Console.WriteLine("The Student's updated grades after updating \'95\' to \'96\' are");
            foreach (int item in studentGrades)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
