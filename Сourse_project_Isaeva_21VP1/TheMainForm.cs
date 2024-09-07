using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Сourse_project_Isaeva_21VP1
{
    /// <summary>
    /// Класс основной формы
    /// </summary>
    public partial class TheMainForm : Form
    {
        StartingForm startingForm;
        AddingForm addingForm;
        EditingForm editingForm;
        /// <summary>
        /// текущая база данных
        /// </summary>
        public DBClass db;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="form1">объект класса StartingForm - открывающей формы</param>
        /// <param name="db">объект класса DBClass - текущая база данных</param>
        public TheMainForm(StartingForm form1, DBClass db)
        {
            InitializeComponent();
            this.startingForm = form1;
            this.db = db;
            FormClosing += Form2_FormClosing;
        }

        private void TheMainForm_Load(object sender, EventArgs e)
        {
            updateTable(db.DBToList());
        }

        private void dropBaseButton_Click(object sender, EventArgs e)
        {
            if (Warning($"Удалить базу данных {db.name}?\nВосстановить данные будет невозможно."))
            {
                Close();
                db.dropDB();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            addingForm = new AddingForm(this, item);
            addingForm.Show();
        }
        /// <summary>
        /// Метод добавляет элемент в базу данных, если объект с таким названием не существует.
        /// Иначе предлагает редактировать существующий элемент.
        /// </summary>
        /// <param name="item">объект класса Item</param>
        public void AddToDB(Item item)
        {
            if (db.addNote(item))
            {
                updateTable(db.DBToList());
            }
            else
            {
                if (Warning("Товар с данным наименованием уже существует.\nРедактировать его?"))
                {
                    addingForm.Close();
                    item = db.findNoteByName(item.name).FirstOrDefault();
                    editingForm = new EditingForm(this, item);
                    editingForm.Show();
                }
            }

        }
        /// <summary>
        /// Метод обновляет таблицу
        /// </summary>
        /// <param name="list">текущий список List товаров в базе данных - объектов класса Item</param>
        public void updateTable(List<Item> list)
        {
            dataGridView1.Rows.Clear();
            foreach (Item i in list)
            {
                dataGridView1.Rows.Add(i.id, i.name, i.quantity, i.productionDate.ToString("dd:MM:yyyy"), i.expirationDate.ToString("dd:MM:yyyy"));
            }
        }

        private void drop_button_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            if (Warning($"Удалить товар с ID {id}?"))
            {
                if (db.removeNote(id))
                {
                    MessageBox.Show($"Элемент с ID = {numericUpDown1.Value} ,был удален.");
                    updateTable(db.DBToList());
                }
                else { MessageBox.Show($"Элемент с ID = {numericUpDown1.Value} отсутствует.\nВозможно, ID указан неверно."); }
            }
        }
        private bool Warning(string message)
        {
            DialogResult result = MessageBox.Show(
                    message,
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2
                    );
            if (result == DialogResult.Yes) return true;
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void radioButtonFindName_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.findNoteByName(textBox1.Text));
            radioButtonFindName.Checked = false;
        }

        private void radioButtonFindID_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.findNoteByID((int)numericUpDown2.Value));
            radioButtonFindID.Checked = false;
        }

        private void radioButtonFindQuantity_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.findNoteByName((int)numericUpDown3.Value));
            radioButtonFindQuantity.Checked = false;
        }

        private void radioButtonSortName_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("name", ""));
            radioButtonSortName.Checked = false;
        }

        private void radioButtonSortID_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("id", ""));
            radioButtonSortID.Checked = false;
        }

        private void radioButtonSortProduction_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("productionDate", "DESC"));
            radioButtonSortProduction.Checked = false;
        }

        private void radioButtonSortExpiration_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("expirationDate", ""));
            radioButtonSortExpiration.Checked = false;
        }

        private void radioButtonQuantityLess_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("quantity", ""));
            radioButtonQuantityLess.Checked = false;
        }

        private void radioButtonQuantityMore_CheckedChanged(object sender, EventArgs e)
        {
            updateTable(db.sort("quantity", "DESC"));
            radioButtonQuantityMore.Checked = false;
        }

        private void toFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                db.DBToFile(saveFileDialog1.OpenFile());
                MessageBox.Show($"Файл сохранен в {saveFileDialog1.FileName}");
            }
            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addingForm != null)
            {
                if (addingForm.Visible)
                {
                    addingForm.Close();
                }
            }
            if (editingForm != null)
            {
                if (editingForm.Visible)
                {
                    editingForm.Close();
                }
            }
            startingForm.BlockCreating(false);
        }

        private void EditNotebutton_Click(object sender, EventArgs e)
        {

            try
            {
                Item element = db.findNoteByID((int)numericUpDown4.Value).FirstOrDefault();
                if (element == null)
                {
                    MessageBox.Show($"Элемент с ID = {numericUpDown4.Value} не найден.");
                    return;
                }
                editingForm = new EditingForm(this, element);
                editingForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Вы не должны были здесь оказаться, но: {ex.Message}");
            }
        }
    }
}
