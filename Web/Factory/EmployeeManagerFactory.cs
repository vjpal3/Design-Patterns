using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager result = null;
            if (employeeTypeId == 1)
            {
                result = new PermanentEmployeeManager();
            }
            else if(employeeTypeId == 2)
            {
                result = new ContractEmployeeManager();
            }
            return result;
        }
    }
}