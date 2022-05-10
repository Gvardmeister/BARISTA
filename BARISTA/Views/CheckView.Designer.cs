namespace BARISTA.Views
{
    partial class CheckView
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
            this.Check_DGV = new System.Windows.Forms.DataGridView();
            this.Back_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Check_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_DGV
            // 
            this.Check_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Check_DGV.Location = new System.Drawing.Point(12, 12);
            this.Check_DGV.Name = "Check_DGV";
            this.Check_DGV.RowTemplate.Height = 25;
            this.Check_DGV.Size = new System.Drawing.Size(277, 163);
            this.Check_DGV.TabIndex = 14;
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(295, 144);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(100, 31);
            this.Back_B.TabIndex = 13;
            this.Back_B.Text = "Назад";
            this.Back_B.UseVisualStyleBackColor = true;
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(296, 85);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(100, 31);
            this.Del_B.TabIndex = 12;
            this.Del_B.Text = "Удаление";
            this.Del_B.UseVisualStyleBackColor = true;
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(296, 48);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(100, 31);
            this.Update_B.TabIndex = 11;
            this.Update_B.Text = "Изменение";
            this.Update_B.UseVisualStyleBackColor = true;
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(296, 11);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(100, 31);
            this.Add_B.TabIndex = 10;
            this.Add_B.Text = "Добавление";
            this.Add_B.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 186);
            this.Controls.Add(this.Check_DGV);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чек";
            ((System.ComponentModel.ISupportInitialize)(this.Check_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Check_DGV;
        private Button Back_B;
        private Button Del_B;
        private Button Update_B;
        private Button Add_B;
    }
}