using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class ApplicationLoctions
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event _IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Application Locations") { Image = Properties.Resources._IMSS_ApplicationsLocations_Icon_24x24,Tag = "_IMSS_ALOCATIONS" };


        public void _IMSS_StartScanning()
        {

            _IMSS_START_SCAN_APPLICATION_LOCATION(Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"));

            if (_IMSS_TARGET_GROUP.Items.Count > 0)
            {

                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }
            }

        }

        private void _IMSS_START_SCAN_APPLICATION_LOCATION(RegistryKey _IMSS_TargetKey)
        {

            foreach (string _IMSS_SubKey in _IMSS_TargetKey.GetSubKeyNames())
            {

                if (!string.IsNullOrEmpty(_IMSS_SubKey))
                {

                    string _IMSS_FilePath = _IMSS_TargetKey.OpenSubKey(_IMSS_SubKey).GetValue("", "0").ToString().Replace("\"", "");

                    if (!string.IsNullOrEmpty(_IMSS_FilePath))
                    {

                        if (!System.IO.File.Exists(_IMSS_FilePath))
                        {

                            if (_IMSS_FilePath == "0")
                            {
                                _IMSS_FilePath = "Null Reference";
                            }

                            BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                            _IMSS_LIST_TARGETS.Checked = true;

                            _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                            _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_TargetKey.Name);

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey);

                            _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);


                        }

                    }



                }
                continue;
            }

            if (_IMSS_TargetKey != null)
                _IMSS_TargetKey.Close();

        }


        private void _IMSS_ON_COMPLETE()
        {


            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }

        }

    }
}
