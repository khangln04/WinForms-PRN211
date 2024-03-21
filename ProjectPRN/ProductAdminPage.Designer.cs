namespace ProjectPRN
{
    partial class ProductAdminPage
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
            lbCustomer = new LinkLabel();
            lbProduct = new LinkLabel();
            lbOrder = new LinkLabel();
            lbOrderDetail = new LinkLabel();
            btProfile = new LinkLabel();
            label1 = new Label();
            btSearch = new TextBox();
            DATAGRIDVIEW = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbProductId = new TextBox();
            tbProductName = new TextBox();
            tbStatus = new ComboBox();
            tbDescription = new TextBox();
            tbImage = new TextBox();
            tbPrice = new TextBox();
            tbDiscount = new TextBox();
            btCategory = new TextBox();
            btLogout = new Button();
            btClear = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(161, 57);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(53, 20);
            lbAdmin.TabIndex = 0;
            lbAdmin.TabStop = true;
            lbAdmin.Text = "Admin";
            lbAdmin.LinkClicked += lbAdmin_LinkClicked;
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(276, 57);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(72, 20);
            lbCustomer.TabIndex = 1;
            lbCustomer.TabStop = true;
            lbCustomer.Text = "Customer";
            lbCustomer.LinkClicked += lbCustomer_LinkClicked;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(386, 57);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(60, 20);
            lbProduct.TabIndex = 2;
            lbProduct.TabStop = true;
            lbProduct.Text = "Product";
            lbProduct.LinkClicked += lbProduct_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(500, 57);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 3;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            lbOrder.LinkClicked += lbOrder_LinkClicked;
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new Point(596, 57);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(91, 20);
            lbOrderDetail.TabIndex = 4;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "Order Detail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // btProfile
            // 
            btProfile.AutoSize = true;
            btProfile.Location = new Point(723, 57);
            btProfile.Name = "btProfile";
            btProfile.Size = new Size(52, 20);
            btProfile.TabIndex = 5;
            btProfile.TabStop = true;
            btProfile.Text = "Profile";
            btProfile.LinkClicked += btProfile_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 146);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Search:";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(300, 143);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(276, 27);
            btSearch.TabIndex = 7;
            btSearch.TextChanged += btSearch_TextChanged;
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(27, 202);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(912, 473);
            DATAGRIDVIEW.TabIndex = 8;
            DATAGRIDVIEW.CellContentClick += dataGridView1_CellContentClick;
            DATAGRIDVIEW.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(986, 202);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "Product Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(986, 252);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 10;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(986, 294);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 11;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(986, 346);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 12;
            label5.Text = "Image:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(986, 393);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 13;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(986, 439);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "Discount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(986, 485);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 15;
            label8.Text = "Category Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(986, 539);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 16;
            label9.Text = "Status:";
            // 
            // tbProductId
            // 
            tbProductId.Location = new Point(1108, 199);
            tbProductId.Name = "tbProductId";
            tbProductId.Size = new Size(232, 27);
            tbProductId.TabIndex = 17;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(1108, 245);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(232, 27);
            tbProductName.TabIndex = 18;
            // 
            // tbStatus
            // 
            tbStatus.FormattingEnabled = true;
            tbStatus.Location = new Point(1108, 531);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(232, 28);
            tbStatus.TabIndex = 19;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(1108, 294);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(232, 27);
            tbDescription.TabIndex = 20;
            // 
            // tbImage
            // 
            tbImage.Location = new Point(1108, 346);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(232, 27);
            tbImage.TabIndex = 21;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1108, 393);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(232, 27);
            tbPrice.TabIndex = 22;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(1107, 439);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(233, 27);
            tbDiscount.TabIndex = 23;
            // 
            // btCategory
            // 
            btCategory.Location = new Point(1108, 485);
            btCategory.Name = "btCategory";
            btCategory.Size = new Size(232, 27);
            btCategory.TabIndex = 24;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1248, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(107, 46);
            btLogout.TabIndex = 25;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(1108, 592);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 26;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(1246, 592);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 27;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(1108, 646);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 28;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(1248, 646);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 29;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // ProductAdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 698);
            Controls.Add(btAdd);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClear);
            Controls.Add(btLogout);
            Controls.Add(btCategory);
            Controls.Add(tbDiscount);
            Controls.Add(tbPrice);
            Controls.Add(tbImage);
            Controls.Add(tbDescription);
            Controls.Add(tbStatus);
            Controls.Add(tbProductName);
            Controls.Add(tbProductId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DATAGRIDVIEW);
            Controls.Add(btSearch);
            Controls.Add(label1);
            Controls.Add(btProfile);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Controls.Add(lbAdmin);
            Name = "ProductAdminPage";
            Text = "ProductAdminPage";
            Load += ProductAdminPage_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbAdmin;
        private LinkLabel lbCustomer;
        private LinkLabel lbProduct;
        private LinkLabel lbOrder;
        private LinkLabel lbOrderDetail;
        private LinkLabel btProfile;
        private Label label1;
        private TextBox btSearch;
        private DataGridView DATAGRIDVIEW;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbProductId;
        private TextBox tbProductName;
        private ComboBox tbStatus;
        private TextBox tbDescription;
        private TextBox tbImage;
        private TextBox tbPrice;
        private TextBox tbDiscount;
        private TextBox btCategory;
        private Button btLogout;
        private Button btClear;
        private Button btDelete;
        private Button btUpdate;
        private Button btAdd;
    }
}