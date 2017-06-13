using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class HelpFiles
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event InstalledApps._IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Windows Help Files") { Image = Properties.Resources._IMSS_HFILES_Icon_24x24, Tag = "_IMSS_HFILES" };


        public void _IMSS_SCAN_HFILES()
        {

            _IMSS_SCAN_HELP_FILES(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\HTML Help"));

            _IMSS_SCAN_HELP_FILES(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\Help"));

            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }

        }


        private void _IMSS_SCAN_HELP_FILES(RegistryKey _IMSS_SubKey)
        {


            // Check for invalid help files
            foreach (string strHelpFile in _IMSS_SubKey.GetValueNames())
            {
                string strHelpPath = (string)_IMSS_SubKey.GetValue(strHelpFile);

                if (File.Exists(strHelpPath))
                    continue;

                else if (File.Exists(string.Format("{0}\\{1}", strHelpPath, strHelpFile)))
                    continue;

                else
                {


                    BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                    _IMSS_LIST_TARGETS.Checked = true;

                    _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                    _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                    _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey.Name);

                    _IMSS_LIST_TARGETS.SubItems.Add(strHelpFile);

                    _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                }
                
            }

            if (_IMSS_SubKey != null)
                _IMSS_SubKey.Close();

        }

    }
}
