﻿namespace ДЗ_05._05._2023_Создание_доп.форм
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1GoodsInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2Detail = new System.Windows.Forms.TextBox();
            this.textBox3Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1AddProd = new System.Windows.Forms.Button();
            this.panel1Edit = new System.Windows.Forms.Panel();
            this.button3Cancel = new System.Windows.Forms.Button();
            this.button2Refresh = new System.Windows.Forms.Button();
            this.button1Edit = new System.Windows.Forms.Button();
            this.button4Delete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1AddEdit = new System.Windows.Forms.Panel();
            this.panel1Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1GoodsInfo
            // 
            this.listBox1GoodsInfo.FormattingEnabled = true;
            this.listBox1GoodsInfo.HorizontalScrollbar = true;
            this.listBox1GoodsInfo.Location = new System.Drawing.Point(13, 40);
            this.listBox1GoodsInfo.Name = "listBox1GoodsInfo";
            this.listBox1GoodsInfo.ScrollAlwaysVisible = true;
            this.listBox1GoodsInfo.Size = new System.Drawing.Size(251, 225);
            this.listBox1GoodsInfo.TabIndex = 0;
            this.listBox1GoodsInfo.SelectedIndexChanged += new System.EventHandler(this.listBox1GoodsInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация о товаре";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // textBox1Title
            // 
            this.textBox1Title.Location = new System.Drawing.Point(283, 43);
            this.textBox1Title.Name = "textBox1Title";
            this.textBox1Title.Size = new System.Drawing.Size(124, 20);
            this.textBox1Title.TabIndex = 3;
            this.textBox1Title.Click += new System.EventHandler(this.textBoxForm2_TextChanged);
            this.textBox1Title.TextChanged += new System.EventHandler(this.textBoxForm2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Характеристика";
            // 
            // textBox2Detail
            // 
            this.textBox2Detail.Location = new System.Drawing.Point(283, 86);
            this.textBox2Detail.Name = "textBox2Detail";
            this.textBox2Detail.Size = new System.Drawing.Size(124, 20);
            this.textBox2Detail.TabIndex = 5;
            this.textBox2Detail.Click += new System.EventHandler(this.textBoxForm2_TextChanged);
            // 
            // textBox3Description
            // 
            this.textBox3Description.Location = new System.Drawing.Point(283, 134);
            this.textBox3Description.Name = "textBox3Description";
            this.textBox3Description.Size = new System.Drawing.Size(124, 20);
            this.textBox3Description.TabIndex = 7;
            this.textBox3Description.Click += new System.EventHandler(this.textBoxForm2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // textBox4Price
            // 
            this.textBox4Price.Location = new System.Drawing.Point(283, 182);
            this.textBox4Price.Name = "textBox4Price";
            this.textBox4Price.Size = new System.Drawing.Size(124, 20);
            this.textBox4Price.TabIndex = 9;
            this.textBox4Price.Click += new System.EventHandler(this.textBoxForm2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена";
            // 
            // button1AddProd
            // 
            this.button1AddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1AddProd.Enabled = false;
            this.button1AddProd.Location = new System.Drawing.Point(283, 221);
            this.button1AddProd.Name = "button1AddProd";
            this.button1AddProd.Size = new System.Drawing.Size(124, 47);
            this.button1AddProd.TabIndex = 10;
            this.button1AddProd.Text = "Добавить товар";
            this.button1AddProd.UseVisualStyleBackColor = true;
            this.button1AddProd.Click += new System.EventHandler(this.button1AddProd_Click);
            // 
            // panel1Edit
            // 
            this.panel1Edit.BackColor = System.Drawing.Color.Transparent;
            this.panel1Edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1Edit.Controls.Add(this.button3Cancel);
            this.panel1Edit.Controls.Add(this.button4Delete);
            this.panel1Edit.Controls.Add(this.button1Edit);
            this.panel1Edit.Controls.Add(this.button2Refresh);
            this.panel1Edit.Location = new System.Drawing.Point(12, 274);
            this.panel1Edit.Name = "panel1Edit";
            this.panel1Edit.Size = new System.Drawing.Size(399, 48);
            this.panel1Edit.TabIndex = 11;
            // 
            // button3Cancel
            // 
            this.button3Cancel.BackColor = System.Drawing.Color.Beige;
            this.button3Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3Cancel.Enabled = false;
            this.button3Cancel.Location = new System.Drawing.Point(300, 3);
            this.button3Cancel.Name = "button3Cancel";
            this.button3Cancel.Size = new System.Drawing.Size(94, 41);
            this.button3Cancel.TabIndex = 2;
            this.button3Cancel.Text = "Отменить";
            this.button3Cancel.UseVisualStyleBackColor = false;
            this.button3Cancel.Click += new System.EventHandler(this.button3Cancel_Click);
            // 
            // button2Refresh
            // 
            this.button2Refresh.BackColor = System.Drawing.Color.Beige;
            this.button2Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2Refresh.Enabled = false;
            this.button2Refresh.Location = new System.Drawing.Point(200, 3);
            this.button2Refresh.Name = "button2Refresh";
            this.button2Refresh.Size = new System.Drawing.Size(94, 41);
            this.button2Refresh.TabIndex = 1;
            this.button2Refresh.Text = "Обновить";
            this.button2Refresh.UseVisualStyleBackColor = false;
            this.button2Refresh.Click += new System.EventHandler(this.button2Refresh_Click);
            // 
            // button1Edit
            // 
            this.button1Edit.BackColor = System.Drawing.Color.Beige;
            this.button1Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Edit.Enabled = false;
            this.button1Edit.Location = new System.Drawing.Point(3, 3);
            this.button1Edit.Name = "button1Edit";
            this.button1Edit.Size = new System.Drawing.Size(94, 41);
            this.button1Edit.TabIndex = 0;
            this.button1Edit.Text = "Редактировать";
            this.button1Edit.UseVisualStyleBackColor = false;
            this.button1Edit.Click += new System.EventHandler(this.button1Edit_Click);
            // 
            // button4Delete
            // 
            this.button4Delete.BackColor = System.Drawing.Color.Beige;
            this.button4Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4Delete.Enabled = false;
            this.button4Delete.Location = new System.Drawing.Point(103, 3);
            this.button4Delete.Name = "button4Delete";
            this.button4Delete.Size = new System.Drawing.Size(94, 41);
            this.button4Delete.TabIndex = 12;
            this.button4Delete.Text = "Удалить";
            this.button4Delete.UseVisualStyleBackColor = false;
            this.button4Delete.Click += new System.EventHandler(this.button4Delete_Click);
            // 
            // panel1AddEdit
            // 
            this.panel1AddEdit.Location = new System.Drawing.Point(270, 24);
            this.panel1AddEdit.Name = "panel1AddEdit";
            this.panel1AddEdit.Size = new System.Drawing.Size(146, 191);
            this.panel1AddEdit.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 334);
            this.Controls.Add(this.panel1Edit);
            this.Controls.Add(this.button1AddProd);
            this.Controls.Add(this.textBox4Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2Detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1GoodsInfo);
            this.Controls.Add(this.panel1AddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Добавление/Изменение товара";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1Edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1GoodsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2Detail;
        private System.Windows.Forms.TextBox textBox3Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1AddProd;
        private System.Windows.Forms.Panel panel1Edit;
        private System.Windows.Forms.Button button3Cancel;
        private System.Windows.Forms.Button button2Refresh;
        private System.Windows.Forms.Button button1Edit;
        private System.Windows.Forms.Button button4Delete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1AddEdit;
    }
}