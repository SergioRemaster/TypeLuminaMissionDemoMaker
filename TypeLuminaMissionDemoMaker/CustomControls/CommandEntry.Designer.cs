namespace TypeLuminaMissionDemoMaker.CustomControls
{
    partial class CommandEntry
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PcbDirection = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NumFrames = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PcbA = new System.Windows.Forms.PictureBox();
            this.PcbB = new System.Windows.Forms.PictureBox();
            this.PcbC = new System.Windows.Forms.PictureBox();
            this.PcbD = new System.Windows.Forms.PictureBox();
            this.LabPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDirection)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbD)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbDirection
            // 
            this.PcbDirection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbDirection.Image = global::TypeLuminaMissionDemoMaker.Properties.Resources.nodir;
            this.PcbDirection.Location = new System.Drawing.Point(141, 3);
            this.PcbDirection.Name = "PcbDirection";
            this.PcbDirection.Size = new System.Drawing.Size(40, 40);
            this.PcbDirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbDirection.TabIndex = 0;
            this.PcbDirection.TabStop = false;
            this.PcbDirection.Click += new System.EventHandler(this.PcbDirection_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NumFrames);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.PcbDirection);
            this.flowLayoutPanel1.Controls.Add(this.PcbA);
            this.flowLayoutPanel1.Controls.Add(this.PcbB);
            this.flowLayoutPanel1.Controls.Add(this.PcbC);
            this.flowLayoutPanel1.Controls.Add(this.PcbD);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NumFrames
            // 
            this.NumFrames.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumFrames.Location = new System.Drawing.Point(3, 7);
            this.NumFrames.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.NumFrames.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumFrames.Name = "NumFrames";
            this.NumFrames.Size = new System.Drawing.Size(73, 34);
            this.NumFrames.TabIndex = 5;
            this.NumFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frames";
            // 
            // PcbA
            // 
            this.PcbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbA.Image = global::TypeLuminaMissionDemoMaker.Properties.Resources.a;
            this.PcbA.InitialImage = global::TypeLuminaMissionDemoMaker.Properties.Resources.a;
            this.PcbA.Location = new System.Drawing.Point(187, 3);
            this.PcbA.Name = "PcbA";
            this.PcbA.Size = new System.Drawing.Size(40, 40);
            this.PcbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbA.TabIndex = 1;
            this.PcbA.TabStop = false;
            this.PcbA.Click += new System.EventHandler(this.PcbA_Click);
            // 
            // PcbB
            // 
            this.PcbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbB.Image = global::TypeLuminaMissionDemoMaker.Properties.Resources.b;
            this.PcbB.InitialImage = global::TypeLuminaMissionDemoMaker.Properties.Resources.b;
            this.PcbB.Location = new System.Drawing.Point(233, 3);
            this.PcbB.Name = "PcbB";
            this.PcbB.Size = new System.Drawing.Size(40, 40);
            this.PcbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbB.TabIndex = 2;
            this.PcbB.TabStop = false;
            this.PcbB.Click += new System.EventHandler(this.PcbB_Click);
            // 
            // PcbC
            // 
            this.PcbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbC.Image = global::TypeLuminaMissionDemoMaker.Properties.Resources.c;
            this.PcbC.Location = new System.Drawing.Point(279, 3);
            this.PcbC.Name = "PcbC";
            this.PcbC.Size = new System.Drawing.Size(40, 40);
            this.PcbC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbC.TabIndex = 3;
            this.PcbC.TabStop = false;
            this.PcbC.Click += new System.EventHandler(this.PcbC_Click);
            // 
            // PcbD
            // 
            this.PcbD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbD.Image = global::TypeLuminaMissionDemoMaker.Properties.Resources.d;
            this.PcbD.Location = new System.Drawing.Point(325, 3);
            this.PcbD.Name = "PcbD";
            this.PcbD.Size = new System.Drawing.Size(40, 40);
            this.PcbD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbD.TabIndex = 4;
            this.PcbD.TabStop = false;
            this.PcbD.Click += new System.EventHandler(this.PcbD_Click);
            // 
            // LabPosition
            // 
            this.LabPosition.AutoSize = true;
            this.LabPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabPosition.Location = new System.Drawing.Point(10, 19);
            this.LabPosition.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LabPosition.Name = "LabPosition";
            this.LabPosition.Size = new System.Drawing.Size(30, 19);
            this.LabPosition.TabIndex = 7;
            this.LabPosition.Text = "Pos";
            // 
            // CommandEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabPosition);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CommandEntry";
            this.Size = new System.Drawing.Size(461, 64);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDirection)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PcbDirection;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown NumFrames;
        private PictureBox PcbA;
        private PictureBox PcbB;
        private PictureBox PcbC;
        private PictureBox PcbD;
        private Label label1;
        private Label LabPosition;
    }
}
