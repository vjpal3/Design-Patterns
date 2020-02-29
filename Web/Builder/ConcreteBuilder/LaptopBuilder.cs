using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Builder.IBuilder;
using Web.Builder.Product;

namespace Web.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}