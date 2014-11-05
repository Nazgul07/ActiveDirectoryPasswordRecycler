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
			this.components = new System.ComponentModel.Container();
			this.connectionsGrid = new System.Windows.Forms.DataGridView();
			this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// connectionsGrid
			// 
			this.connectionsGrid.AutoGenerateColumns = false;
			this.connectionsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.connectionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.connectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.connectionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.domainDataGridViewTextBoxColumn,
            this.dNDataGridViewTextBoxColumn});
			this.connectionsGrid.DataSource = this.connectionBindingSource;
			this.connectionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.connectionsGrid.Location = new System.Drawing.Point(0, 0);
			this.connectionsGrid.Name = "connectionsGrid";
			this.connectionsGrid.Size = new System.Drawing.Size(547, 172);
			this.connectionsGrid.TabIndex = 0;
			// 
			// connectionBindingSource
			// 
			this.connectionBindingSource.DataSource = typeof(SettingsMap.SettingsMap);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// domainDataGridViewTextBoxColumn
			// 
			this.domainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.domainDataGridViewTextBoxColumn.DataPropertyName = "DomainController";
			this.domainDataGridViewTextBoxColumn.HeaderText = "Domain (eg: dc01.mydomain.local)";
			this.domainDataGridViewTextBoxColumn.MinimumWidth = 200;
			this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
			this.domainDataGridViewTextBoxColumn.Width = 200;
			// 
			// dNDataGridViewTextBoxColumn
			// 
			this.dNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dNDataGridViewTextBoxColumn.DataPropertyName = "BaseDN";
			this.dNDataGridViewTextBoxColumn.HeaderText = "DN (eg: DC=mydomain,DC=local)";
			this.dNDataGridViewTextBoxColumn.MinimumWidth = 200;
			this.dNDataGridViewTextBoxColumn.Name = "dNDataGridViewTextBoxColumn";
			// 
			// frmConnections
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 172);
			this.Controls.Add(this.connectionsGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "frmConnections";
			this.Text = "LDAP Connections";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnections_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.DataGridView connectionsGrid;
		private System.Windows.Forms.BindingSource connectionBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dNDataGridViewTextBoxColumn;
    }
}