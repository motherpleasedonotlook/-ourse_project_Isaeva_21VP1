using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сourse_project_Isaeva_21VP1
{
    /// <summary>
    /// Форма добавления элемента
    /// </summary>
    public partial class AddingForm : Form
    {
        Item item;
        TheMainForm theMainForm;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="form2">объект класса TheMainForm - основной формы</param>
        /// <param name="item">объект класса Item - добавляемый элемент</param>
       public AddingForm(TheMainForm form2, Item item)
        {
            InitializeComponent();
            this.theMainForm = form2;
            this.item = item;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.ForeColor = Color.Black;
            Regex regex = new Regex("^[а-яА-Яa-zA-Z0-9-<> #%=+&?$():;,./]+$");
            if (!regex.IsMatch(textBox1.Text) || textBox1.Text.StartsWith(" "))
            {
                textBox1.ForeColor = Color.Red;
                button1.Enabled = false;
            }
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
            invalidProdDateLabel.Visible = false;
            invalidExpDateLabel.Visible = false;
            textBox1.Text = item.name;
            numericUpDown1.Value = item.quantity;
            numericUpDown4.Value = item.productionDate.Day;
            numericUpDown2.Value = item.productionDate.Month;
            numericUpDown3.Value = item.productionDate.Year;
            numericUpDown5.Value = item.expirationDate.Day;
            numericUpDown7.Value = item.expirationDate.Month;
            numericUpDown6.Value = item.expirationDate.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.name = textBox1.Text;
            item.quantity = (int)numericUpDown1.Value;
            item.productionDate = new DateTime(year: (int)numericUpDown3.Value, month: (int)numericUpDown2.Value, day: (int)numericUpDown4.Value);
            item.expirationDate = new DateTime(year: (int)numericUpDown6.Value, month: (int)numericUpDown7.Value, day: (int)numericUpDown5.Value);
            theMainForm.AddToDB(item);

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.ForeColor = Color.Black;
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.ForeColor = Color.Black;
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.ForeColor = Color.Black;
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.ForeColor = Color.Black;
            if (PutAwayContradictionsInExp())
                LogicalDate();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.ForeColor = Color.Black;
            if (PutAwayContradictionsInExp())
                LogicalDate();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown6.ForeColor = Color.Black;
            if (PutAwayContradictionsInExp())
                LogicalDate();
        }
        private bool PutAwayContradictionsInProd()
        {
            bool isLogical;
            try
            {
                DateTime prod = new DateTime(year: (int)numericUpDown3.Value, month: (int)numericUpDown2.Value, day: (int)numericUpDown4.Value);
                isLogical = true;
            }
            catch (Exception)
            {
                isLogical = false;
            }
            if (isLogical)
            {
                invalidProdDateLabel.Visible = false;
                button1.Enabled = true;
                return true;
            }
            else
            {
                button1.Enabled = false;
                invalidProdDateLabel.Visible = true;
                return false;
            }
        }
        private bool PutAwayContradictionsInExp()
        {
            bool isLogical;
            try
            {
                DateTime exp = new DateTime(year: (int)numericUpDown6.Value, month: (int)numericUpDown7.Value, day: (int)numericUpDown5.Value);
                isLogical = true;
            }
            catch (Exception)
            {
                isLogical = false;
            }
            if (isLogical)
            {
                invalidExpDateLabel.Visible = false;
                button1.Enabled = true;
                return true;
            }
            else
            {
                button1.Enabled = false;
                invalidExpDateLabel.Visible = true;
                return false;
            }
        }
        private void LogicalDate()
        {
            DateTime exp = new DateTime(year: (int)numericUpDown6.Value, month: (int)numericUpDown7.Value, day: (int)numericUpDown5.Value);
            DateTime prod = new DateTime(year: (int)numericUpDown3.Value, month: (int)numericUpDown2.Value, day: (int)numericUpDown4.Value);
            if (exp <= prod)
            {
                prod = prod.AddDays(1);
                numericUpDown6.Value = prod.Year;
                numericUpDown7.Value = prod.Month;
                numericUpDown5.Value = prod.Day;
            }
        }
    }
}
