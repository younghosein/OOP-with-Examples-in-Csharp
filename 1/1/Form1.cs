using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f = new File();
        }
        File f;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Ctrl ctrl = new Ctrl();
            EjareKardan ejare;
            Otagh otagh = new Otagh(int.Parse(TxtRoomNumber.Text));
            if (TxtMojarad.Text == "")
            {
                Motahel motahel = new Motahel(int.Parse(TxtMotahel.Text), TxtName.Text);
                ctrl.Save(motahel);
                ejare = new EjareKardan(otagh, motahel);
            }
            else if (TxtMotahel.Text == "")
            {
                Mojarad mojarad = new Mojarad(int.Parse(TxtMojarad.Text), TxtName.Text);
                ctrl.Save(mojarad);
                ejare = new EjareKardan(otagh, mojarad);
            }
            else
            {
                MessageBox.Show("Bezan Be Chak :*");
                return;
            }
            ctrl.Save(otagh);
            ctrl.Save(ejare);
            f.Save(ctrl);
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
                return;

            string tmp = "";
            for (int i = 0; i < f.countList(); i++)
            {
                if (f.Show(i).Mosafer.showName() == TxtSearch.Text)
                {
                    tmp += "Name: " + f.Show(i).Mosafer.showName() + Environment.NewLine;
                    tmp += "Room Number: " + f.Show(i).Otagh.showNumber().ToString() + Environment.NewLine;

                    if (f.Show(i).Mosafer.GetType() == typeof(Mojarad))
                        tmp += "Age: " + ((Mojarad)f.Show(i).Mosafer).showAge().ToString() + Environment.NewLine;

                    if (f.Show(i).Mosafer.GetType() == typeof(Motahel))
                        tmp += "Child Count: " + ((Motahel)f.Show(i).Mosafer).showChildNumber().ToString() + Environment.NewLine;

                    tmp += "------------" + Environment.NewLine;
                }
            }
            textBox5.Text = tmp;
        }
    }
}
