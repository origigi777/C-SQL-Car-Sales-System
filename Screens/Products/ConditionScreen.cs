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
    public partial class ConditionScreen : Form
    {


        SqlConnection con = new SqlConnection(General.AppSettings.connectionString());
        int licence;
        public ConditionScreen()
        {
            InitializeComponent();
        }

        private void AddNewConditionScreen_Load(object sender, EventArgs e)
        {
            getSalesTable();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_sell_recommadtion (car_license_plate,car_had_sale,car_conditon) values( @car_license_plate , @car_had_sale  , @car_conditon  )", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@car_license_plate", textBoxLicense.Text);
             
                cmd.Parameters.AddWithValue("@car_had_sale", textBoxHandSales.Text);
                cmd.Parameters.AddWithValue("@car_conditon", textBoxCarCondition.Text);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("new car where added ", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getSalesTable();
                
            }

        }
       

        private bool IsValid()
        {
            if (textBoxLicense.Text.Trim() == string.Empty)
            {
                MessageBox.Show("License is requird");
                return false;
            }
       
            if (textBoxHandSales.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hand Sales number is requird");
                return false;
            }



            if (textBoxCarCondition.Text.Trim() == string.Empty)
            {
                MessageBox.Show("condition is requird");
                return false;
            }


            return true;
        }

        private void getSalesTable()
        {

            SqlCommand cmd = new SqlCommand("Select * from Tbl_sell_recommadtion ORDER BY car_license_plate", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            sellrecommendGridView1.DataSource = dt;


        }

        private void ConditionScreen_Load(object sender, EventArgs e)
        {
            getSalesTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT car_license_plate FROM tbl_car_info", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBoxLicense.DataSource = dt;
            textBoxLicense.DisplayMember = "car_license_plate";
            
        }

        private void sellrecommendGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int car_license_plate = Convert.ToInt32(sellrecommendGridView1.Rows[0].Cells[0].Value);
            textBoxLicense.Text = sellrecommendGridView1.SelectedRows[0].Cells[0].Value.ToString();



            int car_had_sale = Convert.ToInt32(sellrecommendGridView1.Rows[0].Cells[1].Value);
            textBoxHandSales.Text = sellrecommendGridView1.SelectedRows[0].Cells[1].Value.ToString();


            textBoxCarCondition.Text = sellrecommendGridView1.SelectedRows[0].Cells[2].Value.ToString();


   

        }

        private void textBoxLicense_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_sell_recommadtion SET  car_license_plate = @car_license_plate ,  car_had_sale= @car_had_sale  ,  car_conditon = @car_conditon  WHERE   car_license_plate = @car_license_plate  ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@car_license_plate", textBoxLicense.Text);

            cmd.Parameters.AddWithValue("@car_had_sale", textBoxHandSales.Text);
            cmd.Parameters.AddWithValue("@car_conditon", textBoxCarCondition.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("car info updated ", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getSalesTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
