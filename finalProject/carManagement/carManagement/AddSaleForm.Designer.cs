namespace carManagement
{
    partial class AddSaleForm
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
            txtCarID = new TextBox();
            txtCustomerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerSalesDate = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(227, 52);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(151, 27);
            txtCarID.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(227, 113);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(151, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 55);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Car ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 120);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Sale Date:";
            // 
            // dateTimePickerSalesDate
            // 
            dateTimePickerSalesDate.Location = new Point(231, 181);
            dateTimePickerSalesDate.Name = "dateTimePickerSalesDate";
            dateTimePickerSalesDate.Size = new Size(147, 27);
            dateTimePickerSalesDate.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(261, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 27);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE SALE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 376);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerSalesDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCarID);
            Name = "AddSaleForm";
            Text = "AddSaleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarID;
        private TextBox txtCustomerID;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerSalesDate;
        private Button btnSave;
    }
}