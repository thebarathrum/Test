using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace World_Yachts
{
    public partial class New_Order : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["World_Yachts.Properties.Settings._16is13ConnectionString"].ConnectionString;
        public New_Order()
        {
            InitializeComponent();
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                if (TB_First_Name.Text == "" || TB_Last_Name.Text == "" || TB_Date_Of_Bitrh.Text == "" || TB_Adress.Text == "" || TB_City.Text == "" || TB_EMAIL.Text == "" || TB_Phone.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для регистрации !");
                }
                else
                {
                    string str = "insert into [dbo].[customer](FistName,FamilyName,DateOfBirth,OrganisationName,Address,City,email,Phone) values('" + TB_First_Name.Text + "','" + TB_Last_Name.Text + "', '" + TB_Date_Of_Bitrh.Text + "', '" + TB_OrgName.Text + "', '" + TB_Adress.Text + "','" + TB_City.Text + "','" + TB_EMAIL.Text + "', '" + TB_Phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь зарегистрирован !");
                    connection.Close();
                    this.Hide();
                    Form Administrator = new Administrator();
                    Administrator.Show();
                }
            }
        }
    }
}
