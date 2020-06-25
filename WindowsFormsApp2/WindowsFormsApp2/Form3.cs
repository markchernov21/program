using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                Form3.ActiveForm.Hide();
                Form1 f3 = new Form1();
                f3.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                Form3.ActiveForm.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }
        }
    }
}
