namespace carManagement
{
    partial class ViewServiceForm
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
            txtCarID = new TextBox();
            btnGetInfo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(327, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 0;
            label1.Text = "Car ID:";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(239, 100);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(264, 27);
            txtCarID.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGetInfo.Location = new Point(312, 144);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(124, 44);
            btnGetInfo.TabIndex = 2;
            btnGetInfo.Text = "Get Info";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // ViewServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 238);
            Controls.Add(btnGetInfo);
            Controls.Add(txtCarID);
            Controls.Add(label1);
            Name = "ViewServiceForm";
            Text = "ViewServiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCarID;
        private Button btnGetInfo;
    }
}