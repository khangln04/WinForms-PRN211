namespace ProjectPRN
{
    partial class Register
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
            lbRegister = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbSubmit = new Button();
            btBack = new Button();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbAdress = new TextBox();
            tbUsername = new TextBox();
            tbPassowrd = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegister.ForeColor = Color.MediumAquamarine;
            lbRegister.Location = new Point(391, 37);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(186, 57);
            lbRegister.TabIndex = 0;
            lbRegister.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 200);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 261);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 40);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 5;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 78);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // tbSubmit
            // 
            tbSubmit.Location = new Point(323, 531);
            tbSubmit.Name = "tbSubmit";
            tbSubmit.Size = new Size(111, 39);
            tbSubmit.TabIndex = 8;
            tbSubmit.Text = "Submit";
            tbSubmit.UseVisualStyleBackColor = true;
            tbSubmit.Click += tbSubmit_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(493, 531);
            btBack.Name = "btBack";
            btBack.Size = new Size(111, 39);
            btBack.TabIndex = 9;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(390, 134);
            tbName.Name = "tbName";
            tbName.Size = new Size(213, 27);
            tbName.TabIndex = 11;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(391, 193);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(213, 27);
            tbPhone.TabIndex = 12;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(390, 254);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(213, 27);
            tbAdress.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(138, 37);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(215, 27);
            tbUsername.TabIndex = 15;
            // 
            // tbPassowrd
            // 
            tbPassowrd.Location = new Point(139, 75);
            tbPassowrd.Name = "tbPassowrd";
            tbPassowrd.Size = new Size(214, 27);
            tbPassowrd.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPassowrd);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(252, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 159);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Account";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 625);
            Controls.Add(groupBox1);
            Controls.Add(tbAdress);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(btBack);
            Controls.Add(tbSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbRegister);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRegister;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button tbSubmit;
        private Button btBack;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbAdress;
        private TextBox tbUsername;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox tbPassowrd;
        private GroupBox groupBox1;
    }
}