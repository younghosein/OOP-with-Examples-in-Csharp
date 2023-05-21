using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fctrl = new FCtrl();
        }
        FCtrl fctrl;
        Person p;
        string a;

        private void btnSave_Click(object sender, EventArgs e)
        {
            a = txtNum.Text;
            Person person = new Person(txtSave.Text);
            Tel tel = new Tel(a, person);
            fctrl.Add(tel);
            txtSave.Clear();
            txtNum.Clear();
            txtSave.Focus();
            listBox1.Items.Add("Name: " + tel.person.Name + "\t number;" + tel.NO);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int k = 0;
            p = new Person(textBox3.Text);
            Tel[] tels = fctrl.search(p);
            for (int i = 0; i < fctrl.k; i++)
            {
                MessageBox.Show("Name:" + tels[i].person.Name + "\n\nNumber:" + tels[i].NO + "\n\n" + "contactnumber:" + (i + 1));
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }

}
