﻿namespace BARISTA.Views
{
    partial class ProductivityView
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
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Back_B = new System.Windows.Forms.Button();
            this.Productivity_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Productivity_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(296, 11);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(100, 31);
            this.Add_B.TabIndex = 0;
            this.Add_B.Text = "Добавление";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(296, 48);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(100, 31);
            this.Update_B.TabIndex = 1;
            this.Update_B.Text = "Изменение";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(296, 85);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(100, 31);
            this.Del_B.TabIndex = 2;
            this.Del_B.Text = "Удаление";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(295, 144);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(100, 31);
            this.Back_B.TabIndex = 3;
            this.Back_B.Text = "Назад";
            this.Back_B.UseVisualStyleBackColor = true;
            this.Back_B.Click += new System.EventHandler(this.Back_B_Click);
            // 
            // Productivity_DGV
            // 
            this.Productivity_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productivity_DGV.Location = new System.Drawing.Point(12, 12);
            this.Productivity_DGV.Name = "Productivity_DGV";
            this.Productivity_DGV.RowTemplate.Height = 25;
            this.Productivity_DGV.Size = new System.Drawing.Size(277, 163);
            this.Productivity_DGV.TabIndex = 4;
            // 
            // Productivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 187);
            this.Controls.Add(this.Productivity_DGV);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productivity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Производитель";
            ((System.ComponentModel.ISupportInitialize)(this.Productivity_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Add_B;
        private Button Update_B;
        private Button Del_B;
        private Button Back_B;
        private DataGridView Productivity_DGV;
    }
}