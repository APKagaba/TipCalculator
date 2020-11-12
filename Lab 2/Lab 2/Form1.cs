// Grading ID: A1749
// CIS 199-01
// Lab 2
// Due: 9/16/2018


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }
        // This will calculate the tip percent of any given price for the meal; 
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            const double TipRateLow = .15; // This is low tip rate written as a constant in decimal form;
            const double TipRateMed = .18; // This is medium tip rate written as a constant in decimal form;
            const double TipRateHi = .20; // This is high tip rate written as a constant in decimal form;
            double price; // Defines price as whole number;
            double output1; // Defines first output as whole number;
            double output2; // Defines second output as whole number;
            double output3; // Defines third output as whole number;

            price = double.Parse(num1Txt.Text); // Reads the price as the number that is entered in the textbox;

            output1 = price * TipRateLow; // This multiplies the price with low tip rate which is .15;
            output2 = price * TipRateMed; // This multiplies the price with medium tip rate which is .18;
            output3 = price * TipRateHi; // This multiplies the price with high tip rate which is .20;

            output1lbl.Text = $"{output1:C}"; // First Output label will show the total in currency form; 
            output2lbl.Text = $"{output2:C}"; // Second Output label will show the total in currency form; 
            output3lbl.Text = $"{output3:C}"; // Third Output label will show the total in currency form; 


        }

        private void Lab2_Load(object sender, EventArgs e)
        {
            TipRateLowlbl.Text = "15 %"; // Replaces tip rate low label with 15% instead of displaying label2; 
            TipRateMedlbl.Text = "18 %"; // Replaces tip rate medium label with 18% instead of displaying label3; 
            TipRateHilbl.Text = "20 %"; // Replaces tip rate high label with 20% instead of displaying label4; 

        }
    }
}
