using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARISTA
{
    public partial class ProjectTemplateView : Form
    {
        public ProjectTemplateView()
        {
            InitializeComponent();
        }

        private void ProjectTemplateView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    string manufacturer = Manufacturer_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(manufacturer) && !Manufacturer_TB.ReadOnly)
                    {
                        Manufacturer_TB.Focus();

                        throw new Exception("Введите производителя");
                    }

                    string provider = Provider_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(provider) && !Provider_TB.ReadOnly)
                    {
                        Provider_TB.Focus();

                        throw new Exception("Введите поставщика");
                    }

                    string UR_adress = UR_adress_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(UR_adress) && !UR_adress_TB.ReadOnly)
                    {
                        UR_adress_TB.Focus();

                        throw new Exception("Введите юридический адрес");
                    }

                    int telephone = Convert.ToInt32(Telephone_TB.Text);

                    if(!Telephone_TB.ReadOnly && (telephone < 0 || telephone > 9))
                    {
                        Telephone_TB.Focus();

                        throw new Exception("Номер телефона должен использовать значения в диапазоне от 0 до 9");
                    }

                    string ProductName = Product_Name_TB.Text.Trim();

                    if (string.IsNullOrWhiteSpace(ProductName) && !Provider_TB.ReadOnly)
                    {
                        Provider_TB.Focus();

                        throw new Exception("Введите название продукта");
                    }

                    decimal price = Convert.ToDecimal(Price_TB.Text);

                    if (!Price_TB.ReadOnly && (price < 0))
                    {
                        Price_TB.Focus();

                        throw new Exception("Цена должна содержать числовой формат");
                    }

                    string Reciept = Reciept_TB.Text.Trim();

                    if (string.IsNullOrWhiteSpace(Reciept) && !Reciept_TB.ReadOnly)
                    {
                        Reciept_TB.Focus();

                        throw new Exception("Введите рецепт");
                    }

                    if (TextIsDate(Birthday_TB.Text) && !Birthday_TB.ReadOnly)
                    {
                        Birthday_TB.Focus();

                        throw new Exception("Дата рождения имеет неверный формат");
                    }

                    string PostName = Post_name_TB.Text.Trim();

                    if (string.IsNullOrWhiteSpace(PostName) && !Post_name_TB.ReadOnly)
                    {
                        throw new Exception("Введите название должности");
                    }

                    decimal ZP = Convert.ToDecimal(ZP_TB.Text);

                    if (!ZP_TB.ReadOnly && (ZP < 0))
                    {
                        ZP_TB.Focus();

                        throw new Exception("Поле заработной платы должно содержать числовой формат");
                    }

                    decimal Sum = Convert.ToDecimal(Sum_TB.Text);

                    if (!Sum_TB.ReadOnly && (Sum < 0))
                    {
                        Sum_TB.Focus();

                        throw new Exception("Поле суммы не может быть пустым");
                    }

                    string FIO_worker = FIO_worker_TB.Text.Trim();

                    if (string.IsNullOrWhiteSpace(FIO_worker) && !FIO_worker_TB.ReadOnly)
                    {
                        FIO_worker_TB.Focus();

                        throw new Exception("Введите ФИО сотрудника");
                    }

                    if (ProductIsDate(Expiration_date_TB.Text) && !Expiration_date_TB.ReadOnly)
                    {
                        Expiration_date_TB.Focus();

                        throw new Exception("Поле срока годности содержит неверный формат");
                    }
                }
                catch (FormatException Fex)
                {
                    e.Cancel = true;

                    MessageBox.Show(Fex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    e.Cancel= true;

                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            static bool TextIsDate(string text)
            {
                var dateFormat = "yyyy-MM-dd";
                if (DateTime.TryParseExact(text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static bool ProductIsDate(string text)
            {
                var dateProduct = "yyyy-MM-dd";
                if (DateTime.TryParseExact(text, dateProduct, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
