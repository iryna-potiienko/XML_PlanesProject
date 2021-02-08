namespace XML_Laba3
{
    partial class Form1
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.transformButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.domRadioButton = new System.Windows.Forms.RadioButton();
            this.saxRadioButton = new System.Windows.Forms.RadioButton();
            this.linqRadioButton = new System.Windows.Forms.RadioButton();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxTourOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxLunch = new System.Windows.Forms.ComboBox();
            this.comboBoxAirline = new System.Windows.Forms.ComboBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxArrival = new System.Windows.Forms.ComboBox();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.tourOperCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.departureCheckBox = new System.Windows.Forms.CheckBox();
            this.arrivalCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.durationCheckBox = new System.Windows.Forms.CheckBox();
            this.airlineCheckBox = new System.Windows.Forms.CheckBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(650, 36);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(400, 359);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(454, 208);
            this.transformButton.Margin = new System.Windows.Forms.Padding(4);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(109, 34);
            this.transformButton.TabIndex = 1;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(454, 266);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 32);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // domRadioButton
            // 
            this.domRadioButton.AutoSize = true;
            this.domRadioButton.Location = new System.Drawing.Point(70, 411);
            this.domRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.domRadioButton.Name = "domRadioButton";
            this.domRadioButton.Size = new System.Drawing.Size(57, 19);
            this.domRadioButton.TabIndex = 3;
            this.domRadioButton.TabStop = true;
            this.domRadioButton.Text = "DOM";
            this.domRadioButton.UseVisualStyleBackColor = true;
            // 
            // saxRadioButton
            // 
            this.saxRadioButton.AutoSize = true;
            this.saxRadioButton.Location = new System.Drawing.Point(214, 411);
            this.saxRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.saxRadioButton.Name = "saxRadioButton";
            this.saxRadioButton.Size = new System.Drawing.Size(53, 19);
            this.saxRadioButton.TabIndex = 4;
            this.saxRadioButton.TabStop = true;
            this.saxRadioButton.Text = "SAX";
            this.saxRadioButton.UseVisualStyleBackColor = true;
            // 
            // linqRadioButton
            // 
            this.linqRadioButton.AutoSize = true;
            this.linqRadioButton.Location = new System.Drawing.Point(353, 411);
            this.linqRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.linqRadioButton.Name = "linqRadioButton";
            this.linqRadioButton.Size = new System.Drawing.Size(107, 19);
            this.linqRadioButton.TabIndex = 5;
            this.linqRadioButton.TabStop = true;
            this.linqRadioButton.Text = "LINQ to XML";
            this.linqRadioButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Location = new System.Drawing.Point(179, 167);
            this.comboBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(160, 23);
            this.comboBoxPrice.TabIndex = 6;
            // 
            // comboBoxTourOperator
            // 
            this.comboBoxTourOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTourOperator.FormattingEnabled = true;
            this.comboBoxTourOperator.Location = new System.Drawing.Point(179, 357);
            this.comboBoxTourOperator.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTourOperator.Name = "comboBoxTourOperator";
            this.comboBoxTourOperator.Size = new System.Drawing.Size(160, 23);
            this.comboBoxTourOperator.TabIndex = 7;
            // 
            // comboBoxLunch
            // 
            this.comboBoxLunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLunch.FormattingEnabled = true;
            this.comboBoxLunch.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBoxLunch.Location = new System.Drawing.Point(179, 249);
            this.comboBoxLunch.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLunch.Name = "comboBoxLunch";
            this.comboBoxLunch.Size = new System.Drawing.Size(160, 23);
            this.comboBoxLunch.TabIndex = 8;
            // 
            // comboBoxAirline
            // 
            this.comboBoxAirline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAirline.FormattingEnabled = true;
            this.comboBoxAirline.Location = new System.Drawing.Point(179, 332);
            this.comboBoxAirline.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAirline.Name = "comboBoxAirline";
            this.comboBoxAirline.Size = new System.Drawing.Size(160, 23);
            this.comboBoxAirline.TabIndex = 9;
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(179, 208);
            this.comboBoxDuration.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDuration.TabIndex = 10;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(179, 127);
            this.comboBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDate.TabIndex = 11;
            // 
            // comboBoxArrival
            // 
            this.comboBoxArrival.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArrival.FormattingEnabled = true;
            this.comboBoxArrival.Location = new System.Drawing.Point(432, 55);
            this.comboBoxArrival.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxArrival.Name = "comboBoxArrival";
            this.comboBoxArrival.Size = new System.Drawing.Size(160, 23);
            this.comboBoxArrival.TabIndex = 12;
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(133, 55);
            this.comboBoxDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDeparture.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(422, 329);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(170, 51);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // tourOperCheckBox
            // 
            this.tourOperCheckBox.AutoSize = true;
            this.tourOperCheckBox.Location = new System.Drawing.Point(23, 361);
            this.tourOperCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.tourOperCheckBox.Name = "tourOperCheckBox";
            this.tourOperCheckBox.Size = new System.Drawing.Size(125, 19);
            this.tourOperCheckBox.TabIndex = 15;
            this.tourOperCheckBox.Text = "Tour operator: ";
            this.tourOperCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Location = new System.Drawing.Point(23, 167);
            this.priceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(110, 19);
            this.priceCheckBox.TabIndex = 16;
            this.priceCheckBox.Text = "Price (UAH): ";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            // 
            // departureCheckBox
            // 
            this.departureCheckBox.AutoSize = true;
            this.departureCheckBox.Location = new System.Drawing.Point(23, 59);
            this.departureCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.departureCheckBox.Name = "departureCheckBox";
            this.departureCheckBox.Size = new System.Drawing.Size(102, 19);
            this.departureCheckBox.TabIndex = 17;
            this.departureCheckBox.Text = "Departure: ";
            this.departureCheckBox.UseVisualStyleBackColor = true;
            // 
            // arrivalCheckBox
            // 
            this.arrivalCheckBox.AutoSize = true;
            this.arrivalCheckBox.Location = new System.Drawing.Point(344, 59);
            this.arrivalCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalCheckBox.Name = "arrivalCheckBox";
            this.arrivalCheckBox.Size = new System.Drawing.Size(80, 19);
            this.arrivalCheckBox.TabIndex = 18;
            this.arrivalCheckBox.Text = "Arrival:";
            this.arrivalCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(23, 127);
            this.dateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(64, 19);
            this.dateCheckBox.TabIndex = 19;
            this.dateCheckBox.Text = "Date: ";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // durationCheckBox
            // 
            this.durationCheckBox.AutoSize = true;
            this.durationCheckBox.Location = new System.Drawing.Point(23, 208);
            this.durationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.durationCheckBox.Name = "durationCheckBox";
            this.durationCheckBox.Size = new System.Drawing.Size(148, 19);
            this.durationCheckBox.TabIndex = 20;
            this.durationCheckBox.Text = "Duration (hours) : ";
            this.durationCheckBox.UseVisualStyleBackColor = true;
            // 
            // airlineCheckBox
            // 
            this.airlineCheckBox.AutoSize = true;
            this.airlineCheckBox.Location = new System.Drawing.Point(23, 334);
            this.airlineCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.airlineCheckBox.Name = "airlineCheckBox";
            this.airlineCheckBox.Size = new System.Drawing.Size(81, 19);
            this.airlineCheckBox.TabIndex = 21;
            this.airlineCheckBox.Text = "Airline: ";
            this.airlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Location = new System.Drawing.Point(23, 249);
            this.lunchCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(126, 19);
            this.lunchCheckBox.TabIndex = 22;
            this.lunchCheckBox.Text = "Lunch include: ";
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 19);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "search+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lunchCheckBox);
            this.Controls.Add(this.airlineCheckBox);
            this.Controls.Add(this.durationCheckBox);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.arrivalCheckBox);
            this.Controls.Add(this.departureCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.tourOperCheckBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.comboBoxDeparture);
            this.Controls.Add(this.comboBoxArrival);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.comboBoxAirline);
            this.Controls.Add(this.comboBoxLunch);
            this.Controls.Add(this.comboBoxTourOperator);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.linqRadioButton);
            this.Controls.Add(this.saxRadioButton);
            this.Controls.Add(this.domRadioButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.transformButton);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Search with XML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton domRadioButton;
        private System.Windows.Forms.RadioButton saxRadioButton;
        private System.Windows.Forms.RadioButton linqRadioButton;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxTourOperator;
        private System.Windows.Forms.ComboBox comboBoxLunch;
        private System.Windows.Forms.ComboBox comboBoxAirline;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxArrival;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox tourOperCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox departureCheckBox;
        private System.Windows.Forms.CheckBox arrivalCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox durationCheckBox;
        private System.Windows.Forms.CheckBox airlineCheckBox;
        private System.Windows.Forms.CheckBox lunchCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

