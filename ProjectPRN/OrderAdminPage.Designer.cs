using System.Globalization;
using System.Windows.Forms;

namespace ProjectPRN
{
    partial class OrderAdminPage
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
            lbWait = new Label();
            lbProcess = new Label();
            lbDone = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            butUpdate = new Button();
            tbDate = new DateTimePicker();
            tbStatus = new ComboBox();
            tbOrderID = new TextBox();
            tbCustomerId = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbAdress = new TextBox();
            tbPrice = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(118, 49);
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
            lbCustomer.Location = new Point(212, 49);
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
            lbProduct.Location = new Point(323, 49);
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
            lbOrder.Location = new Point(429, 49);
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
            lbOrderDetail.Location = new Point(519, 49);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(85, 20);
            lbOrderDetail.TabIndex = 4;
            lbOrderDetail.TabStop = true;
            lbOrderDetail.Text = "Orderdetail";
            lbOrderDetail.LinkClicked += lbOrderDetail_LinkClicked;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(638, 49);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 5;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1112, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(101, 48);
            btLogout.TabIndex = 6;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // DATAGRIDVIEW
            // 
            DATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDVIEW.Location = new Point(28, 194);
            DATAGRIDVIEW.Name = "DATAGRIDVIEW";
            DATAGRIDVIEW.RowHeadersWidth = 51;
            DATAGRIDVIEW.RowTemplate.Height = 29;
            DATAGRIDVIEW.Size = new Size(793, 506);
            DATAGRIDVIEW.TabIndex = 7;
            DATAGRIDVIEW.CellClick += DATAGRIDVIEW_CellClick;
            DATAGRIDVIEW.CellContentClick += DATAGRIDVIEW_CellContentClick;
            // 
            // lbWait
            // 
            lbWait.AutoSize = true;
            lbWait.Location = new Point(272, 129);
            lbWait.Name = "lbWait";
            lbWait.Size = new Size(39, 20);
            lbWait.TabIndex = 10;
            lbWait.Text = "Wait";
            lbWait.TextAlign = ContentAlignment.MiddleCenter;
            lbWait.Click += lbWait_Click;
            // 
            // lbProcess
            // 
            lbProcess.AutoSize = true;
            lbProcess.Location = new Point(373, 129);
            lbProcess.Name = "lbProcess";
            lbProcess.Size = new Size(58, 20);
            lbProcess.TabIndex = 11;
            lbProcess.Text = "Process";
            lbProcess.Click += lbProcess_Click;
            // 
            // lbDone
            // 
            lbDone.AutoSize = true;
            lbDone.Location = new Point(491, 129);
            lbDone.Name = "lbDone";
            lbDone.Size = new Size(45, 20);
            lbDone.TabIndex = 12;
            lbDone.Text = "Done";
            lbDone.Click += lbDone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(845, 194);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "Order ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(845, 250);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 15;
            label3.Text = "Customer Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(845, 309);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 16;
            label4.Text = "Name Receiver:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(845, 371);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 17;
            label5.Text = "Phone Receiver:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(845, 427);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 18;
            label6.Text = "Address Receiver:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(845, 489);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 19;
            label7.Text = "Total Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(845, 537);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 20;
            label8.Text = "Date:";
            // 
            // butUpdate
            // 
            butUpdate.Location = new Point(1030, 632);
            butUpdate.Name = "butUpdate";
            butUpdate.Size = new Size(121, 43);
            butUpdate.TabIndex = 21;
            butUpdate.Text = "Update Status";
            butUpdate.UseVisualStyleBackColor = true;
            butUpdate.Click += butUpdate_Click;
            // 
            // tbDate
            // 
            tbDate.CustomFormat = "'Ngày' d 'Tháng' M 'Năm' yyyy";
            tbDate.Format = DateTimePickerFormat.Custom;
            tbDate.Location = new Point(976, 532);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(250, 27);
            tbDate.TabIndex = 22;
            // 
            // tbStatus
            // 
            tbStatus.FormattingEnabled = true;
            tbStatus.Location = new Point(976, 582);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(250, 28);
            tbStatus.TabIndex = 23;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(976, 191);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(250, 27);
            tbOrderID.TabIndex = 24;
            // 
            // tbCustomerId
            // 
            tbCustomerId.Location = new Point(976, 243);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(250, 27);
            tbCustomerId.TabIndex = 25;
            // 
            // tbName
            // 
            tbName.Location = new Point(976, 306);
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 27);
            tbName.TabIndex = 26;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(976, 368);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(250, 27);
            tbPhone.TabIndex = 27;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(976, 427);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(250, 27);
            tbAdress.TabIndex = 28;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(976, 482);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(250, 27);
            tbPrice.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(845, 585);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 30;
            label9.Text = "Status:";
            // 
            // OrderAdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 712);
            Controls.Add(label9);
            Controls.Add(tbPrice);
            Controls.Add(tbAdress);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(tbCustomerId);
            Controls.Add(tbOrderID);
            Controls.Add(tbStatus);
            Controls.Add(tbDate);
            Controls.Add(butUpdate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbDone);
            Controls.Add(lbProcess);
            Controls.Add(lbWait);
            Controls.Add(DATAGRIDVIEW);
            Controls.Add(btLogout);
            Controls.Add(lbProfile);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(lbProduct);
            Controls.Add(lbCustomer);
            Controls.Add(lbAdmin);
            Name = "OrderAdminPage";
            Text = "OrderAdminPage";
            Load += OrderAdminPage_Load;
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
        private Label lbWait;
        private Label lbProcess;
        private Label lbDone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button butUpdate;
        private DateTimePicker tbDate;
        private ComboBox tbStatus;
        private TextBox tbOrderID;
        private TextBox tbCustomerId;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbAdress;
        private TextBox tbPrice;
        private Label label9;
    }
}