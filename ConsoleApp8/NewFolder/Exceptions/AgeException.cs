﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.NewFolder.Exceptions
{
    public class AgeException:Exception
    {
        public AgeException()
        {
        }

        public AgeException(string message) : base(message) 
        { 

        }
    }
}
