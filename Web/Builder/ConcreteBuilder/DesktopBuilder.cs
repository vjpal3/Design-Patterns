﻿using System;
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
        public ISystemBuilder AddDrive(string size)
        {
            desktop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            desktop.RAM = memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            desktop.Mouse = type;
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}