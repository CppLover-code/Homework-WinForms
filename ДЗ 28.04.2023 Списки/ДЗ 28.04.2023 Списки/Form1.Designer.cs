﻿namespace ДЗ_28._04._2023_Списки
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1Name = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2Surname = new System.Windows.Forms.TextBox();
            this.label2Surname = new System.Windows.Forms.Label();
            this.textBox3Mail = new System.Windows.Forms.TextBox();
            this.label3Mail = new System.Windows.Forms.Label();
            this.textBox4Tel = new System.Windows.Forms.TextBox();
            this.label4Tel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelListPerson = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Name
            // 
            this.label1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Name.Location = new System.Drawing.Point(13, 13);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(100, 14);
            this.label1Name.TabIndex = 0;
            this.label1Name.Text = "Имя*";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(13, 30);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(118, 20);
            this.textBox1Name.TabIndex = 1;
            this.textBox1Name.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox2Surname
            // 
            this.textBox2Surname.Location = new System.Drawing.Point(13, 81);
            this.textBox2Surname.Name = "textBox2Surname";
            this.textBox2Surname.Size = new System.Drawing.Size(118, 20);
            this.textBox2Surname.TabIndex = 3;
            this.textBox2Surname.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2Surname
            // 
            this.label2Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Surname.Location = new System.Drawing.Point(13, 64);
            this.label2Surname.Name = "label2Surname";
            this.label2Surname.Size = new System.Drawing.Size(100, 14);
            this.label2Surname.TabIndex = 2;
            this.label2Surname.Text = "Фамилия*";
            // 
            // textBox3Mail
            // 
            this.textBox3Mail.Location = new System.Drawing.Point(13, 135);
            this.textBox3Mail.Name = "textBox3Mail";
            this.textBox3Mail.Size = new System.Drawing.Size(118, 20);
            this.textBox3Mail.TabIndex = 5;
            // 
            // label3Mail
            // 
            this.label3Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Mail.Location = new System.Drawing.Point(13, 118);
            this.label3Mail.Name = "label3Mail";
            this.label3Mail.Size = new System.Drawing.Size(100, 14);
            this.label3Mail.TabIndex = 4;
            this.label3Mail.Text = "e-mail";
            // 
            // textBox4Tel
            // 
            this.textBox4Tel.Location = new System.Drawing.Point(13, 189);
            this.textBox4Tel.Name = "textBox4Tel";
            this.textBox4Tel.Size = new System.Drawing.Size(118, 20);
            this.textBox4Tel.TabIndex = 7;
            // 
            // label4Tel
            // 
            this.label4Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Tel.Location = new System.Drawing.Point(13, 172);
            this.label4Tel.Name = "label4Tel";
            this.label4Tel.Size = new System.Drawing.Size(100, 14);
            this.label4Tel.TabIndex = 6;
            this.label4Tel.Text = "Телефон";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(13, 225);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(155, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 173);
            this.listBox1.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(303, 35);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 43);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(303, 89);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 43);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelListPerson
            // 
            this.labelListPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListPerson.Location = new System.Drawing.Point(155, 13);
            this.labelListPerson.Name = "labelListPerson";
            this.labelListPerson.Size = new System.Drawing.Size(131, 14);
            this.labelListPerson.TabIndex = 12;
            this.labelListPerson.Text = "Список анкет";
            this.labelListPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(13, 274);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 43);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(303, 143);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(96, 43);
            this.buttonShowInfo.TabIndex = 14;
            this.buttonShowInfo.Text = "Показать анкету";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(155, 225);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(244, 43);
            this.buttonExport.TabIndex = 15;
            this.buttonExport.Text = "Экспорт информации";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(155, 274);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(244, 43);
            this.buttonImport.TabIndex = 16;
            this.buttonImport.Text = "Импорт информации";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelListPerson);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox4Tel);
            this.Controls.Add(this.label4Tel);
            this.Controls.Add(this.textBox3Mail);
            this.Controls.Add(this.label3Mail);
            this.Controls.Add(this.textBox2Surname);
            this.Controls.Add(this.label2Surname);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label1Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.TextBox textBox2Surname;
        private System.Windows.Forms.Label label2Surname;
        private System.Windows.Forms.TextBox textBox3Mail;
        private System.Windows.Forms.Label label3Mail;
        private System.Windows.Forms.TextBox textBox4Tel;
        private System.Windows.Forms.Label label4Tel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelListPerson;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
    }
}

