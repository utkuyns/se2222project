namespace carManagement
{
    partial class DeleteCarForm
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
            IDLabel = new Label();
            txtCarID = new TextBox();
            deleteInfoLabel = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IDLabel.Location = new Point(354, 79);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(85, 31);
            IDLabel.TabIndex = 6;
            IDLabel.Text = "Car ID:";
            // 
            // txtCarID
            // 
            txtCarID.Cursor = Cursors.IBeam;
            txtCarID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCarID.Location = new Point(257, 113);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(282, 31);
            txtCarID.TabIndex = 5;
            // 
            // deleteInfoLabel
            // 
            deleteInfoLabel.AutoSize = true;
            deleteInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            deleteInfoLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteInfoLabel.Location = new Point(162, 158);
            deleteInfoLabel.Name = "deleteInfoLabel";
            deleteInfoLabel.Size = new Size(449, 33);
            deleteInfoLabel.TabIndex = 4;
            deleteInfoLabel.Text = "Enter the ID of the car you want to delete.";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(310, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE CAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 290);
            Controls.Add(btnDelete);
            Controls.Add(IDLabel);
            Controls.Add(txtCarID);
            Controls.Add(deleteInfoLabel);
            Name = "DeleteCarForm";
            Text = "Delete Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IDLabel;
        private TextBox txtCarID;
        private Label deleteInfoLabel;
        private Button btnDelete;
    }
}