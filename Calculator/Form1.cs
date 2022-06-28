using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static byte Choose {  get;private set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Click_2(object sender, EventArgs e)
        {
            Choose = 1;
            this.Close();
        }

        private void Click_10(object sender, EventArgs e)
        {
            Choose = 2;
            this.Close();
        }

        private void Click_16(object sender, EventArgs e)
        {
            Choose = 3;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choose = 0;
        }
    }
}
