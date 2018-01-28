using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AccountDetail ad = new AccountDetail();
        private void button1_Click(object sender, EventArgs e)
        {

            
            ad.ShowDetail(textBox1,textBox3,textBox4,textBox2,dollar,yen,dinar,pound);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ad.disableTexboxes(textBox4, textBox3, dollar, yen, dinar, pound);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
