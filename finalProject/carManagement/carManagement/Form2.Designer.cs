namespace carManagement
{
    partial class DeleteCustomerForm
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
            deleteInfoLabel = new Label();
            txtCustomerID = new TextBox();
            IDLabel = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // deleteInfoLabel
            // 
            deleteInfoLabel.AutoSize = true;
            deleteInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            deleteInfoLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteInfoLabel.Location = new Point(99, 159);
            deleteInfoLabel.Name = "deleteInfoLabel";
            deleteInfoLabel.Size = new Size(514, 33);
            deleteInfoLabel.TabIndex = 0;
            deleteInfoLabel.Text = "Enter the ID of the customer you want to delete.";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Cursor = Cursors.IBeam;
            txtCustomerID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCustomerID.Location = new Point(216, 114);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(282, 31);
            txtCustomerID.TabIndex = 1;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IDLabel.Location = new Point(328, 68);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(44, 31);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "ID:";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(274, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(738, 289);
            Controls.Add(btnDelete);
            Controls.Add(IDLabel);
            Controls.Add(txtCustomerID);
            Controls.Add(deleteInfoLabel);
            Name = "DeleteCustomerForm";
            Text = "Delete Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deleteInfoLabel;
        private TextBox txtCustomerID;
        private Label IDLabel;
        private Button btnDelete;
    }
}