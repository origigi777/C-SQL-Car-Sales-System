using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSalesDB.Screens
{
    public partial class DashBoardScreen : Form
    {
        public DashBoardScreen()
        {
            InitializeComponent();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Products.AddNewCarsScreen adnewcar = new Products.AddNewCarsScreen();
            adnewcar.Show();
        }

        private void buttonSoldCar_Click(object sender, EventArgs e)
        {
            Products.ConditionScreen carCondition = new Products.ConditionScreen();
            carCondition.Show();
        }

        private void ButtonnewconditionCar_Click(object sender, EventArgs e)
        {
            Products.QualityCar carQCondition = new Products.QualityCar();
            carQCondition.Show();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Products.Employees carQCondition = new Products.Employees();
            carQCondition.Show();
        }

        private void buttonCarPrice_Click(object sender, EventArgs e)
        {
            Products.CarPrices carQCondition = new Products.CarPrices();
            carQCondition.Show();
        }
    }
}
