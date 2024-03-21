namespace ProjectPRN
{
    partial class ClientHomePage
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
            DATAGRIDVIEW = new DataGridView();
            lbProfle = new LinkLabel();
            lbOrder = new LinkLabel();
            lbHome = new LinkLabel();
            tbSreach = new TextBox();
            tbLogout = new Button();
            tbSearchbyPriceFrom = new TextBox();
            tbSearchbyPriceTo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbProductID = new TextBox();
            tbName = new TextBox();
            tbDecription = new TextBox();
            tbImage = new TextBox();
            tbPrice = new TextBox();
            btOrder = new Button();
            tbDiscount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbCategory = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            tbCountProductForCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(47, 189);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(890, 512);
            DATAGRIDVIEW.TabIndex = 0;
            DATAGRIDVIEW.CellClick += DATAGRIDVIEW_CellClick;
            DATAGRIDVIEW.CellContentClick += DATAGRIDVIEW_CellContentClick;
            // 
            // lbProfle
            // 
            lbProfle.AutoSize = true;
            lbProfle.Location = new Point(562, 9);
            lbProfle.Name = "lbProfle";
            lbProfle.Size = new Size(52, 20);
            lbProfle.TabIndex = 1;
            lbProfle.TabStop = true;
            lbProfle.Text = "Profile";
            lbProfle.LinkClicked += lbProfle_LinkClicked;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(471, 9);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 2;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            lbOrder.LinkClicked += lbOrder_LinkClicked;
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Location = new Point(385, 9);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(50, 20);
            lbHome.TabIndex = 3;
            lbHome.TabStop = true;
            lbHome.Text = "Home";
            lbHome.LinkClicked += lbHome_LinkClicked;
            // 
            // tbSreach
            // 
            tbSreach.Location = new Point(106, 103);
            tbSreach.Name = "tbSreach";
            tbSreach.Size = new Size(289, 27);
            tbSreach.TabIndex = 4;
            tbSreach.TextChanged += tbSreach_TextChanged;
            // 
            // tbLogout
            // 
            tbLogout.Location = new Point(1173, 9);
            tbLogout.Name = "tbLogout";
            tbLogout.Size = new Size(94, 47);
            tbLogout.TabIndex = 5;
            tbLogout.Text = "Logout";
            tbLogout.UseVisualStyleBackColor = true;
            tbLogout.Click += tbLogout_Click;
            // 
            // tbSearchbyPriceFrom
            // 
            tbSearchbyPriceFrom.Location = new Point(431, 103);
            tbSearchbyPriceFrom.Name = "tbSearchbyPriceFrom";
            tbSearchbyPriceFrom.Size = new Size(118, 27);
            tbSearchbyPriceFrom.TabIndex = 6;
            tbSearchbyPriceFrom.TextChanged += tbSearchbyPriceFrom_TextChanged;
            // 
            // tbSearchbyPriceTo
            // 
            tbSearchbyPriceTo.Location = new Point(562, 103);
            tbSearchbyPriceTo.Name = "tbSearchbyPriceTo";
            tbSearchbyPriceTo.Size = new Size(118, 27);
            tbSearchbyPriceTo.TabIndex = 7;
            tbSearchbyPriceTo.TextChanged += tbSearchbyPriceTo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 106);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Sreach";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 80);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "Price from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 80);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 10;
            label3.Text = "Price to:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(968, 169);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 11;
            label4.Text = "Product Id:";
            // 
            // tbProductID
            // 
            tbProductID.Location = new Point(1081, 164);
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(204, 27);
            tbProductID.TabIndex = 12;
            // 
            // tbName
            // 
            tbName.Location = new Point(1081, 224);
            tbName.Name = "tbName";
            tbName.Size = new Size(204, 27);
            tbName.TabIndex = 13;
            // 
            // tbDecription
            // 
            tbDecription.Location = new Point(1081, 286);
            tbDecription.Name = "tbDecription";
            tbDecription.Size = new Size(204, 27);
            tbDecription.TabIndex = 14;
            // 
            // tbImage
            // 
            tbImage.Location = new Point(1081, 352);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(204, 27);
            tbImage.TabIndex = 15;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1081, 414);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(204, 27);
            tbPrice.TabIndex = 16;
            // 
            // btOrder
            // 
            btOrder.Location = new Point(1121, 575);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(119, 45);
            btOrder.TabIndex = 17;
            btOrder.Text = "Order";
            btOrder.UseVisualStyleBackColor = true;
            btOrder.Click += btOrder_Click;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(1081, 474);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(204, 27);
            tbDiscount.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(968, 231);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 19;
            label5.Text = "Product Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(968, 286);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 20;
            label6.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(973, 352);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 21;
            label7.Text = "Image:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(973, 417);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 22;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(977, 481);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 23;
            label9.Text = "Discount:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(708, 102);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 24;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(708, 79);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 25;
            label10.Text = "Category:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(106, 154);
            label11.Name = "label11";
            label11.Size = new Size(195, 20);
            label11.TabIndex = 26;
            label11.Text = "Count Product For Category:";
            // 
            // tbCountProductForCategory
            // 
            tbCountProductForCategory.Location = new Point(307, 151);
            tbCountProductForCategory.Name = "tbCountProductForCategory";
            tbCountProductForCategory.ReadOnly = true;
            tbCountProductForCategory.Size = new Size(88, 27);
            tbCountProductForCategory.TabIndex = 27;
            // 
            // ClientHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 719);
            Controls.Add(tbCountProductForCategory);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cbCategory);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbDiscount);
            Controls.Add(btOrder);
            Controls.Add(tbPrice);
            Controls.Add(tbImage);
            Controls.Add(tbDecription);
            Controls.Add(tbName);
            Controls.Add(tbProductID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSearchbyPriceTo);
            Controls.Add(tbSearchbyPriceFrom);
            Controls.Add(tbLogout);
            Controls.Add(tbSreach);
            Controls.Add(lbHome);
            Controls.Add(lbOrder);
            Controls.Add(lbProfle);
            Controls.Add(DATAGRIDVIEW);
            Name = "ClientHomePage";
            Text = "ClientHomePage";
            Load += ClientHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DATAGRIDVIEW;
        private LinkLabel lbProfle;
        private LinkLabel lbOrder;
        private LinkLabel lbHome;
        private TextBox tbSreach;
        private Button tbLogout;
        private TextBox tbSearchbyPriceFrom;
        private TextBox tbSearchbyPriceTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbProductID;
        private TextBox tbName;
        private TextBox tbDecription;
        private TextBox tbImage;
        private TextBox tbPrice;
        private Button btOrder;
        private TextBox tbDiscount;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbCategory;
        private Label label10;
        private Label label11;
        private TextBox tbCountProductForCategory;
    }
}