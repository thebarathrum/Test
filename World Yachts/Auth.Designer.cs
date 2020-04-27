namespace World_Yachts
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_Sign_In = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BT_Sign_In = new System.Windows.Forms.Button();
            this.L_Empty = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.L_Sign_In.Text = "Авторизация";
            this.L_Sign_In.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Login
            // 
            this.TB_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Login.Font = new System.Drawing.Font("Arial", 14F);
            this.TB_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.TB_Login.Location = new System.Drawing.Point(362, 210);
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
            this.L_Login.Location = new System.Drawing.Point(278, 212);
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
            this.L_Password.Location = new System.Drawing.Point(262, 269);
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
            this.TB_Password.Location = new System.Drawing.Point(363, 267);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(238, 29);
            this.TB_Password.TabIndex = 3;
            // 
            // BT_Sign_In
            // 
            this.BT_Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sign_In.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_Sign_In.ForeColor = System.Drawing.Color.White;
            this.BT_Sign_In.Location = new System.Drawing.Point(409, 324);
            this.BT_Sign_In.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_Sign_In.Name = "BT_Sign_In";
            this.BT_Sign_In.Size = new System.Drawing.Size(126, 37);
            this.BT_Sign_In.TabIndex = 5;
            this.BT_Sign_In.Text = "Войти";
            this.BT_Sign_In.UseVisualStyleBackColor = false;
            this.BT_Sign_In.Click += new System.EventHandler(this.BT_Sign_In_Click);
            // 
            // L_Empty
            // 
            this.L_Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.L_Empty.Font = new System.Drawing.Font("Arial", 10F);
            this.L_Empty.ForeColor = System.Drawing.Color.White;
            this.L_Empty.Location = new System.Drawing.Point(-5, 519);
            this.L_Empty.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Empty.Name = "L_Empty";
            this.L_Empty.Size = new System.Drawing.Size(940, 35);
            this.L_Empty.TabIndex = 7;
            this.L_Empty.Text = " Copyright © World Yachts 2020  Все права защищены";
            this.L_Empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.L_Empty);
            this.Controls.Add(this.BT_Sign_In);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Sign_In);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Auth";
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
        private System.Windows.Forms.Button BT_Sign_In;
        private System.Windows.Forms.Label L_Empty;
        public System.Windows.Forms.Timer timer1;
    }
}

