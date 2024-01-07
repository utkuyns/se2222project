namespace carManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddCustomer = new Button();
            notifyIcon1 = new NotifyIcon(components);
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnViewCustomer = new Button();
            btnFindCustomerID = new Button();
            btnAddCar = new Button();
            btnDeleteCar = new Button();
            btnViewCar = new Button();
            btnFindCarID = new Button();
            btnAddSale = new Button();
            btnViewSales = new Button();
            btnAddService = new Button();
            btnViewService = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(18, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 36);
            label1.TabIndex = 0;
            label1.Text = "MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(1496, 29);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(392, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(76, 407);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 2;
            label2.Text = "     CAR       ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(75, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 3;
            label3.Text = "CUSTOMER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(75, 580);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 27);
            label4.TabIndex = 4;
            label4.Text = "      SALE     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(72, 714);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 27);
            label5.TabIndex = 5;
            label5.Text = "   SERVICE   ";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddCustomer.Location = new Point(322, 242);
            btnAddCustomer.Margin = new Padding(4);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(285, 70);
            btnAddCustomer.TabIndex = 6;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.White;
            btnDeleteCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDeleteCustomer.Location = new Point(644, 242);
            btnDeleteCustomer.Margin = new Padding(4);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(285, 70);
            btnDeleteCustomer.TabIndex = 8;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.White;
            btnUpdateCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdateCustomer.Location = new Point(966, 242);
            btnUpdateCustomer.Margin = new Padding(4);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(285, 70);
            btnUpdateCustomer.TabIndex = 9;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.BackColor = Color.White;
            btnViewCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnViewCustomer.Location = new Point(1281, 242);
            btnViewCustomer.Margin = new Padding(4);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(285, 70);
            btnViewCustomer.TabIndex = 10;
            btnViewCustomer.Text = "View Customer";
            btnViewCustomer.UseVisualStyleBackColor = false;
            btnViewCustomer.Click += btnViewCustomer_Click;
            // 
            // btnFindCustomerID
            // 
            btnFindCustomerID.BackColor = Color.White;
            btnFindCustomerID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFindCustomerID.Location = new Point(1605, 242);
            btnFindCustomerID.Margin = new Padding(4);
            btnFindCustomerID.Name = "btnFindCustomerID";
            btnFindCustomerID.Size = new Size(285, 70);
            btnFindCustomerID.TabIndex = 11;
            btnFindCustomerID.Text = "Find Customer ID";
            btnFindCustomerID.UseVisualStyleBackColor = false;
            btnFindCustomerID.Click += btnFindCustomerID_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddCar.Location = new Point(322, 395);
            btnAddCar.Margin = new Padding(4);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(285, 57);
            btnAddCar.TabIndex = 12;
            btnAddCar.Text = "Add New Car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDeleteCar.Location = new Point(644, 392);
            btnDeleteCar.Margin = new Padding(4);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(285, 57);
            btnDeleteCar.TabIndex = 13;
            btnDeleteCar.Text = "Delete Car";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnViewCar
            // 
            btnViewCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnViewCar.Location = new Point(966, 395);
            btnViewCar.Margin = new Padding(4);
            btnViewCar.Name = "btnViewCar";
            btnViewCar.Size = new Size(285, 57);
            btnViewCar.TabIndex = 14;
            btnViewCar.Text = "View Car  ";
            btnViewCar.UseVisualStyleBackColor = true;
            btnViewCar.Click += btnViewCar_Click;
            // 
            // btnFindCarID
            // 
            btnFindCarID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFindCarID.Location = new Point(1281, 395);
            btnFindCarID.Margin = new Padding(4);
            btnFindCarID.Name = "btnFindCarID";
            btnFindCarID.Size = new Size(285, 50);
            btnFindCarID.TabIndex = 15;
            btnFindCarID.Text = "Find Car ID";
            btnFindCarID.UseVisualStyleBackColor = true;
            btnFindCarID.Click += btnFindCarID_Click;
            // 
            // btnAddSale
            // 
            btnAddSale.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddSale.Location = new Point(322, 567);
            btnAddSale.Margin = new Padding(4);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(285, 49);
            btnAddSale.TabIndex = 16;
            btnAddSale.Text = "Add Sale";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // btnViewSales
            // 
            btnViewSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnViewSales.Location = new Point(644, 567);
            btnViewSales.Margin = new Padding(4);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(285, 49);
            btnViewSales.TabIndex = 17;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = true;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(322, 707);
            btnAddService.Margin = new Padding(4);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(285, 43);
            btnAddService.TabIndex = 18;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnViewService
            // 
            btnViewService.Location = new Point(644, 707);
            btnViewService.Name = "btnViewService";
            btnViewService.Size = new Size(285, 43);
            btnViewService.TabIndex = 19;
            btnViewService.Text = "View Service";
            btnViewService.UseVisualStyleBackColor = true;
            btnViewService.Click += btnViewService_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1923, 792);
            Controls.Add(btnViewService);
            Controls.Add(btnAddService);
            Controls.Add(btnViewSales);
            Controls.Add(btnAddSale);
            Controls.Add(btnFindCarID);
            Controls.Add(btnViewCar);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnAddCar);
            Controls.Add(btnFindCustomerID);
            Controls.Add(btnViewCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Automobile Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddCustomer;
        private NotifyIcon notifyIcon1;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnViewCustomer;
        private Button btnFindCustomerID;
        private Button btnAddCar;
        private Button btnDeleteCar;
        private Button btnViewCar;
        private Button btnFindCarID;
        private Button btnAddSale;
        private Button btnViewSales;
        private Button btnAddService;
        private Button btnViewService;
    }
}
