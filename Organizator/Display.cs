using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizator
{
    public partial class Display : UserControl
    {

        public Adrese Bound;
        public Display(Adrese Bound)
        {
            InitializeComponent();
            this.Bound = Bound;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            this.Height = 120;

            panel2.Visible = false;
            panel3.Visible = false;
            if (Bound is Madress)
            {
                this.Height = 240;
                panel2.Visible = true;
            }
            if(Bound is Eadress)
            {
                this.Height = 416;
                panel2.Visible = true;
                panel3.Visible = true;
            }
           _Refresh();
            
        }
        public  void _Refresh()
        {

            textBox1.Text = Bound.Nume;
            
            textBox2.Text = Bound.NrTelefon;
            if (Bound is Madress)
            {
                textBox3.Text = (Bound as Madress).NrTelefon2;
                textBox4.Text = (Bound as Madress).Type.ToString();
                textBox5.Text = (Bound as Madress).Email;
               
            }
            if(Bound is Eadress)
            {
                textBox6.Text = (Bound as Eadress).Adresa;
            }
        }
    }
}
