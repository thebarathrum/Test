using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace World_Yachts
{
    public partial class Auth : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["World_Yachts.Properties.Settings._16is13ConnectionString"].ConnectionString;

        int Auth_Count = 0;
        int time = 15;
        int newTime;
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        bool IsBlocked(DateTime LV, DateTime dt)
        {
            TimeSpan days = dt - LV;
            string nCountDay = String.Format("{0:d}", days);
            Int32 intDay = Convert.ToInt32(nCountDay);

            if (intDay >= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Auth()
        {
            InitializeComponent();
        }

        private void BT_Sign_In_Click(object sender, EventArgs e)
        {
            string Login = TB_Login.Text.Trim();
            string Password = TB_Password.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string RoleID = null;
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT [RoleID] FROM [dbo].[User] WHERE Login = @Login AND Password = @Password";
                command.Connection = connection;

                command.Parameters.Add("@Login", SqlDbType.VarChar);
                command.Parameters["@Login"].Value = Login;

                command.Parameters.Add("@Password", SqlDbType.VarChar);
                command.Parameters["@Password"].Value = Password;

                if (Auth_Count < 2)
                {
                    try
                    {
                        connection.Open();
                        RoleID = (string)command.ExecuteScalar();

                        command.CommandText = "Select [ID] From [dbo].[User] where Login = @Login AND Password = @Password";
                        string userID = (string)command.ExecuteScalar().ToString();
                        command.CommandText = "Select [LastVisit] From [dbo].[User] where Login = @Login AND Password = @Password";
                        string LastVisit = (string)command.ExecuteScalar().ToString();

                        if (RoleID.ToString() == "1")
                        {
                            MessageBox.Show("Вы успешно авторизовались как Администратор.");
                            command.CommandText = "Update [dbo].[User] SET [LastVisit] = @LastVisit WHERE ID = @ID";
                                command.Parameters.AddWithValue("@ID", SqlDbType.VarChar);
                                command.Parameters["@ID"].Value = userID;
                                command.Parameters.AddWithValue("@LastVisit", SqlDbType.Date);
                                command.Parameters["@LastVisit"].Value = date;

                            command.ExecuteScalar();
                            connection.Close();

                            Form Administrator = new Administrator();
                            Administrator.Show();
                            this.Hide();
                        }
                        else if (RoleID != null)
                        {
                            MessageBox.Show("Вы успешно авторизовались.");
                            connection.Close();
                            Form Manager = new Manager();
                            Manager.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        Auth_Count += 1;
                        MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                    }
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    BT_Sign_In.Enabled = false;
                    newTime = time + 20;
                    Auth_Count = 1;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time = time - 1;
                BT_Sign_In.Text = time.ToString();
                BT_Sign_In.Enabled = false;
            }
            else
            {
                timer1.Stop();
                time = newTime;
                BT_Sign_In.Enabled = true;
                BT_Sign_In.Text = "Войти";
            }
        }
    }
}