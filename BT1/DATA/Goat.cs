using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class Goat:Animal
    {
        public Goat() { Name = "Goat"; Sound = "Beeee"; }
        public override string Getsound()
        {
            return Sound;
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk = random.Next(0, 10);
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
