using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitkay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Dammit i have to commit
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dumme Kuh");
        }
    }
}
