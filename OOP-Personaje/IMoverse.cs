﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal interface IMoverse
    {
        public void MoverseEjeX(int amount);
        public void MoverseEjeY(int amount);
    }
}
