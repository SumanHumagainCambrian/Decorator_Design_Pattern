﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return $"Test- {base.GetText()}"; // added prefix
        }
    }

}
