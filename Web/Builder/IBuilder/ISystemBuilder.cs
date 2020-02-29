using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Builder.Product;

namespace Web.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        void AddMemory(string memory);
        void AddDrive(string size);
 
        ComputerSystem GetSystem();
    }
}
