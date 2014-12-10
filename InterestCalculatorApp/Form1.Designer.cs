namespace InterestCalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.ComboBox();
            this.timeInYear = new System.Windows.Forms.TextBox();
            this.principleAmount = new System.Windows.Forms.TextBox();
            this.interestResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (in year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Principle Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest=";
            // 
            // bankName
            // 
            this.bankName.FormattingEnabled = true;
            this.bankName.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC",
            "UCB"});
            this.bankName.Location = new System.Drawing.Point(109, 50);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(158, 21);
            this.bankName.TabIndex = 4;
            // 
            // timeInYear
            // 
            this.timeInYear.Location = new System.Drawing.Point(109, 96);
            this.timeInYear.Name = "timeInYear";
            this.timeInYear.Size = new System.Drawing.Size(158, 20);
            this.timeInYear.TabIndex = 5;
            // 
            // principleAmount
            // 
            this.principleAmount.Location = new System.Drawing.Point(109, 145);
            this.principleAmount.Name = "principleAmount";
            this.principleAmount.Size = new System.Drawing.Size(158, 20);
            this.principleAmount.TabIndex = 6;
            // 
            // interestResult
            // 
            this.interestResult.Location = new System.Drawing.Point(398, 96);
            this.interestResult.Name = "interestResult";
            this.interestResult.Size = new System.Drawing.Size(158, 20);
            this.interestResult.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interest Rate (%)";
            // 
            // interestRate
            // 
            this.interestRate.Location = new System.Drawing.Point(109, 188);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(158, 20);
            this.interestRate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 275);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.interestResult);
            this.Controls.Add(this.principleAmount);
            this.Controls.Add(this.timeInYear);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bankName;
        private System.Windows.Forms.TextBox timeInYear;
        private System.Windows.Forms.TextBox principleAmount;
        private System.Windows.Forms.TextBox interestResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox interestRate;
    }
}

