using System;
using System.Collections.Generic;
using System.Text;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class ScanDrivers
    {


        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event StartupScan._IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Windows Drivers") { Image = Properties.Resources._IMSS_WDRIVERS_Icon_24x24,Tag ="_IMSS_WDRIVERS" };

        public void _IMSS_SCAN_DRIVERS()
        {

            _IMSS_START_SCAN_DRIVERS(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Drivers"));

            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }

        }


        private void _IMSS_START_SCAN_DRIVERS(RegistryKey _IMSS_SubKey)
        {

            foreach (string _IMSS_Key in _IMSS_SubKey.GetValueNames())
            {

                string _IMSS_Value = _IMSS_SubKey.GetValue(_IMSS_Key,"0x").ToString();

                if ((_IMSS_Value == null) || (_IMSS_Value != "0x"))
                    continue;



                if (System.IO.File.Exists(_IMSS_Value))
                    continue;


                string  _IMSS_localValue = string.Format("{0}\\{1}", Environment.SystemDirectory, _IMSS_Value);

                if (!System.IO.File.Exists(_IMSS_localValue))
                {

                    BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                    _IMSS_LIST_TARGETS.Checked = true;

                    _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                    _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                    _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey.ToString());

                    _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_Key);

                    _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                }

            }


        }

    }
}
