namespace ProjectPRN
{
    partial class CheckoutCustomerPage
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btCancelOrder = new Button();
            btSubmitOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            lbHome = new LinkLabel();
            lbOrder = new LinkLabel();
            lbProfile = new LinkLabel();
            btLogout = new Button();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbPrice = new TextBox();
            tbStatus = new TextBox();
            tbAddress = new TextBox();
            tbCustomerId = new TextBox();
            tbOrderId = new TextBox();
            btSave = new Button();
            tbDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 407);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(621, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(578, 407);
            dataGridView2.TabIndex = 1;
            // 
            // btCancelOrder
            // 
            btCancelOrder.Location = new Point(300, 588);
            btCancelOrder.Name = "btCancelOrder";
            btCancelOrder.Size = new Size(170, 42);
            btCancelOrder.TabIndex = 2;
            btCancelOrder.Text = "Cancel Order";
            btCancelOrder.UseVisualStyleBackColor = true;
            btCancelOrder.Click += btCancelOrder_Click;
            // 
            // btSubmitOrder
            // 
            btSubmitOrder.Location = new Point(749, 588);
            btSubmitOrder.Name = "btSubmitOrder";
            btSubmitOrder.Size = new Size(168, 42);
            btSubmitOrder.TabIndex = 3;
            btSubmitOrder.Text = "Submit Order";
            btSubmitOrder.UseVisualStyleBackColor = true;
            btSubmitOrder.Click += btSubmitOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 123);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(888, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Order Detail";
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Location = new Point(282, 26);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(50, 20);
            lbHome.TabIndex = 6;
            lbHome.TabStop = true;
            lbHome.Text = "Home";
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(475, 26);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(47, 20);
            lbOrder.TabIndex = 7;
            lbOrder.TabStop = true;
            lbOrder.Text = "Order";
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Location = new Point(672, 26);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 8;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1449, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(118, 44);
            btLogout.TabIndex = 9;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(121, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(248, 27);
            tbName.TabIndex = 10;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(121, 75);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(248, 27);
            tbPhone.TabIndex = 11;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1383, 412);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(248, 27);
            tbPrice.TabIndex = 12;
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(1383, 502);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(248, 27);
            tbStatus.TabIndex = 14;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(121, 123);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(248, 27);
            tbAddress.TabIndex = 15;
            // 
            // tbCustomerId
            // 
            tbCustomerId.Location = new Point(1383, 180);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(248, 27);
            tbCustomerId.TabIndex = 16;
            // 
            // tbOrderId
            // 
            tbOrderId.Location = new Point(1383, 134);
            tbOrderId.Name = "tbOrderId";
            tbOrderId.Size = new Size(248, 27);
            tbOrderId.TabIndex = 17;
            // 
            // btSave
            // 
            btSave.Location = new Point(1449, 568);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 46);
            btSave.TabIndex = 18;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(1383, 456);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(248, 27);
            tbDate.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1281, 141);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 20;
            label3.Text = "Order ID: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1277, 187);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 21;
            label4.Text = "Customer ID: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 31);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 22;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 75);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 23;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 126);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 24;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1310, 419);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 25;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1310, 461);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 26;
            label9.Text = "Date:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1310, 509);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 27;
            label10.Text = "Status:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(1262, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 170);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Receiver";
            // 
            // CheckoutCustomerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1671, 687);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbDate);
            Controls.Add(btSave);
            Controls.Add(tbOrderId);
            Controls.Add(tbCustomerId);
            Controls.Add(tbStatus);
            Controls.Add(tbPrice);
            Controls.Add(btLogout);
            Controls.Add(lbProfile);
            Controls.Add(lbOrder);
            Controls.Add(lbHome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSubmitOrder);
            Controls.Add(btCancelOrder);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "CheckoutCustomerPage";
            Text = "CheckoutCustomerPage";
            Load += CheckoutCustomerPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btCancelOrder;
        private Button btSubmitOrder;
        private Label label1;
        private Label label2;
        private LinkLabel lbHome;
        private LinkLabel lbOrder;
        private LinkLabel lbProfile;
        private Button btLogout;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbPrice;
        private TextBox tbStatus;
        private TextBox tbAddress;
        private TextBox tbCustomerId;
        private TextBox tbOrderId;
        private Button btSave;
        private DateTimePicker tbDate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
    }
}