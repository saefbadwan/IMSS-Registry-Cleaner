using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class InstalledApps
    {


        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event _IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Installed Applications") { Image = Properties.Resources._IMSS_InstalledApps_Icon_24x24, Tag = "_IMSS_IAPPS" };

        public void _IMSS_SCAN_INSTALLEDAPPS()
        {

            try
            {

                _IMSS_CkicInstalledapplications(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\"));

            }
            catch{}

            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }

        }

        private void _IMSS_CkicInstalledapplications(RegistryKey _IMSS_SubKeys)
        {

            foreach (string _IMSS_SubKey in _IMSS_SubKeys.GetSubKeyNames())
            {

                // MessageBox.Show(_IMSS_SubKey);

                RegistryKey _IMSS_LocalSubKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + _IMSS_SubKey);

                string _IMSS_REGISTRY_PATH = Registry.LocalMachine.Name + "\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";

                string strUninstallString = (string)_IMSS_LocalSubKey.GetValue("UninstallString");
                string strQuietUninstallString = (string)_IMSS_LocalSubKey.GetValue("QuietUninstallString");
                string strInstallLocation = (string)_IMSS_LocalSubKey.GetValue("InstallLocation");
                string strDisplayIcon = (string)_IMSS_LocalSubKey.GetValue("DisplayIcon");

                uint nWinInstaller = Convert.ToUInt32(_IMSS_LocalSubKey.GetValue("WindowsInstaller"));

                if (nWinInstaller != 1)
                {

                    if (strDisplayIcon != null)
                    {
                        string strIconPath = "";

                        // See if file already exists
                        if (File.Exists(strDisplayIcon))
                            goto next;

                        // Remove quotes
                        if (strDisplayIcon[0] == '"')
                        {
                            int i, iQouteLoc = 0, iQoutes = 1;
                            for (i = 0; (i < strDisplayIcon.Length) && (iQoutes <= 2); i++)
                            {
                                if (strDisplayIcon[i] == '"')
                                {
                                    strDisplayIcon = strDisplayIcon.Remove(i, 1);
                                    iQouteLoc = i;
                                    iQoutes++;
                                }
                            }
                        }

                        // Parse display icon path
                        if (strDisplayIcon.LastIndexOf(',') > 0)
                        {
                            strIconPath = strDisplayIcon.Substring(0, strDisplayIcon.LastIndexOf(','));

                            if (!File.Exists(strIconPath))
                            {

                                BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                                _IMSS_LIST_TARGETS.Checked = true;

                                _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                                _IMSS_LIST_TARGETS.Text = "Invalid file or folder";
                                
                                _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_LocalSubKey.Name);

                                _IMSS_LIST_TARGETS.SubItems.Add("DisplayIcon");

                                _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                            }
                        }
                    }

                next:

                    if (strInstallLocation != null)
                    {

                        if (!Directory.Exists(strInstallLocation) && !File.Exists(strInstallLocation))
                        {

                            BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                            _IMSS_LIST_TARGETS.Checked = true;

                            _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                            _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_REGISTRY_PATH);

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey);

                            _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                            continue;
                        }
                    }
                }

            }


        }

    }
}
