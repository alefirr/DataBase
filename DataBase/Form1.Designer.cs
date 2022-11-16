namespace DataBase
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
            this.City = new System.Windows.Forms.CheckBox();
            this.Name_ = new System.Windows.Forms.CheckBox();
            this.Type_ = new System.Windows.Forms.CheckBox();
            this.Height_ = new System.Windows.Forms.CheckBox();
            this.Age = new System.Windows.Forms.CheckBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.HeightBox = new System.Windows.Forms.ComboBox();
            this.AgeBox = new System.Windows.Forms.ComboBox();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearBox = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(87, 196);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(53, 21);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            this.City.UseVisualStyleBackColor = true;
            this.City.CheckedChanged += new System.EventHandler(this.City_CheckedChanged);
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.Location = new System.Drawing.Point(87, 151);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(67, 21);
            this.Name_.TabIndex = 3;
            this.Name_.Text = "Name";
            this.Name_.UseVisualStyleBackColor = true;
            this.Name_.CheckedChanged += new System.EventHandler(this.Name__CheckedChanged);
            // 
            // Type_
            // 
            this.Type_.AutoSize = true;
            this.Type_.Location = new System.Drawing.Point(87, 245);
            this.Type_.Name = "Type_";
            this.Type_.Size = new System.Drawing.Size(62, 21);
            this.Type_.TabIndex = 4;
            this.Type_.Text = "Type";
            this.Type_.UseVisualStyleBackColor = true;
            this.Type_.CheckedChanged += new System.EventHandler(this.Type__CheckedChanged);
            // 
            // Height_
            // 
            this.Height_.AutoSize = true;
            this.Height_.Location = new System.Drawing.Point(87, 294);
            this.Height_.Name = "Height_";
            this.Height_.Size = new System.Drawing.Size(71, 21);
            this.Height_.TabIndex = 5;
            this.Height_.Text = "Height";
            this.Height_.UseVisualStyleBackColor = true;
            this.Height_.CheckedChanged += new System.EventHandler(this.Height__CheckedChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(87, 342);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(55, 21);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age";
            this.Age.UseVisualStyleBackColor = true;
            this.Age.CheckedChanged += new System.EventHandler(this.Age_CheckedChanged);
            // 
            // CityBox
            // 
            this.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(221, 193);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(284, 24);
            this.CityBox.TabIndex = 9;
            this.CityBox.SelectedIndexChanged += new System.EventHandler(this.CityBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(221, 148);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(284, 24);
            this.NameBox.TabIndex = 10;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(221, 243);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(284, 24);
            this.TypeBox.TabIndex = 11;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // HeightBox
            // 
            this.HeightBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeightBox.FormattingEnabled = true;
            this.HeightBox.Location = new System.Drawing.Point(221, 291);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(284, 24);
            this.HeightBox.TabIndex = 12;
            this.HeightBox.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // AgeBox
            // 
            this.AgeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeBox.FormattingEnabled = true;
            this.AgeBox.Location = new System.Drawing.Point(221, 339);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(284, 24);
            this.AgeBox.TabIndex = 13;
            this.AgeBox.SelectedIndexChanged += new System.EventHandler(this.AgeBox_SelectedIndexChanged);
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Checked = true;
            this.LINQ.Location = new System.Drawing.Point(201, 432);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(109, 21);
            this.LINQ.TabIndex = 14;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ to XML";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(201, 511);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(61, 21);
            this.DOM.TabIndex = 15;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            this.DOM.CheckedChanged += new System.EventHandler(this.DOM_CheckedChanged);
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(201, 589);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(56, 21);
            this.SAX.TabIndex = 16;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "Transform to HTML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(282, 797);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearBox
            // 
            this.ClearBox.Location = new System.Drawing.Point(76, 811);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(123, 35);
            this.ClearBox.TabIndex = 19;
            this.ClearBox.Text = "Clear";
            this.ClearBox.UseVisualStyleBackColor = true;
            this.ClearBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 11.8F);
            this.richTextBox1.Location = new System.Drawing.Point(531, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2000, 3, 300, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1507, 924);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 918);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ClearBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Height_);
            this.Controls.Add(this.Type_);
            this.Controls.Add(this.Name_);
            this.Controls.Add(this.City);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1061, 965);
            this.Name = "Form1";
            this.Text = "Olena Sights DataBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox City;
        private System.Windows.Forms.CheckBox Name_;
        private System.Windows.Forms.CheckBox Type_;
        private System.Windows.Forms.CheckBox Height_;
        private System.Windows.Forms.CheckBox Age;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox HeightBox;
        private System.Windows.Forms.ComboBox AgeBox;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ClearBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

