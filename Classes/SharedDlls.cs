using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class SharedDlls
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event SoundFilesScan._IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Shared DLLs") { Image = Properties.Resources._IMSS_DLLS_Icon_24x24, Tag = "_IMSS_SDLLS" };



        public void _IMSS_SCAN_SHARED_DLLS()
        {

            _IMSS_SCAN_SHAREDDLLS(Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\SharedDLLs"));


            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }




        }


        private void _IMSS_SCAN_SHAREDDLLS(RegistryKey _IMSS_SubKey)
        {

            foreach (string _IMSS_Key in _IMSS_SubKey.GetValueNames())
            {

                if (!string.IsNullOrEmpty(_IMSS_Key))
                {

                    string _IMSS_FilePath = _IMSS_Key;


                    if (!System.IO.File.Exists(_IMSS_FilePath))
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

            if (_IMSS_SubKey != null)
            {
                _IMSS_SubKey.Close();
            }


        }

    }
}
