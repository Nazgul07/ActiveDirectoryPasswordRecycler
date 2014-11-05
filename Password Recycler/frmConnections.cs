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
			foreach (SettingsMap.SettingsMap map in Settings.Default.Connections)
			{
				connectionBindingSource.Add(map);
			}
		}

		private void frmConnections_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Connections.Clear();
			Settings.Default.Save();
			foreach (SettingsMap.SettingsMap map in connectionBindingSource)
			{
				Settings.Default.Connections.Add(map);
			}
			Settings.Default.Save();
		}
	}

}
