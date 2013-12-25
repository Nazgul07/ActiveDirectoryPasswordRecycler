using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PasswordRecycler.Properties;
using SettingsMap;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;
using System.Net;
using System.Collections;

namespace PasswordRecycler
{
	public partial class frmConnections : Form
	{
		public frmConnections()
		{
			InitializeComponent();
			connectionsGrid.DataSource = Settings.Default.Connections.Clone();
			connectionsGrid.Columns[0].Width = 170;
			connectionsGrid.Columns[1].Width = 170;
			connectionsGrid.Columns[2].Width = 170;
		}

		private void btnSaveConnection_Click(object sender, EventArgs e)
		{
			Settings.Default.Connections = (SettingsMapCollection)connectionsGrid.DataSource;
			ArrayList list = new ArrayList();
			foreach (SettingsMap.SettingsMap map in Settings.Default.Connections)
			{
				if (map.BaseDN == null && map.Name == null && map.DomainController == null)
					list.Add(map);
			}
			foreach (SettingsMap.SettingsMap map in list)
				Settings.Default.Connections.Remove(map);
			Settings.Default.Save();
			this.Close();
		}


	}

}
