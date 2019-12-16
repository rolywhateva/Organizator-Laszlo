using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Display[] d;
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Init_Demo();
            d = new Display[Engine.Adrese.Count];
            int k = 5;
           for(int i=0;i<d.Length;i++)
            {
                d[i] = new Display(Engine.Adrese[i]);
                d[i].Parent = panel1;
                d[i].Location = new Point(5, k);
                d[i].BorderStyle = BorderStyle.FixedSingle;
                k += d[i].Height;
            }
           
        }
    }
}
