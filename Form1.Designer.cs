namespace DSplit
{
    partial class Form1
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
            lblTimer = new Label();
            btnStartStop = new Button();
            btnSplit = new Button();
            lstSplits = new ListBox();
            btnReset = new Button();
            btnClearSplits = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            GameNameTxt = new TextBox();
            txtSplits = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.Left;
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(256, 405);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(37, 15);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "Timer";
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Left;
            btnStartStop.Location = new Point(3, 71);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(75, 23);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start/Stop";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnSplit
            // 
            btnSplit.Location = new Point(84, 71);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(75, 23);
            btnSplit.TabIndex = 2;
            btnSplit.Text = "Split";
            btnSplit.UseVisualStyleBackColor = true;
            btnSplit.Click += btnSplit_Click;
            // 
            // lstSplits
            // 
            lstSplits.FormattingEnabled = true;
            lstSplits.ItemHeight = 15;
            lstSplits.Location = new Point(165, 23);
            lstSplits.Name = "lstSplits";
            lstSplits.Size = new Size(214, 379);
            lstSplits.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(3, 100);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClearSplits
            // 
            btnClearSplits.Location = new Point(84, 100);
            btnClearSplits.Name = "btnClearSplits";
            btnClearSplits.Size = new Size(75, 23);
            btnClearSplits.TabIndex = 5;
            btnClearSplits.Text = "Clear Splits";
            btnClearSplits.UseVisualStyleBackColor = true;
            btnClearSplits.Click += btnClearSplits_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(402, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, eToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(116, 22);
            saveToolStripMenuItem.Text = "Save As";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(116, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(116, 22);
            eToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // GameNameTxt
            // 
            GameNameTxt.Location = new Point(31, 42);
            GameNameTxt.Name = "GameNameTxt";
            GameNameTxt.Size = new Size(100, 23);
            GameNameTxt.TabIndex = 7;
            GameNameTxt.Text = "Game name?";
            GameNameTxt.TextAlign = HorizontalAlignment.Center;
            GameNameTxt.TextChanged += GameNameTxt_TextChanged;
            GameNameTxt.KeyDown += GameNameTxt_KeyDown;
            // 
            // txtSplits
            // 
            txtSplits.Location = new Point(165, 23);
            txtSplits.Multiline = true;
            txtSplits.Name = "txtSplits";
            txtSplits.ScrollBars = ScrollBars.Vertical;
            txtSplits.Size = new Size(214, 379);
            txtSplits.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 432);
            Controls.Add(txtSplits);
            Controls.Add(GameNameTxt);
            Controls.Add(btnClearSplits);
            Controls.Add(btnReset);
            Controls.Add(lstSplits);
            Controls.Add(btnSplit);
            Controls.Add(btnStartStop);
            Controls.Add(lblTimer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnStartStop;
        private Button btnSplit;
        private ListBox lstSplits;
        private Button btnReset;
        private Button btnClearSplits;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox GameNameTxt;
        private TextBox txtSplits;
    }
}
