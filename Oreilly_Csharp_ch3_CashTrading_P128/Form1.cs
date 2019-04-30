using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter3_cash
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            banksCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            bob = new Guy()
            {
                Name = "Bob",
                Cash = 100
            };

            joe = new Guy()
            {
                Name = "joe",
                Cash = 50
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            bank += joe.GiveCash(5);
            UpdateForm();
        }
    }
}