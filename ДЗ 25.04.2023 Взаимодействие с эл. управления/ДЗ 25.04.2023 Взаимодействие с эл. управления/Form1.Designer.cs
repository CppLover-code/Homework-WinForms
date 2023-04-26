namespace ДЗ_25._04._2023_Взаимодействие_с_эл.управления
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Surname = new System.Windows.Forms.Label();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.NName = new System.Windows.Forms.Label();
            this.tOSurname = new System.Windows.Forms.TextBox();
            this.OSurname = new System.Windows.Forms.Label();
            this.tSex = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.tFamStatus = new System.Windows.Forms.TextBox();
            this.FamStatus = new System.Windows.Forms.Label();
            this.tAddInfo = new System.Windows.Forms.TextBox();
            this.AddInfo = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(13, 13);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(66, 16);
            this.Surname.TabIndex = 0;
            this.Surname.Text = "Фамилия";
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(16, 32);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(200, 22);
            this.tSurname.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(16, 84);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(200, 22);
            this.tName.TabIndex = 3;
            // 
            // NName
            // 
            this.NName.AutoSize = true;
            this.NName.Location = new System.Drawing.Point(13, 65);
            this.NName.Name = "NName";
            this.NName.Size = new System.Drawing.Size(33, 16);
            this.NName.TabIndex = 2;
            this.NName.Text = "Имя";
            // 
            // tOSurname
            // 
            this.tOSurname.Location = new System.Drawing.Point(16, 137);
            this.tOSurname.Name = "tOSurname";
            this.tOSurname.Size = new System.Drawing.Size(200, 22);
            this.tOSurname.TabIndex = 5;
            // 
            // OSurname
            // 
            this.OSurname.AutoSize = true;
            this.OSurname.Location = new System.Drawing.Point(13, 118);
            this.OSurname.Name = "OSurname";
            this.OSurname.Size = new System.Drawing.Size(70, 16);
            this.OSurname.TabIndex = 4;
            this.OSurname.Text = "Отчество";
            // 
            // tSex
            // 
            this.tSex.Location = new System.Drawing.Point(16, 190);
            this.tSex.Name = "tSex";
            this.tSex.Size = new System.Drawing.Size(200, 22);
            this.tSex.TabIndex = 7;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(13, 171);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(33, 16);
            this.Sex.TabIndex = 6;
            this.Sex.Text = "Пол";
            // 
            // tDate
            // 
            this.tDate.Location = new System.Drawing.Point(16, 245);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(200, 22);
            this.tDate.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(13, 226);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(106, 16);
            this.Date.TabIndex = 8;
            this.Date.Text = "Дата рождения";
            // 
            // tFamStatus
            // 
            this.tFamStatus.Location = new System.Drawing.Point(16, 298);
            this.tFamStatus.Name = "tFamStatus";
            this.tFamStatus.Size = new System.Drawing.Size(200, 22);
            this.tFamStatus.TabIndex = 11;
            // 
            // FamStatus
            // 
            this.FamStatus.AutoSize = true;
            this.FamStatus.Location = new System.Drawing.Point(13, 279);
            this.FamStatus.Name = "FamStatus";
            this.FamStatus.Size = new System.Drawing.Size(121, 16);
            this.FamStatus.TabIndex = 10;
            this.FamStatus.Text = "Семейный статус";
            // 
            // tAddInfo
            // 
            this.tAddInfo.Location = new System.Drawing.Point(16, 353);
            this.tAddInfo.Name = "tAddInfo";
            this.tAddInfo.Size = new System.Drawing.Size(200, 22);
            this.tAddInfo.TabIndex = 13;
            // 
            // AddInfo
            // 
            this.AddInfo.AutoSize = true;
            this.AddInfo.Location = new System.Drawing.Point(13, 334);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(203, 16);
            this.AddInfo.TabIndex = 12;
            this.AddInfo.Text = "Дополнительная информация";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(16, 393);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(103, 42);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bSave_MouseClick);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(125, 393);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(103, 42);
            this.bLoad.TabIndex = 15;
            this.bLoad.Text = "Загрузить";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bLoad_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tAddInfo);
            this.Controls.Add(this.AddInfo);
            this.Controls.Add(this.tFamStatus);
            this.Controls.Add(this.FamStatus);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.tSex);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.tOSurname);
            this.Controls.Add(this.OSurname);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.NName);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.Surname);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label NName;
        private System.Windows.Forms.TextBox tOSurname;
        private System.Windows.Forms.Label OSurname;
        private System.Windows.Forms.TextBox tSex;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox tFamStatus;
        private System.Windows.Forms.Label FamStatus;
        private System.Windows.Forms.TextBox tAddInfo;
        private System.Windows.Forms.Label AddInfo;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

