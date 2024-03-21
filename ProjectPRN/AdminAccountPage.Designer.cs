namespace ProjectPRN
{
    partial class AdminAccountPage
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
            lbAdmin = new LinkLabel();
            label1 = new Label();
            lbCustomer = new LinkLabel();
            lbProduct = new LinkLabel();
            lbOrder = new LinkLabel();
            lbOrderDetail = new LinkLabel();
            lbProfille = new LinkLabel();
            tbSearch = new TextBox();
            DATAGRIDVIEW = new DataGridView();
            btLogout = new Button();
            tbAdminId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Account = new GroupBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            btClear = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            Account.SuspendLayout();
            SuspendLayout();
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(108, 52);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(53, 20);
            lbAdmin.TabIndex = 0;
            lbAdmin.TabStop = true;
            lbAdmin.Text = "Admin";
            lbAdmin.LinkClicked += lbAdmin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 115);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(187, 52);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(72, 20);
            lbCustomer.TabIndex = 2;
            lbCustomer.TabStop = true;
            lbCustomer.Text = "Customer";
            lbCustomer.LinkClicked += lbCustomer_LinkClicked;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(285, 52);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(60, 20);
            lbProduct.TabIndex = 3;
            lbProduct.TabStop = true;
            lbProduct.Text = "Product";
            lbProduct.LinkClicked += lbProduct_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(375, 52);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 4;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new Point(455, 52);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(91, 20);
            lbOrderDetail.TabIndex = 5;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "Order Detail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // lbProfille
            // 
            lbProfille.AutoSize = true;
            lbProfille.Location = new Point(590, 52);
            lbProfille.Name = "lbProfille";
            lbProfille.Size = new Size(52, 20);
            lbProfille.TabIndex = 6;
            lbProfille.TabStop = true;
            lbProfille.Text = "Profile";
            lbProfille.LinkClicked += lbProfille_LinkClicked;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(271, 115);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(275, 27);
            tbSearch.TabIndex = 7;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(25, 186);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(865, 491);
            DATAGRIDVIEW.TabIndex = 8;
            DATAGRIDVIEW.CellContentClick += DATAGRIDVIEW_CellContentClick;
            DATAGRIDVIEW.CellClick += DATAGRIDVIEW_CellClick;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1188, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(105, 45);
            btLogout.TabIndex = 9;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // tbAdminId
            // 
            tbAdminId.Location = new Point(1018, 186);
            tbAdminId.Name = "tbAdminId";
            tbAdminId.Size = new Size(249, 27);
            tbAdminId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(934, 193);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Admin Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(934, 255);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(934, 309);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 13;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 59);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 111);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // Account
            // 
            Account.Controls.Add(tbPassword);
            Account.Controls.Add(tbUsername);
            Account.Controls.Add(label6);
            Account.Controls.Add(label5);
            Account.Location = new Point(922, 387);
            Account.Name = "Account";
            Account.Size = new Size(358, 186);
            Account.TabIndex = 16;
            Account.TabStop = false;
            Account.Text = "Account";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(96, 108);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(249, 27);
            tbPassword.TabIndex = 17;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(96, 56);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(249, 27);
            tbUsername.TabIndex = 16;
            // 
            // tbName
            // 
            tbName.Location = new Point(1018, 255);
            tbName.Name = "tbName";
            tbName.Size = new Size(249, 27);
            tbName.TabIndex = 17;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(1018, 306);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(249, 27);
            tbPhone.TabIndex = 18;
            // 
            // btClear
            // 
            btClear.Location = new Point(989, 597);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 19;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(1140, 597);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 20;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(989, 648);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 21;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(1140, 648);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 22;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // AdminAccountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 712);
            Controls.Add(btAdd);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClear);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(Account);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAdminId);
            Controls.Add(btLogout);
            Controls.Add(DATAGRIDVIEW);
            Controls.Add(tbSearch);
            Controls.Add(lbProfille);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Controls.Add(label1);
            Controls.Add(lbAdmin);
            Name = "AdminAccountPage";
            Text = "AdminAccountPage";
            Load += AdminAccountPage_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).EndInit();
            Account.ResumeLayout(false);
            Account.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbAdmin;
        private Label label1;
        private LinkLabel lbCustomer;
        private LinkLabel lbProduct;
        private LinkLabel lbOrder;
        private LinkLabel lbOrderDetail;
        private LinkLabel lbProfille;
        private TextBox tbSearch;
        private DataGridView DATAGRIDVIEW;
        private Button btLogout;
        private TextBox tbAdminId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox Account;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private TextBox tbName;
        private TextBox tbPhone;
        private Button btClear;
        private Button btDelete;
        private Button btUpdate;
        private Button btAdd;
    }
}