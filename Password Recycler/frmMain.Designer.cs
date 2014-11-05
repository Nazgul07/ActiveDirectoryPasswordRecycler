namespace PasswordRecycler
{
    partial class frmMain
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
			this.btnGo = new System.Windows.Forms.Button();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.progressBarMain = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.cbSingleMode = new System.Windows.Forms.CheckBox();
			this.txtIterations = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtStart = new System.Windows.Forms.TextBox();
			this.labelStart = new System.Windows.Forms.Label();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.troubleshootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.troubleShootToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.comboConnections = new System.Windows.Forms.ComboBox();
			this.lblADConnstring = new System.Windows.Forms.Label();
			this.btnAddConnection = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(292, 156);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 0;
			this.btnGo.Text = "Start";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(91, 110);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(188, 20);
			this.txtNewPassword.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(91, 55);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(188, 20);
			this.txtUsername.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(91, 83);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(188, 20);
			this.txtPassword.TabIndex = 2;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(12, 169);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(0, 13);
			this.labelStatus.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Username";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Current Pass";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "New Pass";
			// 
			// progressBarMain
			// 
			this.progressBarMain.Location = new System.Drawing.Point(0, 185);
			this.progressBarMain.Name = "progressBarMain";
			this.progressBarMain.Size = new System.Drawing.Size(380, 23);
			this.progressBarMain.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Confirm";
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(91, 136);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.Size = new System.Drawing.Size(188, 20);
			this.txtConfirm.TabIndex = 4;
			// 
			// cbSingleMode
			// 
			this.cbSingleMode.AutoSize = true;
			this.cbSingleMode.Location = new System.Drawing.Point(194, 162);
			this.cbSingleMode.Name = "cbSingleMode";
			this.cbSingleMode.Size = new System.Drawing.Size(85, 17);
			this.cbSingleMode.TabIndex = 13;
			this.cbSingleMode.Text = "Single Mode";
			this.cbSingleMode.UseVisualStyleBackColor = true;
			this.cbSingleMode.CheckedChanged += new System.EventHandler(this.cbSingleMode_CheckedChanged);
			// 
			// txtIterations
			// 
			this.txtIterations.Location = new System.Drawing.Point(341, 106);
			this.txtIterations.Name = "txtIterations";
			this.txtIterations.Size = new System.Drawing.Size(30, 20);
			this.txtIterations.TabIndex = 16;
			this.txtIterations.Text = "24";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(282, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Iterations:";
			// 
			// txtStart
			// 
			this.txtStart.Location = new System.Drawing.Point(341, 81);
			this.txtStart.Name = "txtStart";
			this.txtStart.Size = new System.Drawing.Size(30, 20);
			this.txtStart.TabIndex = 18;
			this.txtStart.Text = "1";
			// 
			// labelStart
			// 
			this.labelStart.AutoSize = true;
			this.labelStart.Location = new System.Drawing.Point(281, 84);
			this.labelStart.Name = "labelStart";
			this.labelStart.Size = new System.Drawing.Size(39, 13);
			this.labelStart.TabIndex = 19;
			this.labelStart.Text = "Start #";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.troubleshootToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// troubleshootToolStripMenuItem
			// 
			this.troubleshootToolStripMenuItem.Name = "troubleshootToolStripMenuItem";
			this.troubleshootToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.troubleshootToolStripMenuItem.Text = "Troubleshoot...";
			this.troubleshootToolStripMenuItem.Click += new System.EventHandler(this.troubleshootToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(380, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.troubleShootToolStripMenuItem1});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem1.Text = "File";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// troubleShootToolStripMenuItem1
			// 
			this.troubleShootToolStripMenuItem1.Name = "troubleShootToolStripMenuItem1";
			this.troubleShootToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.troubleShootToolStripMenuItem1.Text = "Troubleshoot";
			this.troubleShootToolStripMenuItem1.Click += new System.EventHandler(this.troubleshootToolStripMenuItem_Click);
			// 
			// comboConnections
			// 
			this.comboConnections.FormattingEnabled = true;
			this.comboConnections.Location = new System.Drawing.Point(91, 28);
			this.comboConnections.Name = "comboConnections";
			this.comboConnections.Size = new System.Drawing.Size(94, 21);
			this.comboConnections.TabIndex = 20;
			this.comboConnections.SelectedIndexChanged += new System.EventHandler(this.comboConnections_SelectedIndexChanged);
			// 
			// lblADConnstring
			// 
			this.lblADConnstring.AutoSize = true;
			this.lblADConnstring.Location = new System.Drawing.Point(14, 31);
			this.lblADConnstring.Name = "lblADConnstring";
			this.lblADConnstring.Size = new System.Drawing.Size(61, 13);
			this.lblADConnstring.TabIndex = 21;
			this.lblADConnstring.Text = "Connection";
			// 
			// btnAddConnection
			// 
			this.btnAddConnection.Location = new System.Drawing.Point(191, 27);
			this.btnAddConnection.Name = "btnAddConnection";
			this.btnAddConnection.Size = new System.Drawing.Size(88, 23);
			this.btnAddConnection.TabIndex = 22;
			this.btnAddConnection.Text = "Connections...";
			this.btnAddConnection.UseVisualStyleBackColor = true;
			this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(292, 27);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 23;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(380, 208);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnAddConnection);
			this.Controls.Add(this.lblADConnstring);
			this.Controls.Add(this.comboConnections);
			this.Controls.Add(this.labelStart);
			this.Controls.Add(this.txtStart);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtIterations);
			this.Controls.Add(this.cbSingleMode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.progressBarMain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "Active Directory Password Recycler";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.CheckBox cbSingleMode;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troubleshootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem troubleShootToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboConnections;
        private System.Windows.Forms.Label lblADConnstring;
        private System.Windows.Forms.Button btnAddConnection;
		private System.Windows.Forms.Button btnTest;

    }
}

