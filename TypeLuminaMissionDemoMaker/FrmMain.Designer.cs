namespace TypeLuminaMissionDemoMaker
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoadSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveAsSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.FlpCommandList = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnInsertCommand = new System.Windows.Forms.Button();
            this.BtnAppendCommand = new System.Windows.Forms.Button();
            this.BtnDeleteCommand = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewSequence,
            this.MnuLoadSequence,
            this.MnuSaveSequence,
            this.MnuSaveAsSequence,
            this.toolStripSeparator1,
            this.MnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MnuNewSequence
            // 
            this.MnuNewSequence.Name = "MnuNewSequence";
            this.MnuNewSequence.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuNewSequence.Size = new System.Drawing.Size(287, 22);
            this.MnuNewSequence.Text = "New Sequence...";
            this.MnuNewSequence.Click += new System.EventHandler(this.MnuNewSequence_Click);
            // 
            // MnuLoadSequence
            // 
            this.MnuLoadSequence.Name = "MnuLoadSequence";
            this.MnuLoadSequence.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MnuLoadSequence.Size = new System.Drawing.Size(287, 22);
            this.MnuLoadSequence.Text = "Load Sequence...";
            this.MnuLoadSequence.Click += new System.EventHandler(this.MnuLoadSequence_Click);
            // 
            // MnuSaveSequence
            // 
            this.MnuSaveSequence.Name = "MnuSaveSequence";
            this.MnuSaveSequence.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuSaveSequence.Size = new System.Drawing.Size(287, 22);
            this.MnuSaveSequence.Text = "Save Sequence";
            this.MnuSaveSequence.Click += new System.EventHandler(this.MnuSaveSequence_Click);
            // 
            // MnuSaveAsSequence
            // 
            this.MnuSaveAsSequence.Name = "MnuSaveAsSequence";
            this.MnuSaveAsSequence.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MnuSaveAsSequence.Size = new System.Drawing.Size(287, 22);
            this.MnuSaveAsSequence.Text = "Save Sequence As...";
            this.MnuSaveAsSequence.Click += new System.EventHandler(this.MnuSaveAsSequence_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // MnuClose
            // 
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(287, 22);
            this.MnuClose.Text = "Close";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // FlpCommandList
            // 
            this.FlpCommandList.AutoScroll = true;
            this.FlpCommandList.Location = new System.Drawing.Point(12, 36);
            this.FlpCommandList.Name = "FlpCommandList";
            this.FlpCommandList.Size = new System.Drawing.Size(506, 402);
            this.FlpCommandList.TabIndex = 1;
            // 
            // BtnInsertCommand
            // 
            this.BtnInsertCommand.Location = new System.Drawing.Point(34, 446);
            this.BtnInsertCommand.Name = "BtnInsertCommand";
            this.BtnInsertCommand.Size = new System.Drawing.Size(141, 31);
            this.BtnInsertCommand.TabIndex = 2;
            this.BtnInsertCommand.Text = "Insert Command At...";
            this.BtnInsertCommand.UseVisualStyleBackColor = true;
            this.BtnInsertCommand.Click += new System.EventHandler(this.BtnInsertCommand_Click);
            // 
            // BtnAppendCommand
            // 
            this.BtnAppendCommand.Location = new System.Drawing.Point(191, 445);
            this.BtnAppendCommand.Name = "BtnAppendCommand";
            this.BtnAppendCommand.Size = new System.Drawing.Size(141, 31);
            this.BtnAppendCommand.TabIndex = 3;
            this.BtnAppendCommand.Text = "Append Command";
            this.BtnAppendCommand.UseVisualStyleBackColor = true;
            this.BtnAppendCommand.Click += new System.EventHandler(this.BtnAppendCommand_Click);
            // 
            // BtnDeleteCommand
            // 
            this.BtnDeleteCommand.Location = new System.Drawing.Point(350, 445);
            this.BtnDeleteCommand.Name = "BtnDeleteCommand";
            this.BtnDeleteCommand.Size = new System.Drawing.Size(141, 31);
            this.BtnDeleteCommand.TabIndex = 4;
            this.BtnDeleteCommand.Text = "Delete Command At...";
            this.BtnDeleteCommand.UseVisualStyleBackColor = true;
            this.BtnDeleteCommand.Click += new System.EventHandler(this.BtnDeleteCommand_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 489);
            this.Controls.Add(this.BtnDeleteCommand);
            this.Controls.Add(this.BtnAppendCommand);
            this.Controls.Add(this.BtnInsertCommand);
            this.Controls.Add(this.FlpCommandList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Mission Demo Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem MnuNewSequence;
        private ToolStripMenuItem MnuLoadSequence;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuClose;
        private FlowLayoutPanel FlpCommandList;
        private ToolStripMenuItem MnuSaveSequence;
        private ToolStripMenuItem MnuSaveAsSequence;
        private Button BtnInsertCommand;
        private Button BtnAppendCommand;
        private Button BtnDeleteCommand;
    }
}