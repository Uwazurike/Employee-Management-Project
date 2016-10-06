using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
   public class Program
    {
        static void Main(string[] args)
        {
            Department myDepartment = new Department();
            myDepartment.DepartmentName = "Production";
            myDepartment.ChangeName("Marketing Department");
            myDepartment.Location = "Southfield, Mi";
            myDepartment.ManagerName = "Calvin Blanc";

            Employee[] array = new Employee [5];

            Employee myEmployee = new Employee();
            myEmployee.FirstName = "Kevin";
            myEmployee.LastName = "Bush";
            myEmployee.FirstNameChange("Bill");
            myEmployee.LastNameChange("Gates");
            myEmployee.DateOfBirth = "10/18/1982";
            myEmployee.SosNumber = 055 - 55 - 5555;
            myEmployee.EmpDepartment = "User Aquisition,";
            myEmployee.PayGrade = 1;
            myEmployee.PayRate = 27;
            myEmployee.HoursWorked = 850;
            myEmployee.DateHired();
            myEmployee.DateTerminated();

            Employee myEmployee2 = new Employee();
            myEmployee2.FirstName = "Kim";
            myEmployee2.LastName = "Bawer";
            myEmployee2.DateOfBirth = "11/18/1984";
            myEmployee2.SosNumber = 035 - 52 - 5655;
            myEmployee2.EmpDepartment = "Senior Developer";
            myEmployee2.PayGrade = 2;
            myEmployee2.PayRate = 50;
            myEmployee2.Promote();
            myEmployee2.HoursWorked = 1850;
            myEmployee2.DateHired();

            Employee myEmployee3 = new Employee();
            myEmployee3.FirstName = "John";
            myEmployee3.LastName = "Bigs";
            myEmployee3.DateOfBirth = "04/18/1987";
            myEmployee3.SosNumber = 045 - 75 - 1575;
            myEmployee3.EmpDepartment = "SoftWare Architect";
            myEmployee3.PayGrade = 3;
            myEmployee3.PayRate = 75;
            myEmployee3.Promote();
            myEmployee3.HoursWorked = 2850;
            myEmployee3.DateHired();

            Employee myEmployee4 = new Employee();
            myEmployee4.FirstName = "Cindy";
            myEmployee4.LastName = "Slade";
            myEmployee4.DateOfBirth = "03/15/1989";
            myEmployee4.SosNumber = 095 - 15 - 1155;
            myEmployee4.EmpDepartment = "Director of Marketing";
            myEmployee4.PayGrade = 3;
            myEmployee4.PayRate = 85;
            myEmployee4.HoursWorked = 4850;
            myEmployee4.DateHired();
            myEmployee4.DateTerminated();

            Employee myEmployee5 = new Employee();
            myEmployee5.FirstName = "Luke";
            myEmployee5.LastName = "Barnes";
            myEmployee5.DateOfBirth = "02/11/1988";
            myEmployee5.SosNumber = 015 - 55 - 3545;
            myEmployee5.EmpDepartment = "Lead developer";
            myEmployee5.PayGrade = 3;
            myEmployee5.PayRate = 95;
            myEmployee5.HoursWorked = 5250;
            myEmployee5.DateHired();

            Console.Title = ("Iyke's Employee Management");
            Console.WriteLine("Welcome To Iyke's Employee Management\n");

            Console.WriteLine("First Name: " + myEmployee.FirstName);
            Console.WriteLine("Last Name: " + myEmployee.LastName);
            Console.WriteLine("D.O.B: " + myEmployee.DateOfBirth);
            Console.WriteLine("SOS#: " + myEmployee.SosNumber);
            Console.WriteLine("Dept: " + myEmployee.EmpDepartment);
            Console.WriteLine("Level: " + myEmployee.PayGrade);
            Console.WriteLine("Wage: " + myEmployee.PayRate);
            Console.WriteLine("Hrs Worked: " + myEmployee.HoursWorked);
            Console.WriteLine("Hired: " + myEmployee.HireDate);
            Console.WriteLine("Fired: " + myEmployee.TerminationDate);
            Console.WriteLine("\n");

            Console.WriteLine("First Name: " + myEmployee2.FirstName);
            Console.WriteLine("Last Name: " + myEmployee2.LastName);
            Console.WriteLine("D.O.B: " + myEmployee2.DateOfBirth);
            Console.WriteLine("SOS#: " + myEmployee2.SosNumber);
            Console.WriteLine("Dept: " + myEmployee2.EmpDepartment);
            Console.WriteLine("Level: " + myEmployee2.PayGrade);
            Console.WriteLine("Wage: " + myEmployee2.PayRate);
            Console.WriteLine("Hrs Worked: " + myEmployee2.HoursWorked);
            Console.WriteLine("Hired: " + myEmployee2.HireDate);
            Console.WriteLine("\n");


            Console.WriteLine("First Name: " + myEmployee3.FirstName);
            Console.WriteLine("Last Name: " + myEmployee3.LastName);
            Console.WriteLine("D.O.B: " + myEmployee3.DateOfBirth);
            Console.WriteLine("SOS#: " + myEmployee3.SosNumber);
            Console.WriteLine("Dept: " + myEmployee3.EmpDepartment);
            Console.WriteLine("Level: " + myEmployee3.PayGrade);
            Console.WriteLine("Wage: " + myEmployee3.PayRate);
            Console.WriteLine("Hrs Worked: " + myEmployee3.HoursWorked);
            Console.WriteLine("Hired: " + myEmployee3.HireDate);
            Console.WriteLine("\n");


            Console.WriteLine("First Name: " + myEmployee4.FirstName);
            Console.WriteLine("Last Name: " + myEmployee4.LastName);
            Console.WriteLine("D.O.B: " + myEmployee4.DateOfBirth);
            Console.WriteLine("SOS#: " + myEmployee4.SosNumber);
            Console.WriteLine("Dept: " + myEmployee4.EmpDepartment);
            Console.WriteLine("Level: " + myEmployee4.PayGrade);
            Console.WriteLine("Wage: " + myEmployee4.PayRate);
            Console.WriteLine("Hrs Worked: " + myEmployee4.HoursWorked);
            Console.WriteLine("Hired: " + myEmployee4.HireDate);
            Console.WriteLine("Fired: " + myEmployee4.TerminationDate);
            Console.WriteLine("\n");

            Console.WriteLine("First Name: " + myEmployee5.FirstName);
            Console.WriteLine("Last Name: " + myEmployee5.LastName);
            Console.WriteLine("D.O.B: " + myEmployee5.DateOfBirth);
            Console.WriteLine("SOS#: " + myEmployee5.SosNumber);
            Console.WriteLine("Dept: " + myEmployee5.EmpDepartment);
            Console.WriteLine("Level: " + myEmployee5.PayGrade);
            Console.WriteLine("Wage: " + myEmployee5.PayRate);
            Console.WriteLine("Hrs Worked: " + myEmployee5.HoursWorked);
            Console.WriteLine("Hired: " + myEmployee5.HireDate);
            Console.WriteLine("\n");

            Console.WriteLine("Recent Activity\n");


            array[0] = myEmployee;
            array[1] = myEmployee2;
            array[2] = myEmployee3;
            array[3] = myEmployee4;
            array[4] = myEmployee5;

            Utils.PayEmployee(array);

            Console.ReadLine();


        }
    }
}
