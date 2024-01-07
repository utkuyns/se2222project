namespace carManagement
{
    partial class AddNewCustomerForm
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
            lblCustomerPhone = new Label();
            txtPhone = new TextBox();
            lblCustomerEmail = new Label();
            txtMail = new TextBox();
            lblCustomerSurname = new Label();
            txtLastName = new TextBox();
            btnSave = new Button();
            lblCustomerName = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomerPhone.Location = new Point(205, 210);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(135, 20);
            lblCustomerPhone.TabIndex = 17;
            lblCustomerPhone.Text = "Customer's Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(357, 207);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(252, 27);
            txtPhone.TabIndex = 16;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomerEmail.Location = new Point(209, 177);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(128, 20);
            lblCustomerEmail.TabIndex = 15;
            lblCustomerEmail.Text = "Customer's Email:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(357, 174);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(252, 27);
            txtMail.TabIndex = 14;
            // 
            // lblCustomerSurname
            // 
            lblCustomerSurname.AutoSize = true;
            lblCustomerSurname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomerSurname.Location = new Point(191, 141);
            lblCustomerSurname.Name = "lblCustomerSurname";
            lblCustomerSurname.Size = new Size(152, 20);
            lblCustomerSurname.TabIndex = 13;
            lblCustomerSurname.Text = "Customer's Surname:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(357, 138);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 27);
            txtLastName.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(518, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomerName.Location = new Point(205, 112);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(132, 20);
            lblCustomerName.TabIndex = 10;
            lblCustomerName.Text = "Customer's Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(357, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 27);
            txtFirstName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(332, 23);
            label1.TabIndex = 18;
            label1.Text = "Please enter new customer's informations.";
            // 
            // AddNewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 349);
            Controls.Add(label1);
            Controls.Add(lblCustomerPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblCustomerEmail);
            Controls.Add(txtMail);
            Controls.Add(lblCustomerSurname);
            Controls.Add(txtLastName);
            Controls.Add(btnSave);
            Controls.Add(lblCustomerName);
            Controls.Add(txtFirstName);
            Name = "AddNewCustomerForm";
            Text = "AddNewCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerPhone;
        private TextBox txtPhone;
        private Label lblCustomerEmail;
        private TextBox txtMail;
        private Label lblCustomerSurname;
        private TextBox txtLastName;
        private Button btnSave;
        private Label lblCustomerName;
        private TextBox txtFirstName;
        private Label label1;
    }
}