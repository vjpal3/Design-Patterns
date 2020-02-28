using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee emp;
        public BaseEmployeeFactory(Employee emp)
        {
            this.emp = emp;
        }

        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            emp.Bonus = manager.GetBonus();
            emp.HourlyPay = manager.GetPay();
            return emp;
        }
    }

}