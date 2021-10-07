using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_and_events_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TsmiCalcAndGreet_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void TsmiStudent_Click(object sender, EventArgs e)
        {
            studentControl sc1 = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(sc1);
            sc1.Dock = DockStyle.Fill;
        }
    }
}
