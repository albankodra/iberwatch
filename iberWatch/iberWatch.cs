using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iberWatch
{
    public partial class iberWatch : Form
    {
        public iberWatch()
        {
            InitializeComponent();
            timer1.Start();

        }




        private void iberWatch_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblOra.Text = time.ToString("hh:mm");
            lblTT.Text = time.ToString("tt");
            lblDitaMuaji.Text = time.ToString("dd MMM");
            lblViti.Text = time.ToString("yyyy");
            lblDita.Text = time.ToString("ddd");
        }
    }
}
