namespace BARISTA.Views
{
    partial class ReportView
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_B = new System.Windows.Forms.Button();
            this.Show_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(12, 27);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(286, 244);
            this.ListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчёт по доходности за день";
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(304, 144);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(100, 31);
            this.Back_B.TabIndex = 9;
            this.Back_B.Text = "Назад";
            this.Back_B.UseVisualStyleBackColor = true;
            this.Back_B.Click += new System.EventHandler(this.Back_B_Click);
            // 
            // Show_B
            // 
            this.Show_B.Location = new System.Drawing.Point(304, 107);
            this.Show_B.Name = "Show_B";
            this.Show_B.Size = new System.Drawing.Size(100, 31);
            this.Show_B.TabIndex = 10;
            this.Show_B.Text = "Отобразить";
            this.Show_B.UseVisualStyleBackColor = true;
            this.Show_B.Click += new System.EventHandler(this.Show_B_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 283);
            this.Controls.Add(this.Show_B);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListBox;
        private Label label1;
        private Button Back_B;
        private Button Show_B;
    }
}