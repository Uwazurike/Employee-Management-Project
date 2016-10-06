using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    public class Department
    {
        #region varriables
        private string departmentName;
        private string managerName;
        private string location;
        #endregion

        #region properties

        public string ManagerName
        {
            get
            {
                return managerName;
            }

            set
            {
                managerName = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }
        #endregion
        public void ChangeName(string departmentName2)
        {
            this.departmentName = departmentName2;
        }
    }
}
