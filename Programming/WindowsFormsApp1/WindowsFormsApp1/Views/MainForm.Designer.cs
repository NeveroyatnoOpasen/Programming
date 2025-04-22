namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonYear = new System.Windows.Forms.Button();
            this.YearSelector = new System.Windows.Forms.ComboBox();
            this.WeekDay = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.TextOfTheDay = new System.Windows.Forms.Label();
            this.ParseBox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ValuelistBox = new System.Windows.Forms.ListBox();
            this.EnumlistBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WeekDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Location = new System.Drawing.Point(-3, -2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1208, 702);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.groupBox1);
            this.tabPage.Controls.Add(this.WeekDay);
            this.tabPage.Controls.Add(this.ValueBox);
            this.tabPage.Controls.Add(this.ValuelistBox);
            this.tabPage.Controls.Add(this.EnumlistBox);
            this.tabPage.Location = new System.Drawing.Point(4, 29);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage.Size = new System.Drawing.Size(1200, 669);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Enums";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonYear);
            this.groupBox1.Controls.Add(this.YearSelector);
            this.groupBox1.Location = new System.Drawing.Point(622, 346);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(495, 268);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "timeOfTheYear";
            // 
            // ButtonYear
            // 
            this.ButtonYear.Location = new System.Drawing.Point(260, 74);
            this.ButtonYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonYear.Name = "ButtonYear";
            this.ButtonYear.Size = new System.Drawing.Size(112, 35);
            this.ButtonYear.TabIndex = 1;
            this.ButtonYear.Text = "Davai";
            this.ButtonYear.UseVisualStyleBackColor = true;
            this.ButtonYear.Click += new System.EventHandler(this.ButtonYear_Click);
            // 
            // YearSelector
            // 
            this.YearSelector.FormattingEnabled = true;
            this.YearSelector.Items.AddRange(new object[] {
            "Spring",
            "Autumm",
            "Winter",
            "Summer"});
            this.YearSelector.Location = new System.Drawing.Point(48, 74);
            this.YearSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearSelector.Name = "YearSelector";
            this.YearSelector.Size = new System.Drawing.Size(180, 28);
            this.YearSelector.TabIndex = 0;
            // 
            // WeekDay
            // 
            this.WeekDay.Controls.Add(this.ParseButton);
            this.WeekDay.Controls.Add(this.TextOfTheDay);
            this.WeekDay.Controls.Add(this.ParseBox);
            this.WeekDay.Location = new System.Drawing.Point(32, 346);
            this.WeekDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekDay.Name = "WeekDay";
            this.WeekDay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekDay.Size = new System.Drawing.Size(434, 268);
            this.WeekDay.TabIndex = 6;
            this.WeekDay.TabStop = false;
            this.WeekDay.Text = "WeekDay";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(256, 54);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(112, 35);
            this.ParseButton.TabIndex = 4;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextOfTheDay
            // 
            this.TextOfTheDay.AutoSize = true;
            this.TextOfTheDay.Location = new System.Drawing.Point(72, 112);
            this.TextOfTheDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextOfTheDay.Name = "TextOfTheDay";
            this.TextOfTheDay.Size = new System.Drawing.Size(119, 20);
            this.TextOfTheDay.TabIndex = 5;
            this.TextOfTheDay.Text = "DayofTheWeek";
            // 
            // ParseBox
            // 
            this.ParseBox.Location = new System.Drawing.Point(76, 54);
            this.ParseBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParseBox.Name = "ParseBox";
            this.ParseBox.Size = new System.Drawing.Size(148, 26);
            this.ParseBox.TabIndex = 3;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(459, 25);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(148, 26);
            this.ValueBox.TabIndex = 2;
            // 
            // ValuelistBox
            // 
            this.ValuelistBox.FormattingEnabled = true;
            this.ValuelistBox.ItemHeight = 20;
            this.ValuelistBox.Location = new System.Drawing.Point(244, 25);
            this.ValuelistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValuelistBox.Name = "ValuelistBox";
            this.ValuelistBox.Size = new System.Drawing.Size(178, 144);
            this.ValuelistBox.TabIndex = 1;
            this.ValuelistBox.SelectedIndexChanged += new System.EventHandler(this.ValuelistBox_SelectedIndexChanged);
            // 
            // EnumlistBox
            // 
            this.EnumlistBox.FormattingEnabled = true;
            this.EnumlistBox.ItemHeight = 20;
            this.EnumlistBox.Items.AddRange(new object[] {
            "Colors",
            "Genre",
            "Eduaction",
            "TimeOfYear",
            "WeekDay",
            "Manufactures"});
            this.EnumlistBox.Location = new System.Drawing.Point(32, 25);
            this.EnumlistBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumlistBox.Name = "EnumlistBox";
            this.EnumlistBox.Size = new System.Drawing.Size(178, 144);
            this.EnumlistBox.TabIndex = 0;
            this.EnumlistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.WeekDay.ResumeLayout(false);
            this.WeekDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.ListBox EnumlistBox;
        private System.Windows.Forms.ListBox ValuelistBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.TextBox ParseBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label TextOfTheDay;
        private System.Windows.Forms.GroupBox WeekDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonYear;
        private System.Windows.Forms.ComboBox YearSelector;
    }
}

