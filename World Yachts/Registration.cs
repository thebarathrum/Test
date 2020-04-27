using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace World_Yachts
{
    public partial class Registration : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["World_Yachts.Properties.Settings._16is13ConnectionString"].ConnectionString;
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        public Registration()
        {
            InitializeComponent();
        }

        private void BT_Sign_Up_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                if (TB_Login.Text == "" || TB_Password.Text == "" || TB_First_Name.Text == "" || TB_Middle_Name.Text == "" || TB_Last_Name.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для регистрации !");
                }
                else
                {
                    string str = "insert into [dbo].[User](Login,Password,FirstName,MiddleName,LastName,RoleID, RegDate) values('" + TB_Login.Text + "','" + TB_Password.Text + "', '" + TB_First_Name.Text + "','" + TB_Middle_Name.Text + "','" + TB_Last_Name.Text + "','"+ 2 +"', '" + date + "')";
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
