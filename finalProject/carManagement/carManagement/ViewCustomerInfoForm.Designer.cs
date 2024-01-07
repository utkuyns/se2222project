namespace carManagement
{
    partial class ViewCustomerInfoForm
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
            infoformlbl1 = new Label();
            ınfoformlbl2 = new Label();
            txtCustomerID = new TextBox();
            btnGetInfo = new Button();
            SuspendLayout();
            // 
            // infoformlbl1
            // 
            infoformlbl1.AutoSize = true;
            infoformlbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            infoformlbl1.Location = new Point(110, 37);
            infoformlbl1.Name = "infoformlbl1";
            infoformlbl1.Size = new Size(572, 28);
            infoformlbl1.TabIndex = 0;
            infoformlbl1.Text = "Please enter the ID of the customer whose information you want.";
            // 
            // ınfoformlbl2
            // 
            ınfoformlbl2.AutoSize = true;
            ınfoformlbl2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ınfoformlbl2.Location = new Point(226, 85);
            ınfoformlbl2.Name = "ınfoformlbl2";
            ınfoformlbl2.Size = new Size(37, 28);
            ınfoformlbl2.TabIndex = 1;
            ınfoformlbl2.Text = "ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(269, 89);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(222, 27);
            txtCustomerID.TabIndex = 2;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGetInfo.Location = new Point(303, 137);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(123, 33);
            btnGetInfo.TabIndex = 3;
            btnGetInfo.Text = "Get Info";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // ViewCustomerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 249);
            Controls.Add(btnGetInfo);
            Controls.Add(txtCustomerID);
            Controls.Add(ınfoformlbl2);
            Controls.Add(infoformlbl1);
            Name = "ViewCustomerInfoForm";
            Text = "ViewCustomerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoformlbl1;
        private Label ınfoformlbl2;
        private TextBox txtCustomerID;
        private Button btnGetInfo;
    }
}