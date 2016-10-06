using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    public static class Utils
    {
        public static void PayEmployee(Employee[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].TerminationDate == DateTime.Today)
                {
                    Console.WriteLine((array[i].FirstName) + " Was Terminated!");
                    Console.WriteLine(" \n");

                }
                else
                {
                    Console.WriteLine(array[i].FirstName + " has been paid. " + "$" + array[i].PayRate * array[i].HoursWorked);
                    Console.WriteLine("\n");
                    
                }
            }

        }


    }
}

