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
                    if (!Manufacturer_TB.ReadOnly)
                    {
                        string manufacturer = Manufacturer_TB.Text.Trim();

                        if (String.IsNullOrWhiteSpace(manufacturer))
                        {
                            Manufacturer_TB.Focus();

                            throw new Exception("Введите производителя");
                        }
                    }

                    if (!Provider_TB.ReadOnly)
                    {
                        string provider = Provider_TB.Text.Trim();

                        if (String.IsNullOrWhiteSpace(provider))
                        {
                            Provider_TB.Focus();

                            throw new Exception("Введите поставщика");
                        }
                    }

                    if (!UR_adress_TB.ReadOnly)
                    {
                        string UR_adress = UR_adress_TB.Text.Trim();

                        if (String.IsNullOrWhiteSpace(UR_adress))
                        {
                            UR_adress_TB.Focus();

                            throw new Exception("Введите юридический адрес");
                        }
                    }                  

                    if (!Telephone_TB.ReadOnly)
                    {
                        if (Telephone_TB.Text.Trim() == "")
                        {
                            Telephone_TB.Focus();

                            throw new Exception("Поле телефона не может быть пустым");
                        }

                        int telephone = Convert.ToInt32(Telephone_TB.Text);

                        if (telephone < 0 || telephone > 9)
                        {
                            Telephone_TB.Focus();

                            throw new Exception("Номер телефона должен использовать значения в диапазоне от 0 до 9");
                        }
                    }

                    if (!Provider_TB.ReadOnly)
                    {
                        string ProductName = Product_Name_TB.Text.Trim();

                        if (string.IsNullOrWhiteSpace(ProductName))
                        {
                            Provider_TB.Focus();

                            throw new Exception("Введите название продукта");
                        }
                    }

                    if (!Price_TB.ReadOnly)
                    {
                        if (Price_TB.Text.Trim() == "")
                        {
                            Price_TB.Focus();

                            throw new Exception("Поле цены не может быть пустым");
                        }

                        decimal price = Convert.ToDecimal(Price_TB.Text);

                        if (price < 0)
                        {
                            Price_TB.Focus();

                            throw new Exception("Цена должна содержать числовой формат");
                        }
                    }

                    if (!Reciept_TB.ReadOnly)
                    {
                        string Reciept = Reciept_TB.Text.Trim();

                        if (string.IsNullOrWhiteSpace(Reciept))
                        {
                            Reciept_TB.Focus();

                            throw new Exception("Введите рецепт");
                        }
                    }

                    if (!Birthday_TB.ReadOnly)
                    {

                        if (TextIsDate(Birthday_TB.Text))
                        {
                            Birthday_TB.Focus();

                            throw new Exception("Дата рождения имеет неверный формат");
                        }
                    }

                    if (!Post_name_TB.ReadOnly)
                    {
                        string PostName = Post_name_TB.Text.Trim();

                        if (string.IsNullOrWhiteSpace(PostName))
                        {
                            throw new Exception("Введите название должности");
                        }
                    }                

                    if (!ZP_TB.ReadOnly)
                    {
                        if (ZP_TB.Text.Trim() == "")
                        {
                            ZP_TB.Focus();

                            throw new Exception("Поле заработной платы не может быть пустым");
                        }

                        decimal ZP = Convert.ToDecimal(ZP_TB.Text);

                        if (ZP < 0)
                        {
                            ZP_TB.Focus();

                            throw new Exception("Поле заработной платы не может быть отрицательным");
                        }
                    }

                    if (!Sum_TB.ReadOnly)
                    {
                        if (Sum_TB.Text.Trim() == "")
                        {
                            Sum_TB.Focus();

                            throw new Exception("Поле суммы не может быть пустым");
                        }

                        decimal Sum = Convert.ToDecimal(Sum_TB.Text);

                        if (Sum < 0)
                        {
                            Sum_TB.Focus();

                            throw new Exception("Поле суммы не может быть отрицательным");
                        }
                    }

                    if (!FIO_worker_TB.ReadOnly)
                    {
                        string FIO_worker = FIO_worker_TB.Text.Trim();

                        if (string.IsNullOrWhiteSpace(FIO_worker))
                        {
                            FIO_worker_TB.Focus();

                            throw new Exception("Введите ФИО сотрудника");
                        }
                    }

                    if (!Expiration_date_TB.ReadOnly)
                    {
                        if (ProductIsDate(Expiration_date_TB.Text))
                        {
                            Expiration_date_TB.Focus();

                            throw new Exception("Поле срока годности содержит неверный формат");
                        }
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
