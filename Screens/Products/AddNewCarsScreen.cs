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
    public partial class AddNewCarsScreen : Form
    {
        public AddNewCarsScreen()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(General.AppSettings.connectionString());
        public int employeeID;
        public int price;
        public int licencenum;
        public int kilometers;

        private void AddNewCarsScreen_Load(object sender, EventArgs e)
        {
            getCarTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
         if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_car_info VALUES (@employee_ID  , @car_model , @car_color  , @car_company , @car_license_plate  , @kilometers  , @car_price  )",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@employee_ID",textBoxEmployee.Text);
                cmd.Parameters.AddWithValue("@car_model", textBoxModelCar.Text);
                cmd.Parameters.AddWithValue("@car_color", textBoxColorCar.Text);
                cmd.Parameters.AddWithValue("@car_company", textBoxCompanyCar.Text);
                cmd.Parameters.AddWithValue("@car_license_plate", textBoxLIcenceNumer.Text);
                cmd.Parameters.AddWithValue("@kilometers ", textBoxKilometers.Text);
                cmd.Parameters.AddWithValue("@car_price", textBoxPriceCar.Text);
                  
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("new car where added ","successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                getCarTable();
            }

        }
        private bool IsValid()
        {
            if(textBoxEmployee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Employee ID is requird");
                return false;   
            }
            if (textBoxModelCar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Model of the Car  is requird");
                return false;
            }
            if (textBoxColorCar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Color Car  is requird");
                return false;
            }
            if (textBoxCompanyCar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Company of the Car  is requird");
                return false;
            }
            if (textBoxLIcenceNumer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Licence Numer  is requird");
                return false;
            }
            if (textBoxKilometers.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kilometers  is requird");
                return false;
            }
            if (textBoxPriceCar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Price of the Car  is requird");
                return false;
            }


            return true;
        }

        private void getCarTable()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from tbl_car_info", con);
            DataTable dt = new DataTable();

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();

            carRecordDataGrid.DataSource = dt;
                
            
        }

        private void carRecordDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            employeeID = Convert.ToInt32(carRecordDataGrid.Rows[0].Cells[0].Value);  
            textBoxEmployee.Text =carRecordDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            
            textBoxModelCar.Text= carRecordDataGrid.SelectedRows[0].Cells[1].Value.ToString();


            textBoxColorCar.Text= carRecordDataGrid.SelectedRows[0].Cells[2].Value.ToString();


            textBoxCompanyCar.Text= carRecordDataGrid.SelectedRows[0].Cells[3].Value.ToString();

            licencenum = Convert.ToInt32(carRecordDataGrid.Rows[0].Cells[4].Value);
            textBoxLIcenceNumer.Text= carRecordDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            kilometers = Convert.ToInt32(carRecordDataGrid.Rows[0].Cells[5].Value);
            textBoxKilometers.Text= carRecordDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            price = Convert.ToInt32(carRecordDataGrid.Rows[0].Cells[6].Value);
            textBoxPriceCar.Text= carRecordDataGrid.SelectedRows[0].Cells[6].Value.ToString();





        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UPDATE tbl_car_info SET employee_ID = @employee_ID  , car_model = @car_model , car_color = @car_color  , car_company = @car_company ,car_license_plate = @car_license_plate  , kilometers = @kilometers  , car_price = @car_price WHERE car_license_plate = @car_license_plate ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@employee_ID", textBoxEmployee.Text);
            cmd.Parameters.AddWithValue("@car_model", textBoxModelCar.Text);
            cmd.Parameters.AddWithValue("@car_color", textBoxColorCar.Text);
            cmd.Parameters.AddWithValue("@car_company", textBoxCompanyCar.Text);
            cmd.Parameters.AddWithValue("@car_license_plate", textBoxLIcenceNumer.Text);
            cmd.Parameters.AddWithValue("@kilometers ", textBoxKilometers.Text);
            cmd.Parameters.AddWithValue("@car_price", textBoxPriceCar.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" car info updated ", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getCarTable();
            

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (employeeID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_car_info  WHERE car_license_plate = @car_license_plate ", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@car_license_plate", textBoxLIcenceNumer.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" car info deleted ", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getCarTable();

            }
            else
            {
                MessageBox.Show(" car couldn't be deleted ", "try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
