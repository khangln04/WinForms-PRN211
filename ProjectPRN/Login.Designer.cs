namespace ProjectPRN
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btSubmit = new Button();
            btBack = new Button();
            label3 = new Label();
            cbRole = new ComboBox();
            label4 = new Label();
            btRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 163);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 226);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(246, 163);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(301, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(246, 226);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(301, 27);
            tbPassword.TabIndex = 3;
            // 
            // btSubmit
            // 
            btSubmit.Location = new Point(326, 284);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(100, 41);
            btSubmit.TabIndex = 4;
            btSubmit.Text = "Submit";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(453, 284);
            btBack.Name = "btBack";
            btBack.Size = new Size(103, 41);
            btBack.TabIndex = 5;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(306, 30);
            label3.Name = "label3";
            label3.Size = new Size(153, 57);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(326, 113);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(111, 28);
            cbRole.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Role:";
            // 
            // btRegister
            // 
            btRegister.Location = new Point(213, 284);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(94, 41);
            btRegister.TabIndex = 9;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRegister);
            Controls.Add(label4);
            Controls.Add(cbRole);
            Controls.Add(label3);
            Controls.Add(btBack);
            Controls.Add(btSubmit);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btSubmit;
        private Button btBack;
        private Label label3;
        private ComboBox cbRole;
        private Label label4;
        private Button btRegister;
    }
}