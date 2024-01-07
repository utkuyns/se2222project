namespace carManagement
{
    partial class FindCustomerIDForm
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
            lblPhone = new Label();
            lblMail = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            btnFindID = new Button();
            SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(182, 218);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(76, 28);
            lblPhone.TabIndex = 19;
            lblPhone.Text = "Phone:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(185, 165);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(73, 28);
            lblMail.TabIndex = 18;
            lblMail.Text = "E-mail:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLastName.Location = new Point(160, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 28);
            lblLastName.TabIndex = 17;
            lblLastName.Text = "Surname:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFirstName.Location = new Point(187, 68);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 28);
            lblFirstName.TabIndex = 16;
            lblFirstName.Text = "Name:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(286, 219);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(286, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(286, 121);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(261, 27);
            txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(286, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 27);
            txtFirstName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(568, 25);
            label1.TabIndex = 20;
            label1.Text = "Enter the information of the customer whose ID you want to know.";
            // 
            // btnFindID
            // 
            btnFindID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFindID.Location = new Point(444, 267);
            btnFindID.Name = "btnFindID";
            btnFindID.Size = new Size(103, 41);
            btnFindID.TabIndex = 21;
            btnFindID.Text = "FIND ID";
            btnFindID.UseVisualStyleBackColor = true;
            btnFindID.Click += btnFindID_Click;
            // 
            // FindCustomerIDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 349);
            Controls.Add(btnFindID);
            Controls.Add(label1);
            Controls.Add(lblPhone);
            Controls.Add(lblMail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "FindCustomerIDForm";
            Text = "FindCustomerIDForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhone;
        private Label lblMail;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnFindID;
    }
}