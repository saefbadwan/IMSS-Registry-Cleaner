using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{


    class SoundFilesScan
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event _IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Sound Files") { Image = Properties.Resources._IMSS_SoundFiles_Icon_24x24,Tag = "_IMSS_SFILES" };



        public void _IMSS_StartSoundFilesScan()
        {

            RegistryKey _IMSS_RegKey = Registry.CurrentUser.OpenSubKey("AppEvents\\Schemes\\Apps");

            _IMSS_SCAN_SOUND_FILES(_IMSS_RegKey);

            _IMSS_RegKey.Close();


            if (_IMSS_TARGET_GROUP.Items.Count > 0)
            {

                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }
            }
        }




        private void _IMSS_SCAN_SOUND_FILES(RegistryKey _IMSS_SubKey)
        {

            foreach (string _IMSS_Key in _IMSS_SubKey.GetSubKeyNames())
            {

                if ((_IMSS_Key.Equals(".Current") == true) || (_IMSS_Key.Equals(".Modified") == true))
                {

                    RegistryKey _IMSS_SubKeys = _IMSS_SubKey.OpenSubKey(_IMSS_Key);

                    string _IMSS_FilePath = _IMSS_SubKeys.GetValue("").ToString();

                    if (string.IsNullOrEmpty(_IMSS_FilePath))
                        continue;

                    if (!System.IO.File.Exists(_IMSS_FilePath))
                    {

                        BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                        _IMSS_LIST_TARGETS.Checked = true;

                        _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                        _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                        _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey.ToString() + "\\" + _IMSS_Key + _IMSS_SubKeys.Name);

                        _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_FilePath);

                        _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                    }

                    continue; // Exit for

                }

                _IMSS_SCAN_SOUND_FILES(_IMSS_SubKey.OpenSubKey(_IMSS_Key));
            }
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
