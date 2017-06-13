using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using DevComponents.DotNetBar;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class COMFiles
    {

        #region "Events"

        public delegate void _IMSS_AddGroupItemsDelegate(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS);

        public event InstalledApps._IMSS_AddGroupItemsDelegate _IMSS_AddGroupItems;

        #endregion

        private BetterListViewGroup _IMSS_TARGET_GROUP = new BetterListViewGroup("ActiveX object") { Image = Properties.Resources._IMSS_COMFILES_Icion_24x24, Tag = "_IMSS_CFILES" };



        public void _IMSS_SCAN_COM()
        {

            _IMSS_START_SCAN_COM(Registry.ClassesRoot);



            if (_IMSS_TARGET_GROUP.Items.Count != 0)
            {
                if (_IMSS_AddGroupItems != null)
                {

                    _IMSS_AddGroupItems(ref _IMSS_TARGET_GROUP);

                }

            }


        }





        private void _IMSS_START_SCAN_COM(RegistryKey _IMSS_SubKey)
        {

            foreach (string _IMSS_Key in _IMSS_SubKey.GetSubKeyNames())
            {

                if (!string.IsNullOrEmpty(_IMSS_Key))
                {


                    if (_IMSS_CheckIfKeyExists(_IMSS_Key + "\\CLSID"))
                    {


                        RegistryKey _IMSS_MinorSubKey = Registry.ClassesRoot.OpenSubKey(_IMSS_Key + @"\CLSID");



                        string StringCLSID = (string)_IMSS_MinorSubKey.GetValue("", "_IMSS_ERROR");



                        _IMSS_MinorSubKey.Close();

                        if (!(string.IsNullOrEmpty(StringCLSID)))
                            if ((StringCLSID != "_IMSS_ERROR"))
                            {

                                // Check if CLSID exists

                                if (_IMSS_CheckIfKeyExists("CLSID\\" + StringCLSID) == false)
                                {

                                    BetterListViewItem _IMSS_LIST_TARGETS = new BetterListViewItem();

                                    _IMSS_LIST_TARGETS.Checked = true;

                                    _IMSS_LIST_TARGETS.Image = Properties.Resources._IMSS_ProcessingWarning_Icon_16x16;

                                    _IMSS_LIST_TARGETS.Text = "Invalid ActiveX object";

                                    _IMSS_LIST_TARGETS.SubItems.Add(Registry.ClassesRoot.ToString());

                                    _IMSS_LIST_TARGETS.SubItems.Add(_IMSS_Key);

                                    _IMSS_TARGET_GROUP.Items.Add(_IMSS_LIST_TARGETS);

                                }


                            }

                    }
                }


            }

        }


        private bool _IMSS_CheckIfKeyExists(string _IMSS_Key)
        {

            try
            {

                RegistryKey _IMSS_CheckKey = Registry.ClassesRoot.OpenSubKey(_IMSS_Key);

                if (_IMSS_CheckKey != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }


        }


    }
}
