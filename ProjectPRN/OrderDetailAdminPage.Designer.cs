namespace ProjectPRN
{
    partial class OrderDetailAdminPage
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
            lbProfile = new LinkLabel();
            btLogout = new Button();
            DATAGRIDVIEW = new DataGridView();
            label1 = new Label();
            tbSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btOrderdetailID = new TextBox();
            tbOrderID = new TextBox();
            tbCustomerID = new TextBox();
            tbProductID = new TextBox();
            tbProductName = new TextBox();
            tbImage = new TextBox();
            tbPrice = new TextBox();
            tbQuantityOrder = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(85, 47);
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
            lbCustomer.Location = new Point(187, 47);
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
            lbProduct.Location = new Point(304, 47);
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
            lbOrder.Location = new Point(410, 47);
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
            lbOrderDetail.Location = new Point(512, 47);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(87, 20);
            lbOrderDetail.TabIndex = 4;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "OrderDetail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(638, 47);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 5;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1101, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(111, 43);
            btLogout.TabIndex = 6;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(44, 167);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(774, 512);
            DATAGRIDVIEW.TabIndex = 7;
            DATAGRIDVIEW.CellContentClick += DATAGRIDVIEW_CellContentClick;
            DATAGRIDVIEW.CellClick += DATAGRIDVIEW_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 120);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(269, 117);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(284, 27);
            tbSearch.TabIndex = 9;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(873, 167);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 10;
            label2.Text = "Orderdetail Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(873, 226);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 11;
            label3.Text = "Order Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(873, 280);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 12;
            label4.Text = "Customer Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(873, 332);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 13;
            label5.Text = "Product Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(873, 395);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 14;
            label6.Text = "Product Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(873, 462);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 15;
            label7.Text = "Image:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(873, 523);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 16;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(873, 585);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 17;
            label9.Text = "Quantity Order:";
            // 
            // btOrderdetailID
            // 
            btOrderdetailID.Location = new Point(1018, 160);
            btOrderdetailID.Name = "btOrderdetailID";
            btOrderdetailID.Size = new Size(194, 27);
            btOrderdetailID.TabIndex = 18;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(1018, 223);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(194, 27);
            tbOrderID.TabIndex = 19;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(1018, 280);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(194, 27);
            tbCustomerID.TabIndex = 20;
            // 
            // tbProductID
            // 
            tbProductID.Location = new Point(1018, 332);
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(194, 27);
            tbProductID.TabIndex = 21;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(1018, 395);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(194, 27);
            tbProductName.TabIndex = 22;
            // 
            // tbImage
            // 
            tbImage.Location = new Point(1018, 455);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(194, 27);
            tbImage.TabIndex = 23;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1018, 516);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(194, 27);
            tbPrice.TabIndex = 24;
            // 
            // tbQuantityOrder
            // 
            tbQuantityOrder.Location = new Point(1018, 582);
            tbQuantityOrder.Name = "tbQuantityOrder";
            tbQuantityOrder.Size = new Size(194, 27);
            tbQuantityOrder.TabIndex = 25;
            // 
            // OrderDetailAdminPage
            // 
            AcceptButton = lbOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 700);
            Controls.Add(tbQuantityOrder);
            Controls.Add(tbPrice);
            Controls.Add(tbImage);
            Controls.Add(tbProductName);
            Controls.Add(tbProductID);
            Controls.Add(tbCustomerID);
            Controls.Add(tbOrderID);
            Controls.Add(btOrderdetailID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            Controls.Add(DATAGRIDVIEW);
            Controls.Add(btLogout);
            Controls.Add(lbProfile);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Controls.Add(lbAdmin);
            Name = "OrderDetailAdminPage";
            Text = "OrderDetailAdminPage";
            Load += OrderDetailAdminPage_Load;
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
        private LinkLabel lbProfile;
        private Button btLogout;
        private DataGridView DATAGRIDVIEW;
        private Label label1;
        private TextBox tbSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox btOrderdetailID;
        private TextBox tbOrderID;
        private TextBox tbCustomerID;
        private TextBox tbProductID;
        private TextBox tbProductName;
        private TextBox tbImage;
        private TextBox tbPrice;
        private TextBox tbQuantityOrder;
    }
}