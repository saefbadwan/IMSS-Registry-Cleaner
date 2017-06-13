using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ComponentOwl.BetterListView;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class ScanFonts
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event StartupScan._IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("Windows Fonts") { Image = Properties.Resources._IMSS_WFONTS_Icon_24x24,Tag = "_IMSS_WFONT" };

        #region "Get Windows folders"

        [DllImport("shell32.dll")]
        private static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder strPath, int nFolder, bool fCreate);

        #endregion

        const int CSIDL_FONTS = 0x0014;    // windows\fonts


        public void _IMSS_SCAN_FONTS()
        {

            _IMSS_SCAN_FONTS(Registry.LocalMachine.OpenSubKey(@"Software\\Microsoft\\Windows NT\\CurrentVersion\\Fonts"));

            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }

        }

        private void _IMSS_SCAN_FONTS(RegistryKey _IMSS_SubKey)
        {

            StringBuilder strPath = new StringBuilder(260);

            if (!SHGetSpecialFolderPath(IntPtr.Zero, strPath, CSIDL_FONTS, false))
                return;


            foreach (string strFontName in _IMSS_SubKey.GetValueNames())
            {


                string strValue = _IMSS_SubKey.GetValue(strFontName).ToString();




                // Check value by itself
                if (File.Exists(strValue))
                    continue;

                // Check for font in fonts folder
                string strFontPath = String.Format("{0}\\{1}", strPath.ToString(), strValue);

                if (!File.Exists(strFontPath))
                {

                    BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                    _IMSS_LIST_TARGETS.Checked = true;

                    _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                    _IMSS_LIST_TARGETS.Text = "Invalid file or folder";

                    _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_SubKey.ToString());

                    _IMSS_LIST_TARGETS.SubItems.Add(strFontName);

                    _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                }
            }

            if (_IMSS_SubKey != null)
            {

                _IMSS_SubKey.Close();

            }

        }

    }
}
