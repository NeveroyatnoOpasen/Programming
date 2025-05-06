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
            this.Classes = new System.Windows.Forms.TabPage();
            this.RectanglesList = new System.Windows.Forms.ListBox();
            this.LenghtBox = new System.Windows.Forms.TextBox();
            this.Widthbox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NumLabel = new System.Windows.Forms.Label();
            this.RectanglesList2 = new System.Windows.Forms.ListBox();
            this.ChangeValues = new System.Windows.Forms.Button();
            this.CountOf = new System.Windows.Forms.TextBox();
            this.FRWMW = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WeekDay.SuspendLayout();
            this.Classes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Controls.Add(this.Classes);
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
            // Classes
            // 
            this.Classes.Controls.Add(this.FRWMW);
            this.Classes.Controls.Add(this.CountOf);
            this.Classes.Controls.Add(this.ChangeValues);
            this.Classes.Controls.Add(this.RectanglesList2);
            this.Classes.Controls.Add(this.NumLabel);
            this.Classes.Controls.Add(this.button1);
            this.Classes.Controls.Add(this.label3);
            this.Classes.Controls.Add(this.label2);
            this.Classes.Controls.Add(this.HeightBox);
            this.Classes.Controls.Add(this.ColorBox);
            this.Classes.Controls.Add(this.Widthbox);
            this.Classes.Controls.Add(this.LenghtBox);
            this.Classes.Controls.Add(this.RectanglesList);
            this.Classes.Location = new System.Drawing.Point(4, 29);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(1200, 669);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // RectanglesList
            // 
            this.RectanglesList.FormattingEnabled = true;
            this.RectanglesList.ItemHeight = 20;
            this.RectanglesList.Location = new System.Drawing.Point(27, 25);
            this.RectanglesList.Name = "RectanglesList";
            this.RectanglesList.Size = new System.Drawing.Size(248, 224);
            this.RectanglesList.TabIndex = 0;
            // 
            // LenghtBox
            // 
            this.LenghtBox.Location = new System.Drawing.Point(354, 57);
            this.LenghtBox.Name = "LenghtBox";
            this.LenghtBox.Size = new System.Drawing.Size(100, 26);
            this.LenghtBox.TabIndex = 1;
            // 
            // Widthbox
            // 
            this.Widthbox.Location = new System.Drawing.Point(354, 131);
            this.Widthbox.Name = "Widthbox";
            this.Widthbox.Size = new System.Drawing.Size(100, 26);
            this.Widthbox.TabIndex = 2;
            this.Widthbox.TextChanged += new System.EventHandler(this.Widthbox_TextChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(354, 206);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(100, 26);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.TextChanged += new System.EventHandler(this.ColorBox_TextChanged);
            // 
            // HeightBox
            // 
            this.HeightBox.AutoSize = true;
            this.HeightBox.Location = new System.Drawing.Point(372, 25);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(56, 20);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.Text = "Height";
            this.HeightBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "RedButton(Generate)";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(375, 276);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(24, 20);
            this.NumLabel.TabIndex = 8;
            this.NumLabel.Text = "№";
            // 
            // RectanglesList2
            // 
            this.RectanglesList2.FormattingEnabled = true;
            this.RectanglesList2.ItemHeight = 20;
            this.RectanglesList2.Location = new System.Drawing.Point(27, 518);
            this.RectanglesList2.Name = "RectanglesList2";
            this.RectanglesList2.Size = new System.Drawing.Size(306, 104);
            this.RectanglesList2.TabIndex = 9;
            // 
            // ChangeValues
            // 
            this.ChangeValues.Location = new System.Drawing.Point(303, 299);
            this.ChangeValues.Name = "ChangeValues";
            this.ChangeValues.Size = new System.Drawing.Size(174, 43);
            this.ChangeValues.TabIndex = 10;
            this.ChangeValues.Text = "ChangeValues";
            this.ChangeValues.UseVisualStyleBackColor = true;
            this.ChangeValues.Click += new System.EventHandler(this.ChangeValues_Click);
            // 
            // CountOf
            // 
            this.CountOf.Location = new System.Drawing.Point(532, 131);
            this.CountOf.Name = "CountOf";
            this.CountOf.Size = new System.Drawing.Size(180, 26);
            this.CountOf.TabIndex = 11;
            // 
            // FRWMW
            // 
            this.FRWMW.Location = new System.Drawing.Point(54, 322);
            this.FRWMW.Name = "FRWMW";
            this.FRWMW.Size = new System.Drawing.Size(193, 36);
            this.FRWMW.TabIndex = 12;
            this.FRWMW.Text = "FRWMW";
            this.FRWMW.UseVisualStyleBackColor = true;
            this.FRWMW.Click += new System.EventHandler(this.FRWMW_Click);
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
            this.Classes.ResumeLayout(false);
            this.Classes.PerformLayout();
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
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.TextBox Widthbox;
        private System.Windows.Forms.TextBox LenghtBox;
        private System.Windows.Forms.ListBox RectanglesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HeightBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.ListBox RectanglesList2;
        private System.Windows.Forms.Button ChangeValues;
        private System.Windows.Forms.TextBox CountOf;
        private System.Windows.Forms.Button FRWMW;
    }
}

