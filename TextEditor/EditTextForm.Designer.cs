namespace TextEditor
{
    partial class EditTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTextForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.openStripBtn = new System.Windows.Forms.ToolStripButton();
            this.saveStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyStripBtn = new System.Windows.Forms.ToolStripButton();
            this.insertStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.searchTxt = new System.Windows.Forms.ToolStripTextBox();
            this.searchStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.replaceTxt1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.replaceTxt2 = new System.Windows.Forms.ToolStripTextBox();
            this.replaceBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.formatStripBtn = new System.Windows.Forms.ToolStripButton();
            this.boldStripBtn = new System.Windows.Forms.ToolStripButton();
            this.italicStripBtn = new System.Windows.Forms.ToolStripButton();
            this.crossStripBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.langComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.openStripBtn,
            this.saveStripBtn,
            this.toolStripSeparator1,
            this.copyStripBtn,
            this.insertStripBtn,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.searchTxt,
            this.searchStripBtn,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.replaceTxt1,
            this.toolStripLabel5,
            this.replaceTxt2,
            this.replaceBtn,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.formatStripBtn,
            this.boldStripBtn,
            this.italicStripBtn,
            this.crossStripBtn,
            this.underlineStripBtn,
            this.toolStripSeparator5,
            this.toolStripLabel6,
            this.langComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1785, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(135, 52);
            this.toolStripLabel1.Text = "Работа с файлами";
            // 
            // openStripBtn
            // 
            this.openStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openStripBtn.Image = global::TextEditor.Properties.Resources.open;
            this.openStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openStripBtn.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.openStripBtn.Name = "openStripBtn";
            this.openStripBtn.Size = new System.Drawing.Size(29, 35);
            this.openStripBtn.Text = "Открыть файл...";
            this.openStripBtn.Click += new System.EventHandler(this.openStripBtn_Click);
            // 
            // saveStripBtn
            // 
            this.saveStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripBtn.Image = global::TextEditor.Properties.Resources.save;
            this.saveStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripBtn.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.saveStripBtn.Name = "saveStripBtn";
            this.saveStripBtn.Size = new System.Drawing.Size(29, 52);
            this.saveStripBtn.Text = "Сохранить файл";
            this.saveStripBtn.Click += new System.EventHandler(this.saveStripBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // copyStripBtn
            // 
            this.copyStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyStripBtn.Image = global::TextEditor.Properties.Resources.copy;
            this.copyStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyStripBtn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.copyStripBtn.Name = "copyStripBtn";
            this.copyStripBtn.Size = new System.Drawing.Size(29, 52);
            this.copyStripBtn.Text = "Копировать текст";
            this.copyStripBtn.Click += new System.EventHandler(this.copyStripBtn_Click);
            // 
            // insertStripBtn
            // 
            this.insertStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertStripBtn.Image = global::TextEditor.Properties.Resources.insert;
            this.insertStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertStripBtn.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.insertStripBtn.Name = "insertStripBtn";
            this.insertStripBtn.Size = new System.Drawing.Size(29, 52);
            this.insertStripBtn.Text = "Вставить текст";
            this.insertStripBtn.Click += new System.EventHandler(this.insertStripBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 52);
            this.toolStripLabel3.Text = "Поиск";
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(170, 55);
            // 
            // searchStripBtn
            // 
            this.searchStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchStripBtn.Image = global::TextEditor.Properties.Resources.loop;
            this.searchStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchStripBtn.Name = "searchStripBtn";
            this.searchStripBtn.Size = new System.Drawing.Size(29, 52);
            this.searchStripBtn.Text = "Найти в тексте";
            this.searchStripBtn.Click += new System.EventHandler(this.searchStripBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(61, 52);
            this.toolStripLabel4.Text = "Замена";
            // 
            // replaceTxt1
            // 
            this.replaceTxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceTxt1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceTxt1.Name = "replaceTxt1";
            this.replaceTxt1.Size = new System.Drawing.Size(170, 55);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(26, 52);
            this.toolStripLabel5.Text = "на";
            // 
            // replaceTxt2
            // 
            this.replaceTxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceTxt2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceTxt2.Name = "replaceTxt2";
            this.replaceTxt2.Size = new System.Drawing.Size(175, 55);
            // 
            // replaceBtn
            // 
            this.replaceBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.replaceBtn.Image = global::TextEditor.Properties.Resources.replace;
            this.replaceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(29, 52);
            this.replaceBtn.Text = "Заменить текст";
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 52);
            this.toolStripLabel2.Text = "Текст";
            // 
            // formatStripBtn
            // 
            this.formatStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.formatStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("formatStripBtn.Image")));
            this.formatStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.formatStripBtn.Name = "formatStripBtn";
            this.formatStripBtn.Size = new System.Drawing.Size(29, 41);
            this.formatStripBtn.Text = "Форматирование";
            this.formatStripBtn.Click += new System.EventHandler(this.formatStripBtn_Click);
            // 
            // boldStripBtn
            // 
            this.boldStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldStripBtn.Image = global::TextEditor.Properties.Resources.bold;
            this.boldStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldStripBtn.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.boldStripBtn.Name = "boldStripBtn";
            this.boldStripBtn.Size = new System.Drawing.Size(29, 55);
            this.boldStripBtn.Text = "Жирный";
            this.boldStripBtn.Click += new System.EventHandler(this.boldStripBtn_Click);
            // 
            // italicStripBtn
            // 
            this.italicStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicStripBtn.Image = global::TextEditor.Properties.Resources.italic;
            this.italicStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.italicStripBtn.Name = "italicStripBtn";
            this.italicStripBtn.Size = new System.Drawing.Size(29, 52);
            this.italicStripBtn.Text = "Курсив";
            this.italicStripBtn.Click += new System.EventHandler(this.italicStripBtn_Click);
            // 
            // crossStripBtn
            // 
            this.crossStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crossStripBtn.Image = global::TextEditor.Properties.Resources.crossedOut;
            this.crossStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.crossStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.crossStripBtn.Name = "crossStripBtn";
            this.crossStripBtn.Size = new System.Drawing.Size(29, 52);
            this.crossStripBtn.Text = "Перечеркнутый";
            this.crossStripBtn.Click += new System.EventHandler(this.crossStripBtn_Click);
            // 
            // underlineStripBtn
            // 
            this.underlineStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineStripBtn.Image = global::TextEditor.Properties.Resources.underline;
            this.underlineStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineStripBtn.Name = "underlineStripBtn";
            this.underlineStripBtn.Size = new System.Drawing.Size(29, 52);
            this.underlineStripBtn.Text = "Подчеркнутый";
            this.underlineStripBtn.Click += new System.EventHandler(this.underlineStripBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(192, 52);
            this.toolStripLabel6.Text = " Язык программирования";
            // 
            // langComboBox
            // 
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(175, 55);
            this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
            // 
            // textArea
            // 
            this.textArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textArea.Location = new System.Drawing.Point(0, 47);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(1785, 1394);
            this.textArea.TabIndex = 1;
            this.textArea.Text = "";
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // EditTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1785, 1104);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditTextForm";
            this.Text = "Редактирование текста";
            this.Load += new System.EventHandler(this.EditTextForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton openStripBtn;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.ToolStripButton saveStripBtn;
        private System.Windows.Forms.ToolStripButton copyStripBtn;
        private System.Windows.Forms.ToolStripButton insertStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox searchTxt;
        private System.Windows.Forms.ToolStripButton searchStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox replaceTxt1;
        private System.Windows.Forms.ToolStripButton replaceBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox replaceTxt2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton boldStripBtn;
        private System.Windows.Forms.ToolStripButton italicStripBtn;
        private System.Windows.Forms.ToolStripButton crossStripBtn;
        private System.Windows.Forms.ToolStripButton underlineStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox langComboBox;
        private System.Windows.Forms.ToolStripButton formatStripBtn;
    }
}

