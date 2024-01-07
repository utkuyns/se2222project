namespace carManagement
{
    partial class ViewSalesForm
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
            btnViewSales = new Button();
            dateTimePickerSelectedDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Date:";
            // 
            // btnViewSales
            // 
            btnViewSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnViewSales.Location = new Point(520, 53);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(112, 35);
            btnViewSales.TabIndex = 1;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = true;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // dateTimePickerSelectedDate
            // 
            dateTimePickerSelectedDate.Location = new Point(219, 57);
            dateTimePickerSelectedDate.Name = "dateTimePickerSelectedDate";
            dateTimePickerSelectedDate.Size = new Size(244, 27);
            dateTimePickerSelectedDate.TabIndex = 2;
            // 
            // ViewSalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 155);
            Controls.Add(dateTimePickerSelectedDate);
            Controls.Add(btnViewSales);
            Controls.Add(label1);
            Name = "ViewSalesForm";
            Text = "ViewSalesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewSales;
        private DateTimePicker dateTimePickerSelectedDate;
    }
}