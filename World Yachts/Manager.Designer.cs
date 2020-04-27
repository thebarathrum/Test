namespace World_Yachts
{
    partial class Manager
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
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.is13DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16is13DataSet = new World_Yachts._16is13DataSet();
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoryTableAdapter = new World_Yachts._16is13DataSetTableAdapters.accessoryTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BT_CreateContact = new System.Windows.Forms.Button();
            this.BT_Change_Status = new System.Windows.Forms.Button();
            this.BT_Report = new System.Windows.Forms.Button();
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
            this.L_Sign_In.Location = new System.Drawing.Point(748, 6);
            this.L_Sign_In.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.L_Sign_In.Name = "L_Sign_In";
            this.L_Sign_In.Size = new System.Drawing.Size(157, 20);
            this.L_Sign_In.TabIndex = 0;
            this.L_Sign_In.Text = "Logged as: Manager";
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
            this.timer1.Interval = 1000;
            // 
            // BT_CreateContact
            // 
            this.BT_CreateContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_CreateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CreateContact.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_CreateContact.ForeColor = System.Drawing.Color.White;
            this.BT_CreateContact.Location = new System.Drawing.Point(23, 164);
            this.BT_CreateContact.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_CreateContact.Name = "BT_CreateContact";
            this.BT_CreateContact.Size = new System.Drawing.Size(208, 47);
            this.BT_CreateContact.TabIndex = 9;
            this.BT_CreateContact.Text = "Создать новый договор";
            this.BT_CreateContact.UseVisualStyleBackColor = false;
            this.BT_CreateContact.Click += new System.EventHandler(this.BT_CreateContact_Click);
            // 
            // BT_Change_Status
            // 
            this.BT_Change_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_Change_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Change_Status.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_Change_Status.ForeColor = System.Drawing.Color.White;
            this.BT_Change_Status.Location = new System.Drawing.Point(23, 241);
            this.BT_Change_Status.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_Change_Status.Name = "BT_Change_Status";
            this.BT_Change_Status.Size = new System.Drawing.Size(208, 47);
            this.BT_Change_Status.TabIndex = 10;
            this.BT_Change_Status.Text = "Изменить статус заказа";
            this.BT_Change_Status.UseVisualStyleBackColor = false;
            // 
            // BT_Report
            // 
            this.BT_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BT_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Report.Font = new System.Drawing.Font("Arial", 12F);
            this.BT_Report.ForeColor = System.Drawing.Color.White;
            this.BT_Report.Location = new System.Drawing.Point(23, 318);
            this.BT_Report.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.BT_Report.Name = "BT_Report";
            this.BT_Report.Size = new System.Drawing.Size(208, 47);
            this.BT_Report.TabIndex = 11;
            this.BT_Report.Text = "Отчет";
            this.BT_Report.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.BT_Report);
            this.Controls.Add(this.BT_Change_Status);
            this.Controls.Add(this.BT_CreateContact);
            this.Controls.Add(this.L_Empty);
            this.Controls.Add(this.L_Sign_In);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Manager";
            this.Text = "World Yachts";
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
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.BindingSource is13DataSetBindingSource;
        private _16is13DataSet _16is13DataSet;
        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private _16is13DataSetTableAdapters.accessoryTableAdapter accessoryTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BT_CreateContact;
        private System.Windows.Forms.Button BT_Change_Status;
        private System.Windows.Forms.Button BT_Report;
    }
}