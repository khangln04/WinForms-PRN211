namespace ProjectPRN
{
    partial class AdminHomePage
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
            lbCustomer = new LinkLabel();
            lbProduct = new LinkLabel();
            lbOrder = new LinkLabel();
            lbOrderDetail = new LinkLabel();
            lbAdmin = new LinkLabel();
            DATAGRIDVIEW = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btClear = new Button();
            btDelete = new Button();
            btAdd = new Button();
            btUpdate = new Button();
            groupBox1 = new GroupBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btLogout = new Button();
            tbCustomerId = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            lbProfile = new LinkLabel();
            tbStatus = new ComboBox();
            label8 = new Label();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(212, 27);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(72, 20);
            lbCustomer.TabIndex = 0;
            lbCustomer.TabStop = true;
            lbCustomer.Text = "Customer";
            lbCustomer.LinkClicked += lbCustomer_LinkClicked;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(318, 27);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(60, 20);
            lbProduct.TabIndex = 1;
            lbProduct.TabStop = true;
            lbProduct.Text = "Product";
            lbProduct.LinkClicked += lbProduct_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(411, 27);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 2;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            lbOrder.LinkClicked += lbOrder_LinkClicked;
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new Point(507, 27);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(91, 20);
            lbOrderDetail.TabIndex = 3;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "Order Detail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(118, 27);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(53, 20);
            lbAdmin.TabIndex = 4;
            lbAdmin.TabStop = true;
            lbAdmin.Text = "Admin";
            lbAdmin.LinkClicked += lbAdmin_LinkClicked;
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(31, 145);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(799, 546);
            DATAGRIDVIEW.TabIndex = 5;
            DATAGRIDVIEW.CellClick += DATAGRIDVIEW_CellClick;
            DATAGRIDVIEW.CellContentClick += DATAGRIDVIEW_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(898, 145);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "Customer Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(899, 186);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(898, 232);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(898, 281);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 55);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 10;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 100);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(898, 330);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 12;
            label7.Text = "Status:";
            // 
            // btClear
            // 
            btClear.Location = new Point(948, 590);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 13;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(1082, 590);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(93, 32);
            btDelete.TabIndex = 14;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(1081, 641);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 15;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(948, 641);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 16;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(898, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 172);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Account";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(111, 97);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(202, 27);
            tbPassword.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(111, 52);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(202, 27);
            tbUsername.TabIndex = 12;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1097, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(114, 42);
            btLogout.TabIndex = 18;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // tbCustomerId
            // 
            tbCustomerId.Location = new Point(1009, 138);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(202, 27);
            tbCustomerId.TabIndex = 19;
            // 
            // tbName
            // 
            tbName.Location = new Point(1009, 183);
            tbName.Name = "tbName";
            tbName.Size = new Size(202, 27);
            tbName.TabIndex = 20;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(1009, 229);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(202, 27);
            tbPhone.TabIndex = 21;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(1009, 281);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(202, 27);
            tbAddress.TabIndex = 22;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(624, 27);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 24;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // tbStatus
            // 
            tbStatus.FormattingEnabled = true;
            tbStatus.Items.AddRange(new object[] { "Active", "Deactivate" });
            tbStatus.Location = new Point(1009, 330);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(202, 28);
            tbStatus.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 104);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 26;
            label8.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(246, 101);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(287, 27);
            tbSearch.TabIndex = 27;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 700);
            Controls.Add(tbSearch);
            Controls.Add(label8);
            Controls.Add(tbStatus);
            Controls.Add(lbProfile);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(tbCustomerId);
            Controls.Add(btLogout);
            Controls.Add(groupBox1);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(btDelete);
            Controls.Add(btClear);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DATAGRIDVIEW);
            Controls.Add(lbAdmin);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            Load += AdminHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbCustomer;
        private LinkLabel lbProduct;
        private LinkLabel lbOrder;
        private LinkLabel lbOrderDetail;
        private LinkLabel lbAdmin;
        private DataGridView DATAGRIDVIEW;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btClear;
        private Button btDelete;
        private Button btAdd;
        private Button btUpdate;
        private GroupBox groupBox1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Button btLogout;
        private TextBox tbCustomerId;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private LinkLabel lbProfile;
        private ComboBox tbStatus;
        private Label label8;
        private TextBox tbSearch;
    }
}