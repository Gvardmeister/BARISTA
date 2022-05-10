using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BARISTA.Views;

namespace BARISTA
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Manufacturer_B_Click(object sender, EventArgs e)
        {
            try
            {
                ProductivityView productivityModel = new ProductivityView();

                productivityModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Vendor_B_Click(object sender, EventArgs e)
        {
            try
            {
                VendorView vendorModel = new VendorView();

                vendorModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Supply_B_Click(object sender, EventArgs e)
        {
            try
            {
                SupplyView supplyModel = new SupplyView();

                supplyModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Check_B_Click(object sender, EventArgs e)
        {
            try
            {
                CheckView сheckModel = new CheckView();

                сheckModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Employee_B_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeView employeeModel = new EmployeeView();

                employeeModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Warehouse_B_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseView warehouseModel = new WarehouseView();

                warehouseModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Catalogy_B_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogView catalogyModel = new CatalogView();

                catalogyModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Menu_B_Click(object sender, EventArgs e)
        {
            try
            {
                MenuView menuModel = new MenuView();

                menuModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Position_B_Click(object sender, EventArgs e)
        {
            try
            {
                PositionView positionModel = new PositionView();

                positionModel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
