using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    public class Employee : Person
    {
        #region Variables
        private DateTime hireDate;
        private DateTime terminationDate;
        private int payRate;
        private int payGrade;
        private int hoursWorked;
        private string empDepartment;
        #endregion

        #region Properties

        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }

            set
            {
                hireDate = value;
            }
        }

        public DateTime TerminationDate
        {
            get
            {
                return terminationDate;
            }

            set
            {
                terminationDate = value;
            }
        }

        public int PayRate
        {
            get
            {
                return payRate;
            }

            set
            {
                payRate = value;
            }
        }

        public int PayGrade
        {
            get
            {
                return payGrade;
            }

            set
            {
                payGrade = value;
            }
        }

        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }

            set
            {
                hoursWorked = value;
            }
        }

        public string EmpDepartment
        {
            get
            {
                return empDepartment;
            }

            set
            {
                empDepartment = value;
            }
        }

        #endregion

        public void FirstNameChange(string firstName2)
        {
            this.firstName = firstName2;
        }

        public void LastNameChange(string lastName2)
        {
            this.lastName = lastName2;
        }

        public void DateHired()
        {
             hireDate = DateTime.Today.AddYears(-1);
        }

        public void DateTerminated()
        {
            terminationDate = DateTime.Today;
        }

        public void Promote()
        {
            payGrade++;
            payRate = payRate+(payRate*4/100);
        }
    }
}

