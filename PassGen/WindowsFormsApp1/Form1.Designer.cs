namespace WindowsFormsApp1
{
    partial class PassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen));
            this.Title = new System.Windows.Forms.Label();
            this.VersionTitle = new System.Windows.Forms.Label();
            this.PasswordSymbols = new System.Windows.Forms.CheckedListBox();
            this.PasswordOutput = new System.Windows.Forms.TextBox();
            this.PasswordLength = new System.Windows.Forms.ComboBox();
            this.PasswordStrength = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(297, 73);
            this.Title.TabIndex = 0;
            this.Title.Text = "PassGen";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // VersionTitle
            // 
            this.VersionTitle.AutoSize = true;
            this.VersionTitle.BackColor = System.Drawing.Color.Transparent;
            this.VersionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionTitle.Location = new System.Drawing.Point(287, 52);
            this.VersionTitle.Name = "VersionTitle";
            this.VersionTitle.Size = new System.Drawing.Size(123, 20);
            this.VersionTitle.TabIndex = 0;
            this.VersionTitle.Text = "_v 0.123456789";
            this.VersionTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PasswordSymbols
            // 
            this.PasswordSymbols.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordSymbols.FormattingEnabled = true;
            this.PasswordSymbols.Items.AddRange(new object[] {
            "A-Z",
            "a-z",
            "0-9",
            "Symbols"});
            this.PasswordSymbols.Location = new System.Drawing.Point(12, 85);
            this.PasswordSymbols.Name = "PasswordSymbols";
            this.PasswordSymbols.Size = new System.Drawing.Size(74, 64);
            this.PasswordSymbols.TabIndex = 1;
            // 
            // PasswordOutput
            // 
            this.PasswordOutput.Location = new System.Drawing.Point(12, 233);
            this.PasswordOutput.MaxLength = 0;
            this.PasswordOutput.Multiline = true;
            this.PasswordOutput.Name = "PasswordOutput";
            this.PasswordOutput.Size = new System.Drawing.Size(776, 205);
            this.PasswordOutput.TabIndex = 4;
            // 
            // PasswordLength
            // 
            this.PasswordLength.FormattingEnabled = true;
            this.PasswordLength.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.PasswordLength.Location = new System.Drawing.Point(12, 155);
            this.PasswordLength.MaxLength = 4;
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(74, 21);
            this.PasswordLength.TabIndex = 2;
            this.PasswordLength.TextUpdate += new System.EventHandler(this.PasswordLength_TextUpdate);
            this.PasswordLength.DropDownClosed += new System.EventHandler(this.PasswordLength_DropDownClosed);
            // 
            // PasswordStrength
            // 
            this.PasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordStrength.Location = new System.Drawing.Point(12, 179);
            this.PasswordStrength.Name = "PasswordStrength";
            this.PasswordStrength.Size = new System.Drawing.Size(74, 24);
            this.PasswordStrength.TabIndex = 0;
            this.PasswordStrength.Text = "Strength";
            this.PasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Transparent;
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(93, 85);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(317, 91);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generate";
            this.Generate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.PasswordStrength);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.PasswordOutput);
            this.Controls.Add(this.PasswordSymbols);
            this.Controls.Add(this.VersionTitle);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PassGen";
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.PassGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label VersionTitle;
        private System.Windows.Forms.CheckedListBox PasswordSymbols;
        private System.Windows.Forms.TextBox PasswordOutput;
        private System.Windows.Forms.ComboBox PasswordLength;
        private System.Windows.Forms.Label PasswordStrength;
        private System.Windows.Forms.Button Generate;
    }
}

