namespace amazing_bank_app
{
    partial class NewTransfer
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
            targetTxt = new TextBox();
            amountNum = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            transferBtn = new Button();
            titleTxt = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)amountNum).BeginInit();
            SuspendLayout();
            // 
            // targetTxt
            // 
            targetTxt.Location = new Point(131, 12);
            targetTxt.Name = "targetTxt";
            targetTxt.Size = new Size(120, 23);
            targetTxt.TabIndex = 0;
            // 
            // amountNum
            // 
            amountNum.DecimalPlaces = 2;
            amountNum.Location = new Point(131, 41);
            amountNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountNum.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            amountNum.Name = "amountNum";
            amountNum.Size = new Size(120, 23);
            amountNum.TabIndex = 1;
            amountNum.ThousandsSeparator = true;
            amountNum.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Rachunek docelowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Kwota";
            // 
            // transferBtn
            // 
            transferBtn.Location = new Point(12, 99);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(239, 23);
            transferBtn.TabIndex = 4;
            transferBtn.Text = "Wykonaj Przelew";
            transferBtn.UseVisualStyleBackColor = true;
            transferBtn.Click += transferBtn_Click;
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(131, 70);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(120, 23);
            titleTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Tytuł";
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 134);
            Controls.Add(label3);
            Controls.Add(titleTxt);
            Controls.Add(transferBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(amountNum);
            Controls.Add(targetTxt);
            Name = "NewTransfer";
            Text = "NewTransfer";
            ((System.ComponentModel.ISupportInitialize)amountNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox targetTxt;
        private NumericUpDown amountNum;
        private Label label1;
        private Label label2;
        private Button transferBtn;
        private TextBox titleTxt;
        private Label label3;
    }
}