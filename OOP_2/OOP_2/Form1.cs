using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Araba araba = new Araba();
        private void Form1_Load(object sender, EventArgs e)
        {
            araba.MotorGucu = 2000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(araba.MotorGucu.ToString());
        }
    }
}
