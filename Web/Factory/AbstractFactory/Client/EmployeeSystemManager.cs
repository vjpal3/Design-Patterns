using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory iComputerFactory;

        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            this.iComputerFactory = iComputerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = iComputerFactory.Brand();
            IProcessor processor = iComputerFactory.Processor();
            ISystemType systemType = iComputerFactory.SystemType();

            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
                systemType.GetSystemType(), processor.GetProcessor());

            return returnValue;

        }
    }
}