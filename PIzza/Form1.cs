using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIzza
{
    public partial class Form1 : Form
    {
        double CostOfPizza;
        int NumberOfSlice;
        double TotalCost;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostOfPizza = 2.50;
            NumberOfSlice = Convert.ToInt32(CostOfPizza);
            TotalCost = CostOfPizza * NumberOfSlice;

            label2.Text= $"The price of {NumberOfSlice} slices of pizza is {TotalCost.ToString("C")}";
        }
    }
}