namespace ДЗ_09._05._2023_Меню
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Create = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1SelectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1EditorSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1Editor = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 82);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Copy;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton1Copy_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Cut__2_;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton1Cut_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Paste;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton1Paste_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripButton1Open
            // 
            this.toolStripButton1Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Open.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Open;
            this.toolStripButton1Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Open.Name = "toolStripButton1Open";
            this.toolStripButton1Open.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Open.Text = "Открыть";
            this.toolStripButton1Open.Click += new System.EventHandler(this.toolStripButton1Open_Click);
            // 
            // toolStripButton1Create
            // 
            this.toolStripButton1Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Create.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Create;
            this.toolStripButton1Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Create.Name = "toolStripButton1Create";
            this.toolStripButton1Create.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Create.Text = "Новый документ";
            this.toolStripButton1Create.Click += new System.EventHandler(this.toolStripButton1Create_Click);
            // 
            // toolStripButton1Save
            // 
            this.toolStripButton1Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Save.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Save;
            this.toolStripButton1Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Save.Name = "toolStripButton1Save";
            this.toolStripButton1Save.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Save.Text = "Сохранить";
            this.toolStripButton1Save.Click += new System.EventHandler(this.toolStripButton1Save_Click);
            // 
            // toolStripButton1SaveAs
            // 
            this.toolStripButton1SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1SaveAs.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Save_as;
            this.toolStripButton1SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1SaveAs.Name = "toolStripButton1SaveAs";
            this.toolStripButton1SaveAs.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1SaveAs.Text = "Сохранить как";
            this.toolStripButton1SaveAs.Click += new System.EventHandler(this.toolStripButton1SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(15, 25);
            // 
            // toolStripButton1Copy
            // 
            this.toolStripButton1Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Copy.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Copy;
            this.toolStripButton1Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Copy.Name = "toolStripButton1Copy";
            this.toolStripButton1Copy.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Copy.Text = "Копировать";
            this.toolStripButton1Copy.Click += new System.EventHandler(this.toolStripButton1Copy_Click);
            // 
            // toolStripButton1Paste
            // 
            this.toolStripButton1Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Paste.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Paste;
            this.toolStripButton1Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Paste.Name = "toolStripButton1Paste";
            this.toolStripButton1Paste.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Paste.Text = "Вставить";
            this.toolStripButton1Paste.Click += new System.EventHandler(this.toolStripButton1Paste_Click);
            // 
            // toolStripButton1Cut
            // 
            this.toolStripButton1Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Cut.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Cut__2_;
            this.toolStripButton1Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Cut.Name = "toolStripButton1Cut";
            this.toolStripButton1Cut.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1Cut.Text = "Вырезать";
            this.toolStripButton1Cut.Click += new System.EventHandler(this.toolStripButton1Cut_Click);
            // 
            // toolStripButton1SelectAll
            // 
            this.toolStripButton1SelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1SelectAll.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.SelectAll;
            this.toolStripButton1SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1SelectAll.Name = "toolStripButton1SelectAll";
            this.toolStripButton1SelectAll.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1SelectAll.Text = "Выделить всё";
            this.toolStripButton1SelectAll.Click += new System.EventHandler(this.toolStripButton1SelectAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(15, 25);
            // 
            // toolStripDropDownButton1EditorSettings
            // 
            this.toolStripDropDownButton1EditorSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1EditorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem1,
            this.backgroundColorToolStripMenuItem1,
            this.fontToolStripMenuItem1});
            this.toolStripDropDownButton1EditorSettings.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Design;
            this.toolStripDropDownButton1EditorSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1EditorSettings.Name = "toolStripDropDownButton1EditorSettings";
            this.toolStripDropDownButton1EditorSettings.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1EditorSettings.Text = "Настройки редактора";
            // 
            // fontColorToolStripMenuItem1
            // 
            this.fontColorToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.FontColor;
            this.fontColorToolStripMenuItem1.Name = "fontColorToolStripMenuItem1";
            this.fontColorToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.fontColorToolStripMenuItem1.Text = "Цвет шрифта";
            this.fontColorToolStripMenuItem1.Click += new System.EventHandler(this.fontColorToolStripMenuItem1_Click);
            // 
            // backgroundColorToolStripMenuItem1
            // 
            this.backgroundColorToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.BackColor;
            this.backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            this.backgroundColorToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.backgroundColorToolStripMenuItem1.Text = "Цвет фона";
            this.backgroundColorToolStripMenuItem1.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Font;
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.fontToolStripMenuItem1.Text = "Шрифт";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1Open,
            this.toolStripButton1Create,
            this.toolStripButton1Save,
            this.toolStripButton1SaveAs,
            this.toolStripSeparator1,
            this.toolStripButton1Copy,
            this.toolStripButton1Paste,
            this.toolStripButton1Cut,
            this.toolStripButton1SelectAll,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1EditorSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Open_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Create;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Create_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Save_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1SaveAs_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Paste_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Cut__2_;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1Cut_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.SelectAll;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1SelectAll_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.designToolStripMenuItem.Text = "&Design";
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.FontColor;
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontColorToolStripMenuItem.Text = "Font color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem1_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.BackColor;
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::ДЗ_09._05._2023_Меню.Properties.Resources.Font;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.designToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(720, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1Editor
            // 
            this.textBox1Editor.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1Editor.Location = new System.Drawing.Point(0, 55);
            this.textBox1Editor.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Editor.Multiline = true;
            this.textBox1Editor.Name = "textBox1Editor";
            this.textBox1Editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1Editor.Size = new System.Drawing.Size(720, 478);
            this.textBox1Editor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 533);
            this.Controls.Add(this.textBox1Editor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1Open;
        private System.Windows.Forms.ToolStripButton toolStripButton1Create;
        private System.Windows.Forms.ToolStripButton toolStripButton1Save;
        private System.Windows.Forms.ToolStripButton toolStripButton1SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1Copy;
        private System.Windows.Forms.ToolStripButton toolStripButton1Paste;
        private System.Windows.Forms.ToolStripButton toolStripButton1Cut;
        private System.Windows.Forms.ToolStripButton toolStripButton1SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1EditorSettings;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1Editor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

