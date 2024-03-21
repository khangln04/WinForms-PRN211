using System.Globalization;
using System.Windows.Forms;

namespace ProjectPRN
{
    partial class OrderCustomerPage
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
            lbWait = new Label();
            lbProcess = new Label();
            lbDone = new Label();
            btLogout = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbOrderID = new TextBox();
            tbCustomerID = new TextBox();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            tbPrice = new TextBox();
            tbStatus = new TextBox();
            tbDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Location = new Point(217, 43);
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
            lbOrder.Location = new Point(343, 43);
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
            lbProfile.Location = new Point(446, 43);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(52, 20);
            lbProfile.TabIndex = 2;
            lbProfile.TabStop = true;
            lbProfile.Text = "Profile";
            lbProfile.LinkClicked += lbProfile_LinkClicked;
            // 
            // lbWait
            // 
            lbWait.AutoSize = true;
            lbWait.Location = new Point(217, 143);
            lbWait.Name = "lbWait";
            lbWait.Size = new Size(39, 20);
            lbWait.TabIndex = 3;
            lbWait.Text = "Wait";
            lbWait.Click += lbWait_Click;
            // 
            // lbProcess
            // 
            lbProcess.AutoSize = true;
            lbProcess.Location = new Point(343, 143);
            lbProcess.Name = "lbProcess";
            lbProcess.Size = new Size(58, 20);
            lbProcess.TabIndex = 4;
            lbProcess.Text = "Process";
            lbProcess.Click += lbProcess_Click;
            // 
            // lbDone
            // 
            lbDone.AutoSize = true;
            lbDone.Location = new Point(471, 143);
            lbDone.Name = "lbDone";
            lbDone.Size = new Size(45, 20);
            lbDone.TabIndex = 5;
            lbDone.Text = "Done";
            lbDone.Click += lbDone_Click;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(1203, 12);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(94, 46);
            btLogout.TabIndex = 8;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(822, 470);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(916, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Order Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(916, 257);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 11;
            label6.Text = "Customer Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(916, 309);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 12;
            label7.Text = "Name Receiver:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(916, 359);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 13;
            label8.Text = "Phone Receiver:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(916, 412);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 14;
            label9.Text = "Address Receiver:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(916, 469);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 15;
            label10.Text = "Total Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(916, 516);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 16;
            label11.Text = "Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(916, 571);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 17;
            label12.Text = "Status:";
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(1047, 211);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(250, 27);
            tbOrderID.TabIndex = 18;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(1047, 254);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(250, 27);
            tbCustomerID.TabIndex = 19;
            // 
            // tbName
            // 
            tbName.Location = new Point(1047, 306);
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 27);
            tbName.TabIndex = 20;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(1047, 356);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(250, 27);
            tbPhone.TabIndex = 21;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(1047, 412);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(250, 27);
            tbAddress.TabIndex = 22;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1047, 466);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(250, 27);
            tbPrice.TabIndex = 23;
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(1047, 571);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(250, 27);
            tbStatus.TabIndex = 24;
            // 
            // tbDate
            // 
            tbDate.CustomFormat = "'Ngày' d 'Tháng' M 'Năm' yyyy";
            tbDate.Format = DateTimePickerFormat.Custom;
            tbDate.Location = new Point(1047, 516);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(250, 27);
            tbDate.TabIndex = 25;
            // 
            // OrderCustomerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 711);
            Controls.Add(tbDate);
            Controls.Add(tbStatus);
            Controls.Add(tbPrice);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(tbCustomerID);
            Controls.Add(tbOrderID);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btLogout);
            Controls.Add(lbDone);
            Controls.Add(lbProcess);
            Controls.Add(lbWait);
            Controls.Add(lbProfile);
            Controls.Add(lbOrder);
            Controls.Add(lbHome);
            Name = "OrderCustomerPage";
            Text = "OrderCustomerPage";
            Load += OrderCustomerPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbHome;
        private LinkLabel lbOrder;
        private LinkLabel lbProfile;
        private Label lbWait;
        private Label lbProcess;
        private Label lbDone;
        private Button btLogout;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbOrderID;
        private TextBox tbCustomerID;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private TextBox tbPrice;
        private TextBox tbStatus;
        private DateTimePicker tbDate;
    }
}