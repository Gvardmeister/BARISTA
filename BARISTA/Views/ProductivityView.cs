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
using BARISTA.Model;

namespace BARISTA.Views
{
    public partial class ProductivityView : Form
    {
        public ProductivityView()
        {
            InitializeComponent();

            context = new Infrastructure.ApplicationContext();

            //InitializeListOfProductivityView();
        }

        private Infrastructure.ApplicationContext context;
        private List<Manufacturer> manufacturers;

        //private void InitializeListOfProductivityView()
        //{
        //    manufacturers = new List<Manufacturer>(context.manufacturers.ToList());

        //    Productivity_DGV.DataSource = manufacturers;
        //}

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectTemplateView projectTemplate = new ProjectTemplateView();

                projectTemplate.Manufacturer_TB.ReadOnly = false;

                if (projectTemplate.ShowDialog() == DialogResult.OK)
                {
                    using ApplicationContext db = new ApplicationContext();

                    Manufacturer manufacturer = new Manufacturer
                    {
                        Name = projectTemplate.Manufacturer_TB.Text.Trim()
                    };

                    //context.manufacturers.Add(manufacturer);
                    context.SaveChanges();

                    manufacturers.Add(manufacturer);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
