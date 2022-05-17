namespace BARISTA
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.Supply_B = new System.Windows.Forms.Button();
            this.Manufacturer_B = new System.Windows.Forms.Button();
            this.Vendor_B = new System.Windows.Forms.Button();
            this.Catalogy_B = new System.Windows.Forms.Button();
            this.Warehouse_B = new System.Windows.Forms.Button();
            this.Employee_B = new System.Windows.Forms.Button();
            this.Position_B = new System.Windows.Forms.Button();
            this.Menu_B = new System.Windows.Forms.Button();
            this.Check_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Supply_B
            // 
            this.Supply_B.Location = new System.Drawing.Point(12, 86);
            this.Supply_B.Name = "Supply_B";
            this.Supply_B.Size = new System.Drawing.Size(100, 31);
            this.Supply_B.TabIndex = 0;
            this.Supply_B.Text = "Поставка";
            this.Supply_B.UseVisualStyleBackColor = true;
            this.Supply_B.Click += new System.EventHandler(this.Supply_B_Click);
            // 
            // Manufacturer_B
            // 
            this.Manufacturer_B.Location = new System.Drawing.Point(12, 12);
            this.Manufacturer_B.Name = "Manufacturer_B";
            this.Manufacturer_B.Size = new System.Drawing.Size(100, 31);
            this.Manufacturer_B.TabIndex = 1;
            this.Manufacturer_B.Text = "Производитель";
            this.Manufacturer_B.UseVisualStyleBackColor = true;
            this.Manufacturer_B.Click += new System.EventHandler(this.Manufacturer_B_Click);
            // 
            // Vendor_B
            // 
            this.Vendor_B.Location = new System.Drawing.Point(12, 49);
            this.Vendor_B.Name = "Vendor_B";
            this.Vendor_B.Size = new System.Drawing.Size(100, 31);
            this.Vendor_B.TabIndex = 2;
            this.Vendor_B.Text = "Поставщик";
            this.Vendor_B.UseVisualStyleBackColor = true;
            this.Vendor_B.Click += new System.EventHandler(this.Vendor_B_Click);
            // 
            // Catalogy_B
            // 
            this.Catalogy_B.Location = new System.Drawing.Point(118, 49);
            this.Catalogy_B.Name = "Catalogy_B";
            this.Catalogy_B.Size = new System.Drawing.Size(100, 31);
            this.Catalogy_B.TabIndex = 3;
            this.Catalogy_B.Text = "Каталог";
            this.Catalogy_B.UseVisualStyleBackColor = true;
            this.Catalogy_B.Click += new System.EventHandler(this.Catalogy_B_Click);
            // 
            // Warehouse_B
            // 
            this.Warehouse_B.Location = new System.Drawing.Point(118, 12);
            this.Warehouse_B.Name = "Warehouse_B";
            this.Warehouse_B.Size = new System.Drawing.Size(100, 31);
            this.Warehouse_B.TabIndex = 4;
            this.Warehouse_B.Text = "Склад";
            this.Warehouse_B.UseVisualStyleBackColor = true;
            this.Warehouse_B.Click += new System.EventHandler(this.Warehouse_B_Click);
            // 
            // Employee_B
            // 
            this.Employee_B.Location = new System.Drawing.Point(12, 160);
            this.Employee_B.Name = "Employee_B";
            this.Employee_B.Size = new System.Drawing.Size(100, 31);
            this.Employee_B.TabIndex = 5;
            this.Employee_B.Text = "Сотрудник";
            this.Employee_B.UseVisualStyleBackColor = true;
            this.Employee_B.Click += new System.EventHandler(this.Employee_B_Click);
            // 
            // Position_B
            // 
            this.Position_B.Location = new System.Drawing.Point(118, 123);
            this.Position_B.Name = "Position_B";
            this.Position_B.Size = new System.Drawing.Size(100, 31);
            this.Position_B.TabIndex = 6;
            this.Position_B.Text = "Должность";
            this.Position_B.UseVisualStyleBackColor = true;
            this.Position_B.Click += new System.EventHandler(this.Position_B_Click);
            // 
            // Menu_B
            // 
            this.Menu_B.Location = new System.Drawing.Point(118, 86);
            this.Menu_B.Name = "Menu_B";
            this.Menu_B.Size = new System.Drawing.Size(100, 31);
            this.Menu_B.TabIndex = 7;
            this.Menu_B.Text = "Меню";
            this.Menu_B.UseVisualStyleBackColor = true;
            this.Menu_B.Click += new System.EventHandler(this.Menu_B_Click);
            // 
            // Check_B
            // 
            this.Check_B.Location = new System.Drawing.Point(12, 123);
            this.Check_B.Name = "Check_B";
            this.Check_B.Size = new System.Drawing.Size(100, 31);
            this.Check_B.TabIndex = 8;
            this.Check_B.Text = "Чек";
            this.Check_B.UseVisualStyleBackColor = true;
            this.Check_B.Click += new System.EventHandler(this.Check_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(118, 160);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(100, 31);
            this.Exit_B.TabIndex = 9;
            this.Exit_B.Text = "Выход";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 201);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Check_B);
            this.Controls.Add(this.Menu_B);
            this.Controls.Add(this.Position_B);
            this.Controls.Add(this.Employee_B);
            this.Controls.Add(this.Warehouse_B);
            this.Controls.Add(this.Catalogy_B);
            this.Controls.Add(this.Vendor_B);
            this.Controls.Add(this.Manufacturer_B);
            this.Controls.Add(this.Supply_B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бариста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Supply_B;
        private Button Manufacturer_B;
        private Button Vendor_B;
        private Button Catalogy_B;
        private Button Warehouse_B;
        private Button Employee_B;
        private Button Position_B;
        private Button Menu_B;
        private Button Check_B;
        private Button Exit_B;
    }
}