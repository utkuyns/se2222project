namespace carManagement
{
    partial class ViewCarForm
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
            txtCarID = new TextBox();
            label2 = new Label();
            btnGetInfo = new Button();
            btnViewOldestCar = new Button();
            label3 = new Label();
            label4 = new Label();
            btnViewNewestCar = new Button();
            label5 = new Label();
            txtMake = new TextBox();
            btnGetSameMake = new Button();
            label1 = new Label();
            txtModel = new TextBox();
            btnGetSameModel = new Button();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(389, 79);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(131, 27);
            txtCarID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(53, 78);
            label2.Name = "label2";
            label2.Size = new Size(318, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter Car ID for car owner information:";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(562, 79);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(131, 27);
            btnGetInfo.TabIndex = 3;
            btnGetInfo.Text = "Get Info";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // btnViewOldestCar
            // 
            btnViewOldestCar.Location = new Point(562, 122);
            btnViewOldestCar.Name = "btnViewOldestCar";
            btnViewOldestCar.Size = new Size(131, 29);
            btnViewOldestCar.TabIndex = 4;
            btnViewOldestCar.Text = "View Oldest Car";
            btnViewOldestCar.UseVisualStyleBackColor = true;
            btnViewOldestCar.Click += btnViewOldestCar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 131);
            label3.Name = "label3";
            label3.Size = new Size(516, 20);
            label3.TabIndex = 5;
            label3.Text = "Click for oldest car................................................................................................................................";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 184);
            label4.Name = "label4";
            label4.Size = new Size(515, 20);
            label4.TabIndex = 6;
            label4.Text = "Click for newest car..............................................................................................................................";
            // 
            // btnViewNewestCar
            // 
            btnViewNewestCar.Location = new Point(562, 176);
            btnViewNewestCar.Name = "btnViewNewestCar";
            btnViewNewestCar.Size = new Size(131, 28);
            btnViewNewestCar.TabIndex = 7;
            btnViewNewestCar.Text = "View Newest Car";
            btnViewNewestCar.UseVisualStyleBackColor = true;
            btnViewNewestCar.Click += btnViewNewestCar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 238);
            label5.Name = "label5";
            label5.Size = new Size(288, 20);
            label5.TabIndex = 8;
            label5.Text = "Enter make name to view same make cars:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(389, 231);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(131, 27);
            txtMake.TabIndex = 9;
            // 
            // btnGetSameMake
            // 
            btnGetSameMake.Location = new Point(562, 231);
            btnGetSameMake.Name = "btnGetSameMake";
            btnGetSameMake.Size = new Size(131, 27);
            btnGetSameMake.TabIndex = 10;
            btnGetSameMake.Text = "Get Same Make";
            btnGetSameMake.UseVisualStyleBackColor = true;
            btnGetSameMake.Click += btnGetSameMake_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 290);
            label1.Name = "label1";
            label1.Size = new Size(302, 20);
            label1.TabIndex = 11;
            label1.Text = "Enter model name to view same model cars:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(389, 287);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(131, 27);
            txtModel.TabIndex = 12;
            // 
            // btnGetSameModel
            // 
            btnGetSameModel.Location = new Point(562, 292);
            btnGetSameModel.Name = "btnGetSameModel";
            btnGetSameModel.Size = new Size(131, 25);
            btnGetSameModel.TabIndex = 13;
            btnGetSameModel.Text = "Get Same Model";
            btnGetSameModel.UseVisualStyleBackColor = true;
            btnGetSameModel.Click += btnGetSameModel_Click;
            // 
            // ViewCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetSameModel);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(btnGetSameMake);
            Controls.Add(txtMake);
            Controls.Add(label5);
            Controls.Add(btnViewNewestCar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnViewOldestCar);
            Controls.Add(btnGetInfo);
            Controls.Add(label2);
            Controls.Add(txtCarID);
            Name = "ViewCarForm";
            Text = "ViewCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCarID;
        private Label label2;
        private Button btnGetInfo;
        private Button btnViewOldestCar;
        private Label label3;
        private Label label4;
        private Button btnViewNewestCar;
        private Label label5;
        private TextBox txtMake;
        private Button btnGetSameMake;
        private Label label1;
        private TextBox txtModel;
        private Button btnGetSameModel;
    }
}