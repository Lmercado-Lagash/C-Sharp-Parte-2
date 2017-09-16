﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Logger
    {
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += (sender, e) =>
            {
                Console.WriteLine("Logging event at {0}:{1}:{2}", e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
            };
        }

        
    }
}
