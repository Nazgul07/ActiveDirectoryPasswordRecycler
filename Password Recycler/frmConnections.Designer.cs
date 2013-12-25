namespace PasswordRecycler
{
    partial class frmConnections
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
			this.connectionsGrid = new System.Windows.Forms.DataGridView();
			this.btnSaveConnection = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// connectionsGrid
			// 
			this.connectionsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.connectionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.connectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.connectionsGrid.Location = new System.Drawing.Point(1, 31);
			this.connectionsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.connectionsGrid.Name = "connectionsGrid";
			this.connectionsGrid.Size = new System.Drawing.Size(561, 145);
			this.connectionsGrid.TabIndex = 0;
			// 
			// btnSaveConnection
			// 
			this.btnSaveConnection.Location = new System.Drawing.Point(448, 183);
			this.btnSaveConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSaveConnection.Name = "btnSaveConnection";
			this.btnSaveConnection.Size = new System.Drawing.Size(100, 28);
			this.btnSaveConnection.TabIndex = 1;
			this.btnSaveConnection.Text = "Save";
			this.btnSaveConnection.UseVisualStyleBackColor = true;
			this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-3, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Example:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(216, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "DC=mydomain,DC=local";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(408, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "dc01.mydomain.local";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 11);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "My Connection";
			// 
			// frmConnections
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 212);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSaveConnection);
			this.Controls.Add(this.connectionsGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(578, 261);
			this.Name = "frmConnections";
			this.Text = "LDAP Connections";
			((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView connectionsGrid;
        private System.Windows.Forms.Button btnSaveConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}