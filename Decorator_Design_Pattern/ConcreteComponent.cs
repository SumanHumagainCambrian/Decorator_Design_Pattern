﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Concrete Component.";
        }
    }
}
