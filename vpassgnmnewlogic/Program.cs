using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace vpassgnmnewlogic
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int siblings = 0;

            Console.Write("Please enter no of siblings:\n");
            siblings = Convert.ToInt32(Console.ReadLine());

            DateTime[] bdstore = new DateTime[siblings];


            for (int i = 0; i < siblings; i++)
            {
                Console.WriteLine("Please enter DOB of siblings no {0}:", i + 1);
                bdstore[i] = Convert.ToDateTime(Console.ReadLine());
            }

            Console.WriteLine("------------------******----------------------");


            if (siblings > 0)
            {

                for (int i = 0; i < siblings; i++)
                {

                    DateTime dob = Convert.ToDateTime(bdstore[i]);

                    int years = 0, months = 0, days = 0, balance = 0;


                    TimeSpan totalPeriod;
                    totalPeriod = DateTime.Today.Subtract(dob);


                    years = totalPeriod.Days / 365;


                    balance = totalPeriod.Days - (years * 365);

                    months = balance / 30;
                    balance = balance - (months * 30);
                    days = balance;

                    Console.WriteLine("Age of sibling {0}: {1} years {2} months {3} days.", i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));

                }
            }

            else
            {
                Console.WriteLine("Kindly enter number of siblings greater than 0");
            }

            Console.WriteLine("------------------*******----------------------");


            if (bdstore != null)
            {

                for (int i = 0; i < siblings; i++)
                {
                    int years = 0, months = 0, days = 0, balance = 0;

                    DateTime dob1 = Convert.ToDateTime(bdstore[i]);


                    if (i > 0)
                    {
                        DateTime dob2 = Convert.ToDateTime(bdstore[i - 1]);
                        TimeSpan TotalPeriod;
                            TotalPeriod = dob2.Subtract(dob1);
                        years = TotalPeriod.Days / 365;
                        balance = TotalPeriod.Days - (years * 365);
                        months = balance / 30;
                        balance = balance - (months * 30);
                        days = balance;

                        Console.WriteLine("Difference between sibling {0} and {1} : {2} years {3} months {4} days.", i, i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));
                    }
                }
            }
            else
            {
                Console.WriteLine(" You have no siblings. ");
            }
            Console.ReadKey();
        }
    }

}




