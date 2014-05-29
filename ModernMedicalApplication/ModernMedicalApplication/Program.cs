using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernMedicalApplication
{
    class Program
    {
         
        static void Main(string[] args)
        {
            try
            {

                foreach (var val in Enumerable.Range(1, 100).Select(n => Calculate(n)))
                    Console.WriteLine(val);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }

        static private string Calculate(int value)
        {
            if (value % 15 == 0)
            {
                return "ModernMedical";
            }
            if (value % 3 == 0)
            {
                return "Modern";
            }
            if (value % 5 == 0)
            {
                return "Medical";
            }
            return value.ToString();
        }
    }
}
