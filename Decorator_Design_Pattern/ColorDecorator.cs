﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m"; // Used ANSI escape code to change the color of text
        }
    }
}
