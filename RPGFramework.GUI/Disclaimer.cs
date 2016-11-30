using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFramework.GUI
{
    public partial class Disclaimer : Form
    {
        public Disclaimer()
        {
            InitializeComponent();
        }

        private void Dsc_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dsc_Ok_Fu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
