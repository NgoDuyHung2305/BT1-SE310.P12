using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class Animal
    {
        public Animal() { }
        public string Name { get; set; } 
        public int Number { get; set; }
        public string Sound { get; set; }
        public int Milk { get; set; }
        public int Child { get; set; }
        public virtual string Getsound() { return Sound; }
        public virtual int GetNumber() { return Number; }
        public virtual int GetMilk() { return Milk; }
        public virtual int GetChild() { return Child; }

    }
}
