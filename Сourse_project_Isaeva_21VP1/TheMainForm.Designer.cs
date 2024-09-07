namespace Сourse_project_Isaeva_21VP1
{
    partial class TheMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheMainForm));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.drop_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.toFileButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropBaseButton = new System.Windows.Forms.Button();
            this.radioButtonSortName = new System.Windows.Forms.RadioButton();
            this.radioButtonQuantityLess = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonQuantityMore = new System.Windows.Forms.RadioButton();
            this.radioButtonSortProduction = new System.Windows.Forms.RadioButton();
            this.radioButtonSortExpiration = new System.Windows.Forms.RadioButton();
            this.radioButtonSortID = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFindName = new System.Windows.Forms.RadioButton();
            this.radioButtonFindID = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFindQuantity = new System.Windows.Forms.RadioButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.EditNotebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(679, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // drop_button
            // 
            this.drop_button.Location = new System.Drawing.Point(532, 12);
            this.drop_button.Name = "drop_button";
            this.drop_button.Size = new System.Drawing.Size(145, 23);
            this.drop_button.TabIndex = 12;
            this.drop_button.Text = "Удалить элемент с ID = ";
            this.drop_button.UseVisualStyleBackColor = true;
            this.drop_button.Click += new System.EventHandler(this.drop_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.add_button.Location = new System.Drawing.Point(12, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(145, 23);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Добавить элемент";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // toFileButton
            // 
            this.toFileButton.Location = new System.Drawing.Point(12, 488);
            this.toFileButton.Name = "toFileButton";
            this.toFileButton.Size = new System.Drawing.Size(145, 23);
            this.toFileButton.TabIndex = 10;
            this.toFileButton.Text = "Записать в файл";
            this.toFileButton.UseVisualStyleBackColor = true;
            this.toFileButton.Click += new System.EventHandler(this.toFileButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 312);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID товара";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование товара";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество на складе";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата производства партии";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата истечения срока годности";
            this.Column5.Name = "Column5";
            // 
            // dropBaseButton
            // 
            this.dropBaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dropBaseButton.Location = new System.Drawing.Point(650, 488);
            this.dropBaseButton.Name = "dropBaseButton";
            this.dropBaseButton.Size = new System.Drawing.Size(145, 23);
            this.dropBaseButton.TabIndex = 8;
            this.dropBaseButton.Text = "Удалить базу данных";
            this.dropBaseButton.UseVisualStyleBackColor = false;
            this.dropBaseButton.Click += new System.EventHandler(this.dropBaseButton_Click);
            // 
            // radioButtonSortName
            // 
            this.radioButtonSortName.AutoSize = true;
            this.radioButtonSortName.Location = new System.Drawing.Point(15, 401);
            this.radioButtonSortName.Name = "radioButtonSortName";
            this.radioButtonSortName.Size = new System.Drawing.Size(119, 17);
            this.radioButtonSortName.TabIndex = 14;
            this.radioButtonSortName.TabStop = true;
            this.radioButtonSortName.Text = "по наименованию ";
            this.radioButtonSortName.UseVisualStyleBackColor = true;
            this.radioButtonSortName.CheckedChanged += new System.EventHandler(this.radioButtonSortName_CheckedChanged);
            // 
            // radioButtonQuantityLess
            // 
            this.radioButtonQuantityLess.AutoSize = true;
            this.radioButtonQuantityLess.Location = new System.Drawing.Point(149, 424);
            this.radioButtonQuantityLess.Name = "radioButtonQuantityLess";
            this.radioButtonQuantityLess.Size = new System.Drawing.Size(190, 17);
            this.radioButtonQuantityLess.TabIndex = 15;
            this.radioButtonQuantityLess.TabStop = true;
            this.radioButtonQuantityLess.Text = "по количеству (сначала меньше)";
            this.radioButtonQuantityLess.UseVisualStyleBackColor = true;
            this.radioButtonQuantityLess.CheckedChanged += new System.EventHandler(this.radioButtonQuantityLess_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(87, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сортировать товары:";
            // 
            // radioButtonQuantityMore
            // 
            this.radioButtonQuantityMore.AutoSize = true;
            this.radioButtonQuantityMore.Location = new System.Drawing.Point(149, 447);
            this.radioButtonQuantityMore.Name = "radioButtonQuantityMore";
            this.radioButtonQuantityMore.Size = new System.Drawing.Size(188, 17);
            this.radioButtonQuantityMore.TabIndex = 17;
            this.radioButtonQuantityMore.TabStop = true;
            this.radioButtonQuantityMore.Text = "по количеству (сначала больше)";
            this.radioButtonQuantityMore.UseVisualStyleBackColor = true;
            this.radioButtonQuantityMore.CheckedChanged += new System.EventHandler(this.radioButtonQuantityMore_CheckedChanged);
            // 
            // radioButtonSortProduction
            // 
            this.radioButtonSortProduction.AutoSize = true;
            this.radioButtonSortProduction.Location = new System.Drawing.Point(15, 447);
            this.radioButtonSortProduction.Name = "radioButtonSortProduction";
            this.radioButtonSortProduction.Size = new System.Drawing.Size(89, 17);
            this.radioButtonSortProduction.TabIndex = 18;
            this.radioButtonSortProduction.TabStop = true;
            this.radioButtonSortProduction.Text = "по свежести";
            this.radioButtonSortProduction.UseVisualStyleBackColor = true;
            this.radioButtonSortProduction.CheckedChanged += new System.EventHandler(this.radioButtonSortProduction_CheckedChanged);
            // 
            // radioButtonSortExpiration
            // 
            this.radioButtonSortExpiration.AutoSize = true;
            this.radioButtonSortExpiration.Location = new System.Drawing.Point(149, 401);
            this.radioButtonSortExpiration.Name = "radioButtonSortExpiration";
            this.radioButtonSortExpiration.Size = new System.Drawing.Size(124, 17);
            this.radioButtonSortExpiration.TabIndex = 19;
            this.radioButtonSortExpiration.TabStop = true;
            this.radioButtonSortExpiration.Text = "испортятся раньше";
            this.radioButtonSortExpiration.UseVisualStyleBackColor = true;
            this.radioButtonSortExpiration.CheckedChanged += new System.EventHandler(this.radioButtonSortExpiration_CheckedChanged);
            // 
            // radioButtonSortID
            // 
            this.radioButtonSortID.AutoSize = true;
            this.radioButtonSortID.Location = new System.Drawing.Point(15, 424);
            this.radioButtonSortID.Name = "radioButtonSortID";
            this.radioButtonSortID.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSortID.TabIndex = 20;
            this.radioButtonSortID.TabStop = true;
            this.radioButtonSortID.Text = "по ID";
            this.radioButtonSortID.UseVisualStyleBackColor = true;
            this.radioButtonSortID.CheckedChanged += new System.EventHandler(this.radioButtonSortID_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(427, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Искать товары:";
            // 
            // radioButtonFindName
            // 
            this.radioButtonFindName.AutoSize = true;
            this.radioButtonFindName.Location = new System.Drawing.Point(410, 398);
            this.radioButtonFindName.Name = "radioButtonFindName";
            this.radioButtonFindName.Size = new System.Drawing.Size(131, 17);
            this.radioButtonFindName.TabIndex = 22;
            this.radioButtonFindName.TabStop = true;
            this.radioButtonFindName.Text = "по наименованию <<";
            this.radioButtonFindName.UseVisualStyleBackColor = true;
            this.radioButtonFindName.CheckedChanged += new System.EventHandler(this.radioButtonFindName_CheckedChanged);
            // 
            // radioButtonFindID
            // 
            this.radioButtonFindID.AutoSize = true;
            this.radioButtonFindID.Location = new System.Drawing.Point(410, 424);
            this.radioButtonFindID.Name = "radioButtonFindID";
            this.radioButtonFindID.Size = new System.Drawing.Size(60, 17);
            this.radioButtonFindID.TabIndex = 23;
            this.radioButtonFindID.TabStop = true;
            this.radioButtonFindID.Text = "по ID =";
            this.radioButtonFindID.UseVisualStyleBackColor = true;
            this.radioButtonFindID.CheckedChanged += new System.EventHandler(this.radioButtonFindID_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(476, 421);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(537, 394);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Наименование";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = ">>";
            // 
            // radioButtonFindQuantity
            // 
            this.radioButtonFindQuantity.AutoSize = true;
            this.radioButtonFindQuantity.Location = new System.Drawing.Point(410, 447);
            this.radioButtonFindQuantity.Name = "radioButtonFindQuantity";
            this.radioButtonFindQuantity.Size = new System.Drawing.Size(163, 17);
            this.radioButtonFindQuantity.TabIndex = 27;
            this.radioButtonFindQuantity.TabStop = true;
            this.radioButtonFindQuantity.Text = "по количеству на складе = ";
            this.radioButtonFindQuantity.UseVisualStyleBackColor = true;
            this.radioButtonFindQuantity.CheckedChanged += new System.EventHandler(this.radioButtonFindQuantity_CheckedChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(570, 444);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown3.TabIndex = 28;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(382, 14);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown4.TabIndex = 31;
            // 
            // EditNotebutton
            // 
            this.EditNotebutton.Location = new System.Drawing.Point(209, 12);
            this.EditNotebutton.Name = "EditNotebutton";
            this.EditNotebutton.Size = new System.Drawing.Size(171, 23);
            this.EditNotebutton.TabIndex = 32;
            this.EditNotebutton.Text = "Редактировать элемент с ID = ";
            this.EditNotebutton.UseVisualStyleBackColor = true;
            this.EditNotebutton.Click += new System.EventHandler(this.EditNotebutton_Click);
            // 
            // TheMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 523);
            this.Controls.Add(this.EditNotebutton);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.radioButtonFindQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.radioButtonFindID);
            this.Controls.Add(this.radioButtonFindName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonSortID);
            this.Controls.Add(this.radioButtonSortExpiration);
            this.Controls.Add(this.radioButtonSortProduction);
            this.Controls.Add(this.radioButtonQuantityMore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonQuantityLess);
            this.Controls.Add(this.radioButtonSortName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.drop_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.toFileButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dropBaseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheMainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.TheMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button drop_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button toFileButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dropBaseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton radioButtonSortName;
        private System.Windows.Forms.RadioButton radioButtonQuantityLess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonQuantityMore;
        private System.Windows.Forms.RadioButton radioButtonSortProduction;
        private System.Windows.Forms.RadioButton radioButtonSortExpiration;
        private System.Windows.Forms.RadioButton radioButtonSortID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonFindName;
        private System.Windows.Forms.RadioButton radioButtonFindID;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonFindQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button EditNotebutton;
    }
}