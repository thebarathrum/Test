using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace World_Yachts
{
    public partial class Administrator : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["World_Yachts.Properties.Settings._16is13ConnectionString"].ConnectionString;
        public Administrator()
        {
            InitializeComponent();
        }


        private void Administrator_Load(object sender, EventArgs e)
        {


        }
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.accessoryTableAdapter.Fill(this._16is13DataSet.accessory);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BT_Sign_Up_Click(object sender, EventArgs e)
        {
            Form Registration = new Registration();
            Registration.Show();
            this.Hide();
        }
    }
}
