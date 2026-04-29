namespace FutureValue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonthlyInvestment = new TextBox();
            txtInterestRate = new TextBox();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 67);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "Yearly Interest Rate:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 112);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Number of Years:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 158);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Future Value:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(211, 22);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(125, 27);
            txtMonthlyInvestment.TabIndex = 4;
            txtMonthlyInvestment.TextChanged += ClearFutureValue;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(211, 67);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(125, 27);
            txtInterestRate.TabIndex = 5;
            txtInterestRate.TextChanged += ClearFutureValue;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(211, 112);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(125, 27);
            txtYears.TabIndex = 6;
            txtYears.TextChanged += ClearFutureValue;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(211, 158);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(125, 27);
            txtFutureValue.TabIndex = 7;
            txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(118, 201);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(242, 201);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(365, 252);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtFutureValue);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonthlyInvestment;
        private TextBox txtInterestRate;
        private TextBox txtYears;
        private TextBox txtFutureValue;
        private Button btnCalculate;
        private Button btnExit;
    }
}
