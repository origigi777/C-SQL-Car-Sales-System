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
    public partial class CarPrices : Form
    {
        public CarPrices()
        {
            InitializeComponent();
            getSalesTable();
        }
        SqlConnection con = new SqlConnection(General.AppSettings.connectionString());
        private void PriceDataGrid2121_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLow_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM     dbo.tbl_car_info ORDER BY dbo.tbl_car_info.car_price ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            PriceDataGrid2121.DataSource = dt;
        }

        private void buttonHigh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM     dbo.tbl_car_info ORDER BY dbo.tbl_car_info.car_price DESC ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            PriceDataGrid2121.DataSource = dt;
        }

        private void buttonPayOff_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM     dbo.tbl_car_info ORDER BY  dbo.tbl_car_info.kilometers, dbo.tbl_car_info.car_price DESC ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            PriceDataGrid2121.DataSource = dt;
        }
        private void getSalesTable()
        {

            SqlCommand cmd = new SqlCommand("SELECT dbo.tbl_users.employee_ID, dbo.tbl_users.first_name, dbo.tbl_users.last_name, dbo.Tbl_sell_recommadtion.car_conditon, dbo.tbl_car_info.car_license_plate, dbo.tbl_car_info.car_model, dbo.tbl_car_info.car_price, dbo.tbl_car_info.kilometers, dbo.tbl_car_info.car_company, dbo.tbl_car_info.car_color, dbo.Tbl_sell_recommadtion.car_had_sale FROM     dbo.Tbl_sell_recommadtion INNER JOIN dbo.tbl_car_info ON dbo.Tbl_sell_recommadtion.car_license_plate = dbo.tbl_car_info.car_license_plate INNER JOIN dbo.tbl_users ON dbo.tbl_car_info.employee_ID = dbo.tbl_users.employee_ID ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            PriceDataGrid2121.DataSource = dt;


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
