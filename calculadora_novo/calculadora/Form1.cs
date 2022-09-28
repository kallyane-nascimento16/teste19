using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonsoma_Click(object sender, EventArgs e)
        {
            soma obs=new soma();
            obs.numero1=double.Parse(textBox1.Text); 
            obs.numero2=double.Parse(textBox2.Text);
            obs.somar();

            label2.Text = Convert.ToString(obs.somar());

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
