using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Yachts
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void BT_CreateContact_Click(object sender, EventArgs e)
        {
            Form New_Order = new New_Order();
            this.Hide();
            New_Order.Show();
        }
    }
}
