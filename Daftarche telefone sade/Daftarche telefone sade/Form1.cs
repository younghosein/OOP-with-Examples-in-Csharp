using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daftarche_telefone_sade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fCtrl = new FCtrl();
        }
        FCtrl fCtrl;
        string a;
        private void button1_Click(object sender, EventArgs e)
        {
            a = txtNum.Text;
            Person person = new Person(txtSave.Text);
            Tel tel = new Tel(a, person);
            fCtrl.Add(tel);
            txtSave.Clear();
            txtNum.Clear();
            txtSave.Focus();
            listBox1.Items.Add("Name: " + tel.person.Name + "\tNumber: " + tel.No );
            comboBox1.Items.Add("Name: " + tel.person.Name + "\tNumber: " + tel.No);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tel[] tels = fCtrl.search(new Person(txtSerch.Text));

            for(int i = 0; i < fCtrl.k; i++)
            {
                MessageBox.Show("Name: " + tels[i].person.Name + "\n\n" + "Number: " + tels[i].No + "\n\n" + "Contact Number: " + (i+1) );
                listBox2.Items.Add("Name: " + tels[i].person.Name + "\tNumber: " + tels[i].No);
                if (i == (fCtrl.k - 1))
                {
                    fCtrl.k = 0;
                }
                
            }
            txtSerch.Clear();
            txtSerch.Focus();
        } 
    }
}
