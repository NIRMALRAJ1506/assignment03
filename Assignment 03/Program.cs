using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a String");
                string s1 = Console.ReadLine();
                if (int.TryParse(s1, out int i))
                {
                    Console.WriteLine("Converted Integer " + i);
                }
                else
                {
                    Console.WriteLine("Conversion failed Wrong String Type");
                }

                Console.WriteLine("Enter a String");
                string s2 = Console.ReadLine();
                double d = Convert.ToDouble(s2);
                Console.WriteLine("Converted double " + d);

                Console.WriteLine("Enter a String");
                string s3 = Console.ReadLine();
                decimal d1 = decimal.Parse(s3);
                Console.WriteLine("Converted decimal " + d1);

                Console.WriteLine("Enter a String");
                string s4 = Console.ReadLine();
                if (int.TryParse(s4, out int a))
                {
                    Console.WriteLine("Converted Integer " + a * 5);

                }
                else
                {
                    Console.WriteLine("Conversion Failed Wrong String Type");
                }

                Console.WriteLine("Enter a String");
                string s5 = Console.ReadLine();
                DateTime b = Convert.ToDateTime(s5);
                b = b.AddMonths(-1);
                Console.WriteLine("Converted date " + b);

                Console.WriteLine("Enter a String");
                string s6 = Console.ReadLine();
                TimeSpan c = TimeSpan.Parse(s6);
                TimeSpan t1 = TimeSpan.FromHours(2);
                c = c.Add(t1);
                Console.WriteLine("Converted TimeSpan " + c);




            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured!!!" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
