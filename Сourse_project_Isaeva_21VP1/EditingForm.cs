using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сourse_project_Isaeva_21VP1
{
    public partial class EditingForm : Form
    {
        Item item;
        TheMainForm theMainForm;
       /// <summary>
       /// Конструктор формы
       /// </summary>
       /// <param name="form2">объект класса TheMainForm - главной формы</param>
       /// <param name="item">объект класса Item - изменяемый элемент</param>
        public EditingForm(TheMainForm form2, Item item)
        {
            this.theMainForm = form2;
            this.item = item;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.quantity = (int)numericUpDown1.Value;
            item.productionDate = new DateTime(year: (int)numericUpDown3.Value, month: (int)numericUpDown2.Value, day: (int)numericUpDown4.Value);
            item.expirationDate = new DateTime(year: (int)numericUpDown6.Value, month: (int)numericUpDown7.Value, day: (int)numericUpDown5.Value);
            theMainForm.db.editNote(item.id, item.quantity, item.productionDate, item.expirationDate);
            MessageBox.Show("Изменения сохранены");
            theMainForm.updateTable(theMainForm.db.DBToList());
            Close();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            invalidProdDateLabel.Visible = false;
            invalidExpDateLabel.Visible = false;
            label6.Text += item.id;
            textBox1.Text = item.name;
            numericUpDown1.Value = item.quantity;
            numericUpDown4.Value = item.productionDate.Day;
            numericUpDown2.Value = item.productionDate.Month;
            numericUpDown3.Value = item.productionDate.Year;
            numericUpDown5.Value = item.expirationDate.Day;
            numericUpDown7.Value = item.expirationDate.Month;
            numericUpDown6.Value = item.expirationDate.Year;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (PutAwayContradictionsInProd())
                LogicalDate();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (PutAwayContradictionsInExp())
                LogicalDate();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (PutAwayContradictionsInExp())
                LogicalDate();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
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
