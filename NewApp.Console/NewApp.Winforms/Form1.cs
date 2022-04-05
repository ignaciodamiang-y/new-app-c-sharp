using NewApp.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApp.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = $"Result: {Calculator.Sumar(textNum1.Text, textNum2.Text)}";
        }
    }
}
