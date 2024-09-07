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
    /// Открывающая форма
    /// </summary>
    public partial class StartingForm : Form
    {
        DBClass db = new DBClass();
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StartingForm()
        {
            InitializeComponent();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение <<Склад>> запущено.\n Автор: Исаева И.Р. 21ВП1");
        }

        private void createBaseButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                db.name = textBox1.Text;
                if (db.createDB())
                {
                    BlockCreating(true);
                    TheMainForm theMainForm = new TheMainForm(this, db);
                    theMainForm.Show(this);
                }
                else { MessageBox.Show("База данных с таким именем уже существует или имя некорректно.\nПопробуйте снова."); }
            }
            else if (radioButton2.Checked)
            {
                if (db.openDB(textBox1.Text))
                {
                    BlockCreating(true);
                    TheMainForm newForm = new TheMainForm(this, db);
                    newForm.Show(this);
                }
                else { MessageBox.Show("База данных с таким именем не существует или имя некорректно.\nПопробуйте снова."); }
            }
            else { MessageBox.Show("Необходимо выбрать значение."); }


        }
       /// <summary>
       /// Метод блокирует кнопку создания базы данных, если открыта основная форма
       /// </summary>
       /// <param name="value"></param>
        public void BlockCreating(bool value)
        {
            if (value) createBaseButton.Enabled = false;
            else createBaseButton.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BlockCreating(false);
            textBox1.ForeColor = Color.Black;
            Regex regex = new Regex("^[_a-zA-Z][_a-zA-Z0-9]*$");
            if (!regex.Match(textBox1.Text).Success)
            {
                textBox1.ForeColor = Color.Red;
                BlockCreating(true);
            }
        }
    }
}
