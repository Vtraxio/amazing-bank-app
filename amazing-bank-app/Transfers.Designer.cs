namespace amazing_bank_app
{
    partial class Transfers
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
            transactionsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            typeCombo = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // transactionsList
            // 
            transactionsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            tableLayoutPanel1.SetColumnSpan(transactionsList, 2);
            transactionsList.Dock = DockStyle.Fill;
            transactionsList.Location = new Point(3, 32);
            transactionsList.Name = "transactionsList";
            transactionsList.Size = new Size(794, 415);
            transactionsList.TabIndex = 0;
            transactionsList.UseCompatibleStateImageBehavior = false;
            transactionsList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tytuł";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Imie";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Numer Rachunku";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kwota";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Data";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(transactionsList, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(typeCombo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Typ przlewu";
            // 
            // typeCombo
            // 
            typeCombo.Anchor = AnchorStyles.Left;
            typeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCombo.FormattingEnabled = true;
            typeCombo.Items.AddRange(new object[] { "Wysłane", "Otrzymane" });
            typeCombo.Location = new Point(78, 3);
            typeCombo.Name = "typeCombo";
            typeCombo.Size = new Size(121, 23);
            typeCombo.TabIndex = 2;
            typeCombo.SelectedIndexChanged += typeCombo_SelectedIndexChanged;
            // 
            // Transfers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Transfers";
            Text = "Transfers";
            Load += Transfers_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private ListView transactionsList;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox typeCombo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}