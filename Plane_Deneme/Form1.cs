using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Deneme
{
    public partial class Form1 : Form
    {
       public Panel panel3;
        public Form1()
        {
            InitializeComponent();
            panel3=new Panel();
            panel3.SuspendLayout();
            panel3.Dock = DockStyle.Fill;
            panel3.BackColor = Color.SkyBlue;
            this.Controls.Add(panel3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Orange;
            panel2.BackColor = Color.Green;
            //panel1.Dock = DockStyle.Left;
            //panel2.Dock = DockStyle.Right;
            panel3.Dock= DockStyle.Right;
        }
    }
}
