﻿//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace DesignPatterns.DecoratorPattern.ConcreteComponent
{
    public class Chocolate : DesignPatterns.DecoratorPattern.Component.Icecream
    {
        public override double Cost()
        {
            return 2.5;
        }
    }
}
