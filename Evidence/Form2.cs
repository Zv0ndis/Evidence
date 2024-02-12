using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Zobrazíme Form1
            Form form1 = new FormsMain();
            form1.Show();
        }

        private void maskedTextBoxPoints_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxAverage.Visible = false;
            labelAverage.Visible = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxAverage.Visible = true;
            labelAverage.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void maskedTextBoxAverage_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxAverage_TextChanged(object sender, EventArgs e)
        {
            string text = maskedTextBoxAverage.Text;

            if (double.TryParse(text, out double average) && average <= 1.5)
            {
                radioButtonAccepted.Checked = true;
                radioButtonDenied.Checked = false;
                radioButtonAccepted.Enabled = false;
                radioButtonDenied.Enabled = false;
            }
            else
            {
                radioButtonAccepted.Checked = false;
                radioButtonDenied.Checked = false; // Assuming this is the opposite of Accepted
                radioButtonAccepted.Enabled = true; // Enable both buttons
                radioButtonDenied.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
