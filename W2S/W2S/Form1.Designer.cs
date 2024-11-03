namespace W2S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Keyword = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Keyword
            // 
            this.Keyword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyword.FormattingEnabled = true;
            this.Keyword.Items.AddRange(new object[] {
            "At (@)",
            "a (á)",
            "a (â)",
            "a (à)",
            "a (ā)",
            "a (ä)",
            "a (ã)",
            "a (ǎ)",
            "a (ȧ)",
            "a (ẚ)",
            "a (ạ)",
            "a (ą)",
            "And",
            "Add",
            "Alpha",
            "Angle (θ)",
            "Angle (ϕ)",
            "Angle (∠)",
            "Angle (∡)",
            "Angle (∟)",
            "Angle (⦜)",
            "Angstrom",
            "Approximately Equal To",
            "Anticlockwise Rotation (↺)",
            "Anticlockwise Rotation (↶)",
            "",
            "Beta",
            "Because",
            "Belongs To",
            "",
            "Chi",
            "Cube",
            "Caret",
            "Check",
            "Correct",
            "Celsius",
            "Club (♣)",
            "Cube Root",
            "Clockwise Rotation (↻)",
            "Clockwise Rotation (↷)",
            "Counterclockwise Rotation (↺)",
            "Counterclockwise Rotation (↶)",
            "",
            "Dot (●)",
            "Delta (∆)",
            "Delta (δ)",
            "Divide",
            "Degree",
            "Down Arrow",
            "Diamond (♦)",
            "Down Arrow (⇓)",
            "Down Arrow (⬇)",
            "Down Up Arrow (↕)",
            "Down Up Arrow (⇕)",
            "Does Not Belong To",
            "Down Left Arrow (↙)",
            "Down Left Arrow (⇙)",
            "Down Right Arrow (↘)",
            "Down Right Arrow (⇘)",
            "Dislike",
            "",
            "e (é)",
            "e (ê)",
            "e (è)",
            "e (ē)",
            "e (ë)",
            "e (ẽ)",
            "e (ě)",
            "e (ė)",
            "e (ẻ)",
            "e (ẹ)",
            "e (ę)",
            "Eta",
            "Epsilon",
            "Erosion",
            "Efficiency",
            "Empty Set",
            "Element Of",
            "Exclusive Or",
            "Equivalent To",
            "",
            "For All",
            "Fahrenheit",
            "Full Stop (●)",
            "Fuck You!",
            "",
            "Gamma",
            "Greater Than",
            "Greater Than or Equal To",
            "Greater Than Greater Than",
            "",
            "Half",
            "Heart (♥)",
            "",
            "i (í)",
            "i (î)",
            "i (ì)",
            "i (ī)",
            "i (ï)",
            "Iota",
            "Infinity",
            "Implies",
            "Integral",
            "Intersection",
            "",
            "Kappa",
            "",
            "Loop",
            "Lambda",
            "Less Than",
            "Left Arrow",
            "Left Arrow (⇐)",
            "Left Up Arrow (↖)",
            "Left Up Arrow (⇖)",
            "Left Right Arrow (↔)",
            "Left Right Arrow (⇔)",
            "Left Right Arrow (⬌)",
            "Less Than Less Than",
            "Left Down Arrow (↙)",
            "Left Down Arrow (⇙)",
            "Less Than or Equal To",
            "Like",
            "LOL",
            "LMFAO",
            "",
            "Mu",
            "More Than",
            "Multiply (•)",
            "Multiply (×)",
            "More Than More Than",
            "More Than or Equal To",
            "",
            "Nu",
            "Not",
            "Not Subset",
            "Not Equal To",
            "Not Superset",
            "Not Element Of",
            "Not OK",
            "",
            "o (ó)",
            "o (ô)",
            "o (ò)",
            "o (ō)",
            "o (ö)",
            "o (õ)",
            "Or",
            "Omega i",
            "Omega ii",
            "Omicron",
            "One Third",
            "OK",
            "",
            "Pi",
            "Psi",
            "Phi",
            "Percent",
            "Point (●)",
            "Power (^)",
            "Proportion",
            "Product (•)",
            "Product (×)",
            "Plus or Minus",
            "Perpendicular",
            "Pointing Finger",
            "Peace",
            "",
            "Quarter",
            "Quad Root",
            "",
            "Rho",
            "Root (√)",
            "Root (∛)",
            "Root (∜)",
            "Result (⇛)",
            "Result (⇶)",
            "Right Angle",
            "Rotation (↻)",
            "Rotation (↺)",
            "Reversed Caret",
            "Right Arrow",
            "Right Arrow (⇒)",
            "Right Arrow (⇛)",
            "Right Arrow (⇶)",
            "Right Arrow (➔)",
            "Right Arrow (►)",
            "Right Up Arrow (↗)",
            "Right Up Arrow (⇗)",
            "Right Left Arrow (↔)",
            "Right Left Arrow (⇔)",
            "Right Left Arrow (⬌)",
            "Right Down Arrow (↘)",
            "Right Down Arrow (⇘)",
            "",
            "So",
            "Since",
            "Subset",
            "Square",
            "Sigma i",
            "Sigma ii",
            "Subtract",
            "Superset",
            "Spade (♠)",
            "Such That (|)",
            "Such That (⇛)",
            "Such That (⇶)",
            "Square Root",
            "Strict Subset",
            "Strict Superset",
            "Summation of",
            "Symmetric Difference",
            "Smile i",
            "Smile ii",
            "",
            "Tau",
            "Tick",
            "Tilde",
            "Theta",
            "Therefore",
            "Two Third",
            "There Exists",
            "Tone (Single)",
            "Tone (Double)",
            "Three Quarters",
            "There Does Not Exists",
            "",
            "u (ú)",
            "u (û)",
            "u (ù)",
            "u (ū)",
            "u (ü)",
            "Union",
            "Upsilon",
            "Up Arrow",
            "Up Arrow (⇑)",
            "Up Arrow (⬆)",
            "Up Left Arrow (↖)",
            "Up Left Arrow (⇖)",
            "Up Down Arrow (↕)",
            "Up Down Arrow (⇕)",
            "Up Right Arrow (↗)",
            "Up Right Arrow (⇗)",
            "",
            "Which Gives (⇛)",
            "Which Gives (⇶)",
            "Wink",
            "",
            "Xi",
            "XOR",
            "XD",
            "",
            "Zeta",
            "",
            "0↑",
            "1↑",
            "2↑",
            "3↑",
            "4↑",
            "5↑",
            "6↑",
            "7↑",
            "8↑",
            "9↑",
            "n↑",
            "e↑",
            "i↑",
            "x↑",
            "t↑",
            "",
            "0↓",
            "1↓",
            "2↓",
            "3↓",
            "4↓",
            "5↓",
            "6↓",
            "7↓",
            "8↓",
            "9↓",
            "n↓",
            "e↓",
            "i↓",
            "x↓",
            "t↓",
            "",
            ":)",
            ";)",
            ":D"});
            this.Keyword.Location = new System.Drawing.Point(195, 101);
            this.Keyword.Margin = new System.Windows.Forms.Padding(4);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(261, 37);
            this.Keyword.TabIndex = 0;
            this.Keyword.SelectedIndexChanged += new System.EventHandler(this.Keyword_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Keyword:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(195, 172);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(261, 46);
            this.Result.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(488, 183);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 28);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear All";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Get
            // 
            this.Get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Get.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get.Location = new System.Drawing.Point(500, 101);
            this.Get.Margin = new System.Windows.Forms.Padding(4);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(72, 38);
            this.Get.TabIndex = 6;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 52);
            this.label4.TabIndex = 12;
            this.label4.Text = "Word2Symbol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(604, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "W2S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

