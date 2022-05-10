using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARISTA.Views;

namespace BARISTA.Views
{
    public partial class ProductivityView : Form
    {
        public ProductivityView()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectTemplateView projectTemplate = new ProjectTemplateView();

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

        }
    }
}
