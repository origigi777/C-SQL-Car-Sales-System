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

namespace CarSalesDB.Screens.Products
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            getSalesTable();
        }
        SqlConnection con = new SqlConnection(General.AppSettings.connectionString());
        private void QualtyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBestworker_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name FROM     dbo.tbl_users group by dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name ORDER BY SUM(dbo.tbl_users.Parmmision_level) DESC ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            QualtyDataGrid.DataSource = dt;
        }

        private void buttonSoldCars_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name,dbo.tbl_users.Parmmision_level FROM     dbo.tbl_users group by dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name, dbo.tbl_users.Parmmision_level ORDER BY SUM(tbl_users.Parmmision_level) ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            QualtyDataGrid.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name FROM     dbo.tbl_users group by dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name ORDER BY dbo.tbl_users.employee_ID ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            QualtyDataGrid.DataSource = dt;
        }

          private void getSalesTable()
        {

            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name, dbo.Tbl_sell_recommadtion.car_conditon, dbo.tbl_car_info.car_license_plate, dbo.tbl_car_info.car_model, dbo.tbl_car_info.car_price, dbo.tbl_car_info.kilometers, dbo.tbl_car_info.car_company, dbo.tbl_car_info.car_color, dbo.Tbl_sell_recommadtion.car_had_sale FROM     dbo.Tbl_sell_recommadtion INNER JOIN dbo.tbl_car_info ON dbo.Tbl_sell_recommadtion.car_license_plate = dbo.tbl_car_info.car_license_plate INNER JOIN dbo.tbl_users ON dbo.tbl_car_info.employee_ID = dbo.tbl_users.employee_ID ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            QualtyDataGrid.DataSource = dt;


        }
    }
}
