namespace World_Yachts
{
    partial class Administrator
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
            this.L_Empty = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сессияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лодкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аксессуарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.is13DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16is13DataSet = new World_Yachts._16is13DataSet();
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoryTableAdapter = new World_Yachts._16is13DataSetTableAdapters.accessoryTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BT_Sign_Up = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.is13DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16is13DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Sign_In
            // 
            this.L_Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.L_Sign_In.Font = new System.Drawing.Font("Arial", 10F);
            this.L_Sign_In.ForeColor = System.Drawing.Color.White;
            this.L_Sign_In.Location = new System.Drawing.Point(770, 6);
            this.L_Sign_In.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Sign_In.Name = "L_Sign_In";
            this.L_Sign_In.Size = new System.Drawing.Size(135, 20);
            this.L_Sign_In.TabIndex = 0;
            this.L_Sign_In.Text = "Logged as: Admin";
            this.L_Sign_In.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сессияToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 26);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сессияToolStripMenuItem
            // 
            this.сессияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сессияToolStripMenuItem.Name = "сессияToolStripMenuItem";
            this.сессияToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.сессияToolStripMenuItem.Text = "Сессия";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.Checked = true;
            this.таблицыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менеджерыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.лодкиToolStripMenuItem,
            this.аксессуарыToolStripMenuItem});
            this.таблицыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // менеджерыToolStripMenuItem
            // 
            this.менеджерыToolStripMenuItem.Name = "менеджерыToolStripMenuItem";
            this.менеджерыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.менеджерыToolStripMenuItem.Text = "Менеджеры";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // лодкиToolStripMenuItem
            // 
            this.лодкиToolStripMenuItem.Name = "лодкиToolStripMenuItem";
            this.лодкиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.лодкиToolStripMenuItem.Text = "Лодки";
            // 
            // аксессуарыToolStripMenuItem
            // 
            this.аксессуарыToolStripMenuItem.Name = "аксессуарыToolStripMenuItem";
            this.аксессуарыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.аксессуарыToolStripMenuItem.Text = "Аксессуары";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // is13DataSetBindingSource
            // 
            this.is13DataSetBindingSource.DataSource = this._16is13DataSet;
            this.is13DataSetBindingSource.Position = 0;
            // 
            // _16is13DataSet
            // 
            this._16is13DataSet.DataSetName = "_16is13DataSet";
            this._16is13DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoryBindingSource
            // 
            this.accessoryBindingSource.DataMember = "accessory";
            this.accessoryBindingSource.DataSource = this.is13DataSetBindingSource;
            // 
            // accessoryTableAdapter
            // 
            this.accessoryTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BT_Sign_Up
            // 
            this.BT_Sign_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_Sign_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sign_Up.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_Sign_Up.ForeColor = System.Drawing.Color.White;
            this.BT_Sign_Up.Location = new System.Drawing.Point(23, 41);
            this.BT_Sign_Up.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_Sign_Up.Name = "BT_Sign_Up";
            this.BT_Sign_Up.Size = new System.Drawing.Size(183, 59);
            this.BT_Sign_Up.TabIndex = 9;
            this.BT_Sign_Up.Text = "Зарегистрировать нового пользователя";
            this.BT_Sign_Up.UseVisualStyleBackColor = false;
            this.BT_Sign_Up.Click += new System.EventHandler(this.BT_Sign_Up_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.BT_Sign_Up);
            this.Controls.Add(this.L_Empty);
            this.Controls.Add(this.L_Sign_In);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrator";
            this.Text = "World Yachts";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.is13DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16is13DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Sign_In;
        private System.Windows.Forms.Label L_Empty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сессияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лодкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аксессуарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.BindingSource is13DataSetBindingSource;
        private _16is13DataSet _16is13DataSet;
        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private _16is13DataSetTableAdapters.accessoryTableAdapter accessoryTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BT_Sign_Up;
    }
}