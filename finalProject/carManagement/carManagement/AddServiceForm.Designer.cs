namespace carManagement
{
    partial class AddServiceForm
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
            label4 = new Label();
            txtCarID = new TextBox();
            txtServiceType = new TextBox();
            dateTimePickerServiceDate = new DateTimePicker();
            txtTechnicianName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 57);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Car ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Service Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 151);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Service Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 205);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 3;
            label4.Text = "Technician Name:";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(325, 54);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(231, 27);
            txtCarID.TabIndex = 4;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(323, 100);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(233, 27);
            txtServiceType.TabIndex = 5;
            // 
            // dateTimePickerServiceDate
            // 
            dateTimePickerServiceDate.Location = new Point(325, 146);
            dateTimePickerServiceDate.Name = "dateTimePickerServiceDate";
            dateTimePickerServiceDate.Size = new Size(231, 27);
            dateTimePickerServiceDate.TabIndex = 6;
            // 
            // txtTechnicianName
            // 
            txtTechnicianName.Location = new Point(323, 200);
            txtTechnicianName.Name = "txtTechnicianName";
            txtTechnicianName.Size = new Size(233, 27);
            txtTechnicianName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(477, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtTechnicianName);
            Controls.Add(dateTimePickerServiceDate);
            Controls.Add(txtServiceType);
            Controls.Add(txtCarID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddServiceForm";
            Text = "AddServiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCarID;
        private TextBox txtServiceType;
        private DateTimePicker dateTimePickerServiceDate;
        private TextBox txtTechnicianName;
        private Button btnSave;
    }
}