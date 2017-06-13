using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{

    class StartupScan
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event _IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion


        #region "Dll Functions"
        [DllImport("kernel32.dll")]
        private static extern int SearchPath(string strPath, string strFileName, string strExtension, uint nBufferLength, StringBuilder strBuffer, string strFilePart);

        #endregion


       private  BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Startup Errors"){Image = Properties.Resources._IMSS_Startup_Icon_24x24,Tag = "_IMSS_STARTUP"};

        public void _IMSS_SCAN_STARTUP()
        {


            try
            {
                _IMSS_CheckStartupKeys(Registry.LocalMachine, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            }
            catch
            {
            }
            try
            {
                _IMSS_CheckStartupKeys(Registry.LocalMachine, "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
            }
            catch
            {
            }

            try
            {

                _IMSS_CheckStartupKeys(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            }
            catch
            {
            }

            try
            {
                _IMSS_CheckStartupKeys(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
            }
            catch
            {
            }


            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }


        }

        private void _IMSS_CheckStartupKeys(RegistryKey _IMSS_TARGET_KEY, string _IMSS_SUB_KEY)
        {


                foreach (string _IMSS_VALUE in _IMSS_TARGET_KEY.OpenSubKey(_IMSS_SUB_KEY, false).GetValueNames())
                {
                    if (!string.IsNullOrEmpty(_IMSS_VALUE))
                    {

                        string _IMSS_TARGET_PATH =
                            _IMSS_ExtractRunPath(
                                _IMSS_TARGET_KEY.OpenSubKey(_IMSS_SUB_KEY).GetValue(_IMSS_VALUE).ToString());


                        if (System.IO.File.Exists(_IMSS_TARGET_PATH))
                            continue; // Exit the sub 


                        if (_IMSS_TARGET_PATH == null)
                            continue; // Exit the sub

                        // Search for file in %path% variable
                        StringBuilder strBuffer = new StringBuilder(260);

                        if (SearchPath(null, _IMSS_TARGET_PATH, null, 260, strBuffer, null) != 0)
                            continue;

                        if (!System.IO.File.Exists(_IMSS_TARGET_PATH))
                        {

                            BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                            _IMSS_LIST_TARGETS.Checked = true;

                            _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                            _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_TARGET_KEY.ToString() + "\\" + _IMSS_SUB_KEY);

                            _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_VALUE);

                            _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                        }



                    }
                }
   
            _IMSS_TARGET_KEY.Close();
        }

        //private void _IMSS_ON_COMPLETE()
        //{




        //}




        private string _IMSS_ExtractRunPath(string value)
        {

            try
            {
                int p = 0;

                // Check for quotes, and if present, remove them.
                if (value.Contains(((char)34).ToString()))
                {
                    value = value.Replace(((char)34).ToString(), "");
                }

                // Check for hyphens, and if present, return the part before first one,
                // unless it is before the extension.
                if (value.Contains("-"))
                {
                    p = value.IndexOf("-");
                    int pDot = value.IndexOf(".");
                    if (p > pDot)
                    {
                        value = value.Substring(0, p - 1);
                    }
                }

                // Check for forward slashes, and if present, return the part before first one.
                if (value.Contains("/"))
                {
                    p = value.IndexOf("/");
                    value = value.Substring(0, p - 1);
                }

                // Check for a space followed by a percent sign, and if present, return the part before the first one.
                if (value.Contains(" %"))
                {
                    p = value.IndexOf(" %");
                    value = value.Substring(0, p);
                }

                if (!string.IsNullOrEmpty(value))
                {
                    return Path.GetFullPath(value);
                }
                else
                {
                    return "";
                }

            }
            catch
            {
                return "";
            }

        }

    }


}
