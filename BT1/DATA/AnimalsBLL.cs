using BT1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DATA
{
    public class AnimalsBLL
    {
        private AnimalsBLL() { }
        private static AnimalsBLL instance;
        public static AnimalsBLL Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new AnimalsBLL();
                }
                return instance;
            }

        }
        public int CountMilkCow()
        {
            int count = Animal_Access.Instance.CountMilkCow();
            return count;
        }
        public int CountMilkSheep()
        {
            int count = Animal_Access.Instance.CountMilkSheep();
            return count;
        }
        public int CountMilkGoat()
        {
            int count = Animal_Access.Instance.CountMilkGoat();
            return count;
        }
        public int CountChildGoat()
        {
            int count = Animal_Access.Instance.CountChildGoat();
            return count;
        }
        public int CountChildCow()
        {
            int count = Animal_Access.Instance.CountChildCow();
            return count;
        }
        public int CountChildSheep()
        {
            int count = Animal_Access.Instance.CountChildSheep();
            return count;
        }

        public void Delete()
        {
            Animal_Access.Instance.Reset();
        }
        public void Insert(int num, int child, int milk, string name)
        {
            Animal_Access.Instance.Insert(num, child, milk, name);
        }
    }
}
