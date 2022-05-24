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

namespace CarSalesDB
{
    public partial class LoginScrean : Form
    {
        public LoginScrean()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(General.AppSettings.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("login_verify_details1", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_name", textUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textPassword.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            //MessageBox.Show("welcome");
                            this.Hide();
                            Screens.DashBoardScreen ds = new Screens.DashBoardScreen();
                            ds.Show();

                        }
                        else
                        {
                            MessageBox.Show("User Name or Password is incorrect", "Login Failed "
                                , MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private Boolean IsValid()
        {
            if(textUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name is requird");
                return false;   
            }
            if (textPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password  is requird");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
