using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class Cow:Animal
    {
        public Cow(int number) 
        { 
            Name = "Cow";Sound = "Boooo";Number = number;
            Random random = new Random();
            Milk = Number * random.Next(0, 20);
            Child = Number * random.Next(0, 5);
        }
        public Cow() { Name = "Cow"; Sound = "Boooo"; }
        public override string Getsound()
        {
            return Sound;   
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk =Number* random.Next(0, 20);
            return Milk;
        }
        public override int GetChild()
        {
            Random random = new Random();
            Child = Number * random.Next(0, 5)   ;
            return Child;
        }
    }
}
