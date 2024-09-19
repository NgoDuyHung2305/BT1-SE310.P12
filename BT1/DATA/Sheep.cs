using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class Sheep:Animal
    {
        public Sheep(int number) 
        {
            Name = "Sheep"; Sound = "Meeee"; Number = number;
            Random random = new Random();
            Milk = Number * random.Next(0, 5);
            Child = Number * random.Next(0, 5);
        }
        public Sheep() { Name = "Cow"; Sound = "Meeee"; }

        public override string Getsound()
        {
            return Sound;
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk = Number * random.Next(0, 5);
            return Milk;
        }
        public override int GetChild()
        {
            Random random = new Random();
            Child = Number * random.Next(0, 5);
            return Child;
        }
    }
}
