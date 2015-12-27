namespace Debit
{
    partial class MainForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBalanse = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lKategory = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxKategory = new System.Windows.Forms.TextBox();
            this.dataGridViewEntries = new System.Windows.Forms.DataGridView();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(646, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.Location = new System.Drawing.Point(77, 6);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(644, 20);
            this.textBoxAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Баланс";
            // 
            // textBoxBalanse
            // 
            this.textBoxBalanse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBalanse.Location = new System.Drawing.Point(59, 406);
            this.textBoxBalanse.Name = "textBoxBalanse";
            this.textBoxBalanse.ReadOnly = true;
            this.textBoxBalanse.Size = new System.Drawing.Size(662, 20);
            this.textBoxBalanse.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(77, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(644, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(18, 39);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(33, 13);
            this.lDate.TabIndex = 6;
            this.lDate.Text = "Дата";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(18, 62);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(57, 13);
            this.lDescription.TabIndex = 7;
            this.lDescription.Text = "Описание";
            // 
            // lKategory
            // 
            this.lKategory.AutoSize = true;
            this.lKategory.Location = new System.Drawing.Point(18, 88);
            this.lKategory.Name = "lKategory";
            this.lKategory.Size = new System.Drawing.Size(60, 13);
            this.lKategory.TabIndex = 8;
            this.lKategory.Text = "Категория";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(77, 59);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(644, 20);
            this.textBoxDescription.TabIndex = 9;
            // 
            // textBoxKategory
            // 
            this.textBoxKategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKategory.Location = new System.Drawing.Point(77, 85);
            this.textBoxKategory.Name = "textBoxKategory";
            this.textBoxKategory.Size = new System.Drawing.Size(644, 20);
            this.textBoxKategory.TabIndex = 10;
            // 
            // dataGridViewEntries
            // 
            this.dataGridViewEntries.AllowUserToAddRows = false;
            this.dataGridViewEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnAmount,
            this.ColumnDate,
            this.ColumnDescription,
            this.ColumnCategory});
            this.dataGridViewEntries.Location = new System.Drawing.Point(15, 140);
            this.dataGridViewEntries.Name = "dataGridViewEntries";
            this.dataGridViewEntries.Size = new System.Drawing.Size(706, 260);
            this.dataGridViewEntries.TabIndex = 11;
            this.dataGridViewEntries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntries_CellValueChanged);
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Тип записи";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Сумма";
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.Name = "ColumnCategory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 438);
            this.Controls.Add(this.dataGridViewEntries);
            this.Controls.Add(this.textBoxKategory);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.lKategory);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.textBoxBalanse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBalanse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lKategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxKategory;
        private System.Windows.Forms.DataGridView dataGridViewEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
    }
}

