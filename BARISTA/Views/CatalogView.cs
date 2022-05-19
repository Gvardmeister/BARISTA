using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARISTA.Model;

namespace BARISTA.Views
{
    public partial class CatalogView : Form
    {
        public CatalogView()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectTemplateView projectTemplate = new ProjectTemplateView();

                projectTemplate.Price_TB.ReadOnly = false;
                projectTemplate.Product_Name_TB.ReadOnly = false;

                if (projectTemplate.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update_B_Click(object sender, EventArgs e)
        {

        }

        private void Del_B_Click(object sender, EventArgs e)
        {

        }

        private void Back_B_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
