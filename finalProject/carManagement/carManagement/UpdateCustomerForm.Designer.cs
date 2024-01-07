namespace carManagement
{
    partial class UpdateCustomerForm
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
            formScreenInfo1 = new Label();
            formScreenInfo2 = new Label();
            IDlbl = new Label();
            txtCustomerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblMail = new Label();
            lblPhone = new Label();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // formScreenInfo1
            // 
            formScreenInfo1.AutoSize = true;
            formScreenInfo1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            formScreenInfo1.Location = new Point(12, 9);
            formScreenInfo1.Name = "formScreenInfo1";
            formScreenInfo1.Size = new Size(672, 23);
            formScreenInfo1.TabIndex = 0;
            formScreenInfo1.Text = "Enter the current information of the customer whose information you want to update.";
            // 
            // formScreenInfo2
            // 
            formScreenInfo2.AutoSize = true;
            formScreenInfo2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            formScreenInfo2.Location = new Point(12, 29);
            formScreenInfo2.Name = "formScreenInfo2";
            formScreenInfo2.Size = new Size(380, 25);
            formScreenInfo2.TabIndex = 1;
            formScreenInfo2.Text = "Click the \"SAVE\" button to save the changes.";
            // 
            // IDlbl
            // 
            IDlbl.AutoSize = true;
            IDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IDlbl.Location = new Point(250, 140);
            IDlbl.Name = "IDlbl";
            IDlbl.Size = new Size(37, 28);
            IDlbl.TabIndex = 2;
            IDlbl.Text = "ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(315, 140);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(221, 27);
            txtCustomerID.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(315, 187);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(221, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(315, 240);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(315, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(315, 338);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(221, 27);
            txtPhone.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFirstName.Location = new Point(216, 187);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 28);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLastName.Location = new Point(189, 239);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 28);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Surname:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(214, 284);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(73, 28);
            lblMail.TabIndex = 10;
            lblMail.Text = "E-mail:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(211, 337);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(76, 28);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(435, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 53);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "SAVE UPDATES";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 13;
            label1.Text = "The customer's ID cannot be changed!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(285, 25);
            label2.TabIndex = 14;
            label2.Text = "ID is used to verify the customer.";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 480);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(lblPhone);
            Controls.Add(lblMail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCustomerID);
            Controls.Add(IDlbl);
            Controls.Add(formScreenInfo2);
            Controls.Add(formScreenInfo1);
            Name = "UpdateCustomerForm";
            Text = "Update Customer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formScreenInfo1;
        private Label formScreenInfo2;
        private Label IDlbl;
        private TextBox txtCustomerID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblMail;
        private Label lblPhone;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
    }
}