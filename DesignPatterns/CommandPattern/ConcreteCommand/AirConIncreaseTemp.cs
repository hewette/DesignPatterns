﻿using DesignPatterns.CommandPattern.AbstractCommand;
using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.ConcreteCommand
{
    class AirConIncreaseTemp : ICommand
    {
        AirConditioner AirConditioner;
        public AirConIncreaseTemp(AirConditioner airConditioner)
        {
            this.AirConditioner = airConditioner;
        }

        public void Execute()
        {
            AirConditioner.IncreaseTemp();
        }
    }
}
