using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Builder.IBuilder;
using Web.Builder.Product;

namespace Web.Builder.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }

        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}