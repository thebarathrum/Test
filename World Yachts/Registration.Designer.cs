namespace World_Yachts
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            this.L_Sign_In = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BT_Sign_Up = new System.Windows.Forms.Button();
            this.L_Empty = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TB_First_Name = new System.Windows.Forms.TextBox();
            this.TB_Middle_Name = new System.Windows.Forms.TextBox();
            this.TB_Last_Name = new System.Windows.Forms.TextBox();
            this.L_First_Name = new System.Windows.Forms.Label();
            this.L_Frist_Name = new System.Windows.Forms.Label();
            this.L_Last_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Sign_In
            // 
            this.L_Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.L_Sign_In.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.L_Sign_In.ForeColor = System.Drawing.Color.White;
            this.L_Sign_In.Location = new System.Drawing.Point(-2, 45);
            this.L_Sign_In.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Sign_In.Name = "L_Sign_In";
            this.L_Sign_In.Size = new System.Drawing.Size(937, 87);
            this.L_Sign_In.TabIndex = 0;
            this.L_Sign_In.Text = "Регистрация";
            this.L_Sign_In.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Login
            // 
            this.TB_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Login.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_Login.Location = new System.Drawing.Point(347, 160);
            this.TB_Login.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(239, 29);
            this.TB_Login.TabIndex = 1;
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Arial", 14F);
            this.L_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Login.Location = new System.Drawing.Point(247, 162);
            this.L_Login.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(60, 22);
            this.L_Login.TabIndex = 2;
            this.L_Login.Text = "Логин";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Arial", 14F);
            this.L_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Password.Location = new System.Drawing.Point(247, 221);
            this.L_Password.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(76, 22);
            this.L_Password.TabIndex = 4;
            this.L_Password.Text = "Пароль";
            // 
            // TB_Password
            // 
            this.TB_Password.BackColor = System.Drawing.Color.White;
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Password.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_Password.Location = new System.Drawing.Point(348, 219);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(238, 29);
            this.TB_Password.TabIndex = 2;
            // 
            // BT_Sign_Up
            // 
            this.BT_Sign_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_Sign_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sign_Up.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_Sign_Up.ForeColor = System.Drawing.Color.White;
            this.BT_Sign_Up.Location = new System.Drawing.Point(382, 452);
            this.BT_Sign_Up.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_Sign_Up.Name = "BT_Sign_Up";
            this.BT_Sign_Up.Size = new System.Drawing.Size(156, 37);
            this.BT_Sign_Up.TabIndex = 6;
            this.BT_Sign_Up.Text = "Зарегистрировать";
            this.BT_Sign_Up.UseVisualStyleBackColor = false;
            this.BT_Sign_Up.Click += new System.EventHandler(this.BT_Sign_Up_Click);
            // 
            // L_Empty
            // 
            this.L_Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Empty.Font = new System.Drawing.Font("Arial", 10F);
            this.L_Empty.ForeColor = System.Drawing.Color.White;
            this.L_Empty.Location = new System.Drawing.Point(-7, 519);
            this.L_Empty.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Empty.Name = "L_Empty";
            this.L_Empty.Size = new System.Drawing.Size(942, 35);
            this.L_Empty.TabIndex = 7;
            this.L_Empty.Text = " Copyright © World Yachts 2020  Все права защищены";
            this.L_Empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_First_Name
            // 
            this.TB_First_Name.BackColor = System.Drawing.Color.White;
            this.TB_First_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_First_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_First_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_First_Name.Location = new System.Drawing.Point(347, 278);
            this.TB_First_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_First_Name.Name = "TB_First_Name";
            this.TB_First_Name.Size = new System.Drawing.Size(238, 29);
            this.TB_First_Name.TabIndex = 3;
            // 
            // TB_Middle_Name
            // 
            this.TB_Middle_Name.BackColor = System.Drawing.Color.White;
            this.TB_Middle_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Middle_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_Middle_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_Middle_Name.Location = new System.Drawing.Point(347, 337);
            this.TB_Middle_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_Middle_Name.Name = "TB_Middle_Name";
            this.TB_Middle_Name.Size = new System.Drawing.Size(238, 29);
            this.TB_Middle_Name.TabIndex = 4;
            // 
            // TB_Last_Name
            // 
            this.TB_Last_Name.BackColor = System.Drawing.Color.White;
            this.TB_Last_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Last_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_Last_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_Last_Name.Location = new System.Drawing.Point(347, 393);
            this.TB_Last_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_Last_Name.Name = "TB_Last_Name";
            this.TB_Last_Name.Size = new System.Drawing.Size(238, 29);
            this.TB_Last_Name.TabIndex = 5;
            // 
            // L_First_Name
            // 
            this.L_First_Name.AutoSize = true;
            this.L_First_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.L_First_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_First_Name.Location = new System.Drawing.Point(246, 280);
            this.L_First_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_First_Name.Name = "L_First_Name";
            this.L_First_Name.Size = new System.Drawing.Size(47, 22);
            this.L_First_Name.TabIndex = 11;
            this.L_First_Name.Text = "Имя";
            // 
            // L_Frist_Name
            // 
            this.L_Frist_Name.AutoSize = true;
            this.L_Frist_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.L_Frist_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Frist_Name.Location = new System.Drawing.Point(246, 339);
            this.L_Frist_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Frist_Name.Name = "L_Frist_Name";
            this.L_Frist_Name.Size = new System.Drawing.Size(93, 22);
            this.L_Frist_Name.TabIndex = 12;
            this.L_Frist_Name.Text = "Отчество";
            // 
            // L_Last_Name
            // 
            this.L_Last_Name.AutoSize = true;
            this.L_Last_Name.Font = new System.Drawing.Font("Arial", 14F);
            this.L_Last_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Last_Name.Location = new System.Drawing.Point(247, 395);
            this.L_Last_Name.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Last_Name.Name = "L_Last_Name";
            this.L_Last_Name.Size = new System.Drawing.Size(87, 22);
            this.L_Last_Name.TabIndex = 13;
            this.L_Last_Name.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(784, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Logged as: Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Last_Name);
            this.Controls.Add(this.L_Frist_Name);
            this.Controls.Add(this.L_First_Name);
            this.Controls.Add(this.TB_Last_Name);
            this.Controls.Add(this.TB_Middle_Name);
            this.Controls.Add(this.TB_First_Name);
            this.Controls.Add(this.L_Empty);
            this.Controls.Add(this.BT_Sign_Up);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Sign_In);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registration";
            this.Text = "World Yachts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Sign_In;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BT_Sign_Up;
        private System.Windows.Forms.Label L_Empty;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TB_First_Name;
        private System.Windows.Forms.TextBox TB_Middle_Name;
        private System.Windows.Forms.TextBox TB_Last_Name;
        private System.Windows.Forms.Label L_First_Name;
        private System.Windows.Forms.Label L_Frist_Name;
        private System.Windows.Forms.Label L_Last_Name;
        private System.Windows.Forms.Label label1;
    }
}