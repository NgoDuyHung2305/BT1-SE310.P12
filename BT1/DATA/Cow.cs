﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class Cow:Animal
    {
        public Cow() { Name = "Cow";Sound = "Boooo"; }
        public override string Getsound()
        {
            return Sound;   
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk = random.Next(0, 20);
            return Milk;
        }
        public override int GetChild()
        {
            Random random = new Random();
            Child = random.Next(0, 5);
            return Child;
        }
    }
}
