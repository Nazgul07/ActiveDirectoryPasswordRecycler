using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PasswordRecycler.Properties;

namespace PasswordRecycler
{
    public partial class frmMain : Form
    {
        private PasswordChanger _adPasswordChanger;
        private string _domain;
		private string _dn;
        public frmMain()
        {
            InitializeComponent();
            foreach (SettingsMap.SettingsMap map in Settings.Default.Connections.Clone())
            {
                comboConnections.Items.Add(map);
            }
            comboConnections.DisplayMember = "Name";
            MessageBox.Show("WARNING: Please close all running applications before use.\n\n"
                + "Any Application that has an open connection to your Active Directory "
                + "(eg: OfficeCommunicator/Lync, Outlook, Browser, etc) can cause you to get locked out of your account."
                +"\n\nIn the event that you do get locked out, contact your system administrator.");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comboConnections.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a Connection first.");
                return;
            }
            progressBarMain.Increment(-100);
            User user = new User(txtUsername.Text, txtPassword.Text, txtNewPassword.Text, _domain, _dn);

            int start;
            int.TryParse(txtStart.Text, out start);
            int iterations;
            int.TryParse(txtIterations.Text, out iterations);
            Action<string, int> update = delegate(string status, int progress)
            {
                UpdateStatus(status, progress);
            };
            Action<string> errorHandle = delegate(string message)
            {
                MessageBox.Show(message);
            };
            _adPasswordChanger = new PasswordChanger(user, update, errorHandle, start, iterations);
            if (txtNewPassword.Text == txtConfirm.Text)
            {
                if (txtPassword.Text != txtNewPassword.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("Since you are not recycling back to your current password, it is STRONGLY recommended that you reboot after completion. "
                    +"Do you want to continue?", "Reboot Recommended", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                _adPasswordChanger.StartJob(cbSingleMode.Checked);
            }
            else 
            {
                MessageBox.Show("Your passwords do not match.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Nazgul"
                + "\n\nUse of this application is not protected under Federal Law."
                + "\n\nYou, and you alone, are responsible for any repercussions that come from using this application. "
                + "\n\nUse at your own risk.");
        }

        private void troubleshootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you get errors like \"The server is not operational\", please don't get discouraged. "
            + "It is very possible that your AD server is busy. Try again in a few hours."
            + "\n\nIf you get errors like \"Exception has been thrown by the target of an invocation\", it is most likely that your password does not meet your AD's complexity requirments."
            + "\n\nIf errors persist, this application is not for you.");   
        }

        private void cbSingleMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSingleMode.Checked)
            {
                txtIterations.Enabled = false;
            }
            else
            {
                txtIterations.Enabled = true;
            }
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            frmConnections connections = new frmConnections();
			connections.FormClosed += (sender2, args) => {
				comboConnections.Items.Clear();
				foreach (SettingsMap.SettingsMap map in Settings.Default.Connections.Clone())
				{
					comboConnections.Items.Add(map);
				}
			};
            connections.ShowDialog();
        }

        private void comboConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsMap.SettingsMap map = (SettingsMap.SettingsMap)comboConnections.SelectedItem;
			_domain = map.DomainController;
			_dn = map.BaseDN;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (comboConnections.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a Connection first.");
                return;
            }
            if (txtUsername.Text.Length < 2 || txtPassword.Text.Length < 2)
            {
                MessageBox.Show("Please fill in your username and current password before testing.");
                return;
            }
            User user = new User(txtUsername.Text, txtPassword.Text, txtNewPassword.Text, _domain, _dn);
            PasswordChanger pc = new PasswordChanger(user);
            try
            {
                pc.Connect();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrWhiteSpace(ex.Message))
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("Oops! Something went wrong. Please check your connection settings.");
            }
        }

        public void UpdateStatus(string status, int progress)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrWhiteSpace(status))
                {
                    labelStatus.Text = status;
                    labelStatus.Refresh();
                }
                progressBarMain.Increment(progress);
                progressBarMain.Refresh();
            });
        }
        
    }
}
