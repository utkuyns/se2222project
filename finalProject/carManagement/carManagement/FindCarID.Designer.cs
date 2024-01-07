namespace carManagement
{
    partial class FindCarID
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            btnGetInfo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 73);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 137);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Customer Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 197);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter Customer Phone:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(368, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(163, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(368, 132);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(368, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 27);
            txtPhone.TabIndex = 5;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(423, 259);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(108, 39);
            btnGetInfo.TabIndex = 6;
            btnGetInfo.Text = "Get Info";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // FindCarID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetInfo);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FindCarID";
            Text = "FindCarID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Button btnGetInfo;
    }
}