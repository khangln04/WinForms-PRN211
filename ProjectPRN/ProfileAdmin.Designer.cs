namespace ProjectPRN
{
    partial class ProfileAdmin
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tbID = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            btSave = new Button();
            btLogout = new Button();
            lbAdmin = new LinkLabel();
            lbCustomer = new LinkLabel();
            lbProduct = new LinkLabel();
            lbOrder = new LinkLabel();
            lbOrderDetail = new LinkLabel();
            lbProfile = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 131);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 177);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 221);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 43);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 96);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(243, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 148);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(117, 93);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(194, 27);
            tbPassword.TabIndex = 6;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(117, 40);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(194, 27);
            tbUsername.TabIndex = 5;
            // 
            // tbID
            // 
            tbID.Location = new Point(360, 134);
            tbID.Name = "tbID";
            tbID.Size = new Size(194, 27);
            tbID.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(360, 177);
            tbName.Name = "tbName";
            tbName.Size = new Size(194, 27);
            tbName.TabIndex = 7;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(360, 221);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(194, 27);
            tbPhone.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.Location = new Point(384, 431);
            btSave.Name = "btSave";
            btSave.Size = new Size(113, 41);
            btSave.TabIndex = 9;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(882, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(100, 41);
            btLogout.TabIndex = 10;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(89, 29);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(53, 20);
            lbAdmin.TabIndex = 11;
            lbAdmin.TabStop = true;
            lbAdmin.Text = "Admin";
            lbAdmin.LinkClicked += lbAdmin_LinkClicked;
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(200, 29);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(72, 20);
            lbCustomer.TabIndex = 12;
            lbCustomer.TabStop = true;
            lbCustomer.Text = "Customer";
            lbCustomer.LinkClicked += lbCustomer_LinkClicked;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(318, 29);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(60, 20);
            lbProduct.TabIndex = 13;
            lbProduct.TabStop = true;
            lbProduct.Text = "Product";
            lbProduct.LinkClicked += lbProduct_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(423, 29);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 14;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            lbOrder.LinkClicked += lbOrder_LinkClicked;
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new Point(520, 29);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(91, 20);
            lbOrderDetail.TabIndex = 15;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "Order Detail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(652, 29);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 16;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // ProfileAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 556);
            Controls.Add(lbProfile);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Controls.Add(lbAdmin);
            Controls.Add(btLogout);
            Controls.Add(btSave);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileAdmin";
            Text = "ProfileAdmin";
            Load += ProfileAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbPhone;
        private Button btSave;
        private Button btLogout;
        private LinkLabel lbAdmin;
        private LinkLabel lbCustomer;
        private LinkLabel lbProduct;
        private LinkLabel lbOrder;
        private LinkLabel lbOrderDetail;
        private LinkLabel lbProfile;
    }
}