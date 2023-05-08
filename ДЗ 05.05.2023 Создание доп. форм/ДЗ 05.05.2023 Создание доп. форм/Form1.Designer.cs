namespace ДЗ_05._05._2023_Создание_доп.форм
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1Sales = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1TotalCost = new System.Windows.Forms.TextBox();
            this.listBox1Sales = new System.Windows.Forms.ListBox();
            this.comboBox1Goods = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1PriceOfProd = new System.Windows.Forms.TextBox();
            this.button1AddToListSales = new System.Windows.Forms.Button();
            this.button2ChangeListGoods = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1Sales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Sales
            // 
            this.panel1Sales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1Sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1Sales.Controls.Add(this.label6);
            this.panel1Sales.Controls.Add(this.label2);
            this.panel1Sales.Controls.Add(this.label1);
            this.panel1Sales.Controls.Add(this.textBox1TotalCost);
            this.panel1Sales.Controls.Add(this.listBox1Sales);
            this.panel1Sales.Location = new System.Drawing.Point(12, 12);
            this.panel1Sales.Name = "panel1Sales";
            this.panel1Sales.Size = new System.Drawing.Size(225, 303);
            this.panel1Sales.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общая стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список продаж";
            // 
            // textBox1TotalCost
            // 
            this.textBox1TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1TotalCost.Location = new System.Drawing.Point(12, 259);
            this.textBox1TotalCost.Name = "textBox1TotalCost";
            this.textBox1TotalCost.ReadOnly = true;
            this.textBox1TotalCost.Size = new System.Drawing.Size(178, 31);
            this.textBox1TotalCost.TabIndex = 1;
            this.textBox1TotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1Sales
            // 
            this.listBox1Sales.FormattingEnabled = true;
            this.listBox1Sales.HorizontalScrollbar = true;
            this.listBox1Sales.Location = new System.Drawing.Point(12, 26);
            this.listBox1Sales.Name = "listBox1Sales";
            this.listBox1Sales.ScrollAlwaysVisible = true;
            this.listBox1Sales.Size = new System.Drawing.Size(199, 199);
            this.listBox1Sales.TabIndex = 0;
            // 
            // comboBox1Goods
            // 
            this.comboBox1Goods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Goods.FormattingEnabled = true;
            this.comboBox1Goods.Location = new System.Drawing.Point(16, 26);
            this.comboBox1Goods.Name = "comboBox1Goods";
            this.comboBox1Goods.Size = new System.Drawing.Size(132, 21);
            this.comboBox1Goods.TabIndex = 1;
            this.comboBox1Goods.SelectedIndexChanged += new System.EventHandler(this.comboBox1Goods_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Список товаров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена выбранного товара";
            // 
            // textBox1PriceOfProd
            // 
            this.textBox1PriceOfProd.Location = new System.Drawing.Point(16, 88);
            this.textBox1PriceOfProd.Name = "textBox1PriceOfProd";
            this.textBox1PriceOfProd.ReadOnly = true;
            this.textBox1PriceOfProd.Size = new System.Drawing.Size(96, 20);
            this.textBox1PriceOfProd.TabIndex = 4;
            // 
            // button1AddToListSales
            // 
            this.button1AddToListSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1AddToListSales.Enabled = false;
            this.button1AddToListSales.Location = new System.Drawing.Point(13, 125);
            this.button1AddToListSales.Name = "button1AddToListSales";
            this.button1AddToListSales.Size = new System.Drawing.Size(135, 51);
            this.button1AddToListSales.TabIndex = 5;
            this.button1AddToListSales.Text = "Добавить в список";
            this.button1AddToListSales.UseVisualStyleBackColor = true;
            this.button1AddToListSales.Click += new System.EventHandler(this.button1AddToListSales_Click);
            // 
            // button2ChangeListGoods
            // 
            this.button2ChangeListGoods.BackColor = System.Drawing.Color.Beige;
            this.button2ChangeListGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2ChangeListGoods.Location = new System.Drawing.Point(257, 240);
            this.button2ChangeListGoods.Name = "button2ChangeListGoods";
            this.button2ChangeListGoods.Size = new System.Drawing.Size(138, 63);
            this.button2ChangeListGoods.TabIndex = 6;
            this.button2ChangeListGoods.Text = "Изменить список товаров";
            this.button2ChangeListGoods.UseVisualStyleBackColor = false;
            this.button2ChangeListGoods.Click += new System.EventHandler(this.button2ChangeListGoods_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1AddToListSales);
            this.panel1.Controls.Add(this.comboBox1Goods);
            this.panel1.Controls.Add(this.textBox1PriceOfProd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(244, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 189);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "грн.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 327);
            this.Controls.Add(this.button2ChangeListGoods);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1Sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа компонентов компьютера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1Sales.ResumeLayout(false);
            this.panel1Sales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Sales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1TotalCost;
        private System.Windows.Forms.ListBox listBox1Sales;
        private System.Windows.Forms.ComboBox comboBox1Goods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1PriceOfProd;
        private System.Windows.Forms.Button button1AddToListSales;
        private System.Windows.Forms.Button button2ChangeListGoods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

