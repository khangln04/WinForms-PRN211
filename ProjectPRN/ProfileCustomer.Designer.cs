namespace ProjectPRN
{
    partial class ProfileCustomer
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
            lbHome = new LinkLabel();
            lbOrder = new LinkLabel();
            lbProfile = new LinkLabel();
            tbCustomerID = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btSave = new Button();
            btLogout = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            tbAddress = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Location = new Point(242, 40);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(50, 20);
            lbHome.TabIndex = 0;
            lbHome.TabStop = true;
            lbHome.Text = "Home";
            lbHome.LinkClicked += lbHome_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(428, 40);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 1;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            lbOrder.LinkClicked += lbOrder_LinkClicked;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(575, 40);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 2;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(428, 127);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(188, 27);
            tbCustomerID.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(428, 177);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 27);
            tbName.TabIndex = 4;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(428, 237);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(188, 27);
            tbPhone.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(115, 52);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(188, 27);
            tbUsername.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(115, 117);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(188, 27);
            tbPassword.TabIndex = 7;
            // 
            // btSave
            // 
            btSave.Location = new Point(467, 540);
            btSave.Name = "btSave";
            btSave.Size = new Size(113, 45);
            btSave.TabIndex = 8;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(884, 23);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(105, 45);
            btLogout.TabIndex = 9;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Location = new Point(313, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 175);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 120);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 184);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 237);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 12;
            label2.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 293);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 13;
            label3.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 130);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 14;
            label6.Text = "ID:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(428, 293);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(188, 27);
            tbAddress.TabIndex = 15;
            // 
            // ProfileCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 644);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btLogout);
            Controls.Add(btSave);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(tbCustomerID);
            Controls.Add(lbProfile);
            Controls.Add(lbOrder);
            Controls.Add(lbHome);
            Name = "ProfileCustomer";
            Text = "ProfileCustomer";
            Load += ProfileCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbHome;
        private LinkLabel lbOrder;
        private LinkLabel lbProfile;
        private TextBox tbCustomerID;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btSave;
        private Button btLogout;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox tbAddress;
    }
}