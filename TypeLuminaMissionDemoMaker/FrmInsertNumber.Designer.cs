namespace TypeLuminaMissionDemoMaker
{
    partial class FrmInsertNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumPosition = new System.Windows.Forms.NumericUpDown();
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the position number to\r\ninsert the new command.";
            // 
            // NumPosition
            // 
            this.NumPosition.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumPosition.Location = new System.Drawing.Point(23, 68);
            this.NumPosition.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.NumPosition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumPosition.Name = "NumPosition";
            this.NumPosition.Size = new System.Drawing.Size(192, 34);
            this.NumPosition.TabIndex = 6;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(30, 121);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(181, 23);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmInsertNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 156);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.NumPosition);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert a Number";
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown NumPosition;
        private Button BtnOK;
    }
}