using BT1.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSound_Click(object sender, EventArgs e)
        {
            Cow cow = new Cow();
            Sheep sheep = new Sheep();
            Goat goat = new Goat();
            string sound = "";
            if (Convert.ToInt32(Goattxt.Text) > 0)
            {
                sound +=   goat.Getsound();
            }
            if (Convert.ToInt32(Sheeptxt.Text) > 0)
            {
                sound +=  sheep.Getsound();
            }
            if (Convert.ToInt32(Cowtxt.Text) > 0)
            {
                sound +=  cow.Getsound();
            }

            MessageBox.Show("When Animal hungry: \n" + sound);

        }

        private void BtnMilk_Click(object sender, EventArgs e)
        {
            int countCow = AnimalsBLL.Instance.CountMilkCow();
            int countSheep = AnimalsBLL.Instance.CountMilkSheep();
            int countGoat = AnimalsBLL.Instance.CountMilkGoat();
            MessageBox.Show(" Amount milk of Cows is: " + countCow);
            MessageBox.Show(" Amount milk of Sheep is: " + countSheep);
            MessageBox.Show(" Amount milk of Goat is: " + countGoat);
        }

        private void BtnChild_Click(object sender, EventArgs e)
        {
            int countCow = AnimalsBLL.Instance.CountChildCow();
            int countSheep = AnimalsBLL.Instance.CountChildSheep();
            int countGoat = AnimalsBLL.Instance.CountChildGoat();
            MessageBox.Show(" Numbers Child of Cows is: " + countCow);
            MessageBox.Show(" Numbers Child of Sheep is: " + countSheep);
            MessageBox.Show(" Numbers Child of Goat is: " + countGoat);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Kiểm tra nhập liệu cho Cow
            if (int.TryParse(Cowtxt.Text, out int numCow))
            {
                Cow cow = new Cow(numCow);
                AnimalsBLL.Instance.Insert(numCow, cow.Child, cow.Milk, "Cow");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for cows.");
            }

            // Kiểm tra nhập liệu cho Sheep
            if (int.TryParse(Sheeptxt.Text, out int numSheep))
            {
                Sheep sheep = new Sheep(numSheep);
                AnimalsBLL.Instance.Insert(numSheep, sheep.Child, sheep.Milk, "Sheep");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for sheep.");
            }

            // Kiểm tra nhập liệu cho Goat
            if (int.TryParse(Goattxt.Text, out int numGoat))
            {
                Goat goat = new Goat(numGoat);
                AnimalsBLL.Instance.Insert(numGoat, goat.Child, goat.Milk, "Goat");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for goats.");
            }
        }

    }
}
