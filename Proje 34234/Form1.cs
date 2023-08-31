using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_34234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string adatra;
            adatra = textBox1.Text;
            textBox1.Text = null;
            Form2 form2 = new Form2();
            form2.Data = adatra;
            form2.Show();
            await Task.Delay(6500);
        }
    }
}
