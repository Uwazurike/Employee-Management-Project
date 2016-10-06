using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    public abstract class Person
    {
        #region varriables
        protected string firstName;
        protected string lastName;
        protected string dateOfBirth;
        protected double sosNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public double SosNumber
        {
            get
            {
                return sosNumber;
            }

            set
            {
                sosNumber = value;
            }
        }
        #endregion
    }
}
