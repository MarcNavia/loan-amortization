namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.annualAprTextBox = new System.Windows.Forms.TextBox();
            this.sixRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveRadioButton = new System.Windows.Forms.RadioButton();
            this.eightTeenRadiobutton = new System.Windows.Forms.RadioButton();
            this.twentyFourRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annual APR(%):";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(264, 62);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(236, 39);
            this.loanAmountTextBox.TabIndex = 1;
            this.loanAmountTextBox.Click += new System.EventHandler(this.loanAmountTextBox_Click);
            this.loanAmountTextBox.TextChanged += new System.EventHandler(this.loanAmountTextBox_TextChanged);
            this.loanAmountTextBox.Enter += new System.EventHandler(this.loanAmountTextBox_Enter);
            this.loanAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanAmountTextBox_KeyPress);
            // 
            // annualAprTextBox
            // 
            this.annualAprTextBox.Location = new System.Drawing.Point(264, 125);
            this.annualAprTextBox.Name = "annualAprTextBox";
            this.annualAprTextBox.Size = new System.Drawing.Size(236, 39);
            this.annualAprTextBox.TabIndex = 3;
            this.annualAprTextBox.Click += new System.EventHandler(this.annualAprTextBox_Click);
            this.annualAprTextBox.TextChanged += new System.EventHandler(this.annualAprTextBox_TextChanged);
            this.annualAprTextBox.Enter += new System.EventHandler(this.annualAprTextBox_Enter);
            this.annualAprTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.annualAprTextBox_KeyPress);
            // 
            // sixRadioButton
            // 
            this.sixRadioButton.AutoSize = true;
            this.sixRadioButton.Checked = true;
            this.sixRadioButton.Location = new System.Drawing.Point(36, 45);
            this.sixRadioButton.Name = "sixRadioButton";
            this.sixRadioButton.Size = new System.Drawing.Size(59, 36);
            this.sixRadioButton.TabIndex = 0;
            this.sixRadioButton.TabStop = true;
            this.sixRadioButton.Text = "6";
            this.sixRadioButton.UseVisualStyleBackColor = true;
            this.sixRadioButton.CheckedChanged += new System.EventHandler(this.sixRadioButton_CheckedChanged);
            // 
            // twelveRadioButton
            // 
            this.twelveRadioButton.AutoSize = true;
            this.twelveRadioButton.Location = new System.Drawing.Point(36, 118);
            this.twelveRadioButton.Name = "twelveRadioButton";
            this.twelveRadioButton.Size = new System.Drawing.Size(72, 36);
            this.twelveRadioButton.TabIndex = 1;
            this.twelveRadioButton.Text = "12";
            this.twelveRadioButton.UseVisualStyleBackColor = true;
            this.twelveRadioButton.CheckedChanged += new System.EventHandler(this.twelveRadioButton_CheckedChanged);
            // 
            // eightTeenRadiobutton
            // 
            this.eightTeenRadiobutton.AutoSize = true;
            this.eightTeenRadiobutton.Location = new System.Drawing.Point(181, 45);
            this.eightTeenRadiobutton.Name = "eightTeenRadiobutton";
            this.eightTeenRadiobutton.Size = new System.Drawing.Size(72, 36);
            this.eightTeenRadiobutton.TabIndex = 2;
            this.eightTeenRadiobutton.TabStop = true;
            this.eightTeenRadiobutton.Text = "18";
            this.eightTeenRadiobutton.UseVisualStyleBackColor = true;
            this.eightTeenRadiobutton.CheckedChanged += new System.EventHandler(this.eightTeenRadiobutton_CheckedChanged);
            // 
            // twentyFourRadioButton
            // 
            this.twentyFourRadioButton.AutoSize = true;
            this.twentyFourRadioButton.Location = new System.Drawing.Point(181, 118);
            this.twentyFourRadioButton.Name = "twentyFourRadioButton";
            this.twentyFourRadioButton.Size = new System.Drawing.Size(72, 36);
            this.twentyFourRadioButton.TabIndex = 3;
            this.twentyFourRadioButton.TabStop = true;
            this.twentyFourRadioButton.Text = "24";
            this.twentyFourRadioButton.UseVisualStyleBackColor = true;
            this.twentyFourRadioButton.CheckedChanged += new System.EventHandler(this.twentyFourRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twentyFourRadioButton);
            this.groupBox1.Controls.Add(this.sixRadioButton);
            this.groupBox1.Controls.Add(this.eightTeenRadiobutton);
            this.groupBox1.Controls.Add(this.twelveRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(559, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Months";
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.Location = new System.Drawing.Point(946, 71);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(131, 36);
            this.rebateCheckBox.TabIndex = 5;
            this.rebateCheckBox.Text = "Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = true;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.rebateCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rebate Amount:";
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(946, 183);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(186, 39);
            this.rebateTextBox.TabIndex = 7;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebateTextBox_KeyPress);
            // 
            // monthListBox
            // 
            this.monthListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.ItemHeight = 27;
            this.monthListBox.Location = new System.Drawing.Point(65, 329);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(800, 436);
            this.monthListBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Interest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Principal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(909, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Loans:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(909, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Interest:";
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoansLabel.Location = new System.Drawing.Point(1140, 360);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(164, 45);
            this.totalLoansLabel.TabIndex = 19;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(922, 578);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(171, 79);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "&Calculate Loan";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(922, 686);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(171, 79);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "&Display All Loans";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(1140, 578);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(171, 79);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "&Accept Loan";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(1140, 686);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 79);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInterestLabel.Location = new System.Drawing.Point(1140, 435);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(164, 45);
            this.totalInterestLabel.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1374, 820);
            this.Controls.Add(this.totalInterestLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLoansLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.rebateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rebateCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.annualAprTextBox);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Loan Amortization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox annualAprTextBox;
        private System.Windows.Forms.RadioButton sixRadioButton;
        private System.Windows.Forms.RadioButton twelveRadioButton;
        private System.Windows.Forms.RadioButton eightTeenRadiobutton;
        private System.Windows.Forms.RadioButton twentyFourRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalInterestLabel;
    }
}

