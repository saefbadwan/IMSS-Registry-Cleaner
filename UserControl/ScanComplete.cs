using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using DevComponents.DotNetBar;
using IMSS_Registry_Cleaner.Classes;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner
{

    public partial class ScanComplete : UserControl
    {

        private static ScanComplete _IMSS_CONTROL;

        private List<BetterListViewGroup> _IMSS_LIST_OF_GROUP_TARGETS = new List<BetterListViewGroup>();

        public static ScanComplete _IMSS_CREATE_CONTROLE()
        {
            if (_IMSS_CONTROL == null)
            {

                _IMSS_CONTROL = new ScanComplete();
            }

            return _IMSS_CONTROL;
        }


        public ScanComplete()
        {
            InitializeComponent();

        }


        public void _IMSS_AddRangeTargets(ref List<BetterListViewGroup> IMSS_LIST_OF_GROUP_TARGETS)
        {

            _IMSS_LIST_OF_GROUP_TARGETS = IMSS_LIST_OF_GROUP_TARGETS;

            int _IMSS_allItems = 0;

            for (int i = 0; i < IMSS_LIST_OF_GROUP_TARGETS.Count; i++)
            {

                _IMSS_allItems += IMSS_LIST_OF_GROUP_TARGETS[i].Items.Count;

            }

            _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS = "Selected items : " + _IMSS_allItems.ToString();
            _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG = _IMSS_allItems;



            _IMSS_START_CEANNING._IMSS_TOTAL_SELECTED_ITEMIS = "Total items for clean-up : " + _IMSS_allItems.ToString();

            _IMSS_START_CEANNING._IMSS_CLEANNING_DO_WORK += _IMSS_CLEANNING_DO_WORK;

            Application.DoEvents();

            _IMSS_StartupResult_Tap_Click(null, null);

        }

        private void _IMSS_CLEANNING_DO_WORK(ref int _IMSS_TOTAL_FIX_PROBLEMS)
        {

            SuperTabItem _IMSS_SELECTED_TAP = null;

            foreach (SuperTabItem _IMSS_TAP in _IMSS_ShowResult_TapControl.Tabs)
            {

                _IMSS_SELECTED_TAP = _IMSS_TAP;

                _IMSS_Result_ListView.CheckBoxes = BetterListViewCheckBoxes.Hide;

                _IMSS_ShowResult_TapControl.SelectedTab = _IMSS_TAP;

                _IMSS_TAP.RaiseClick();

                Application.DoEvents();

                foreach (BetterListViewItem _IMSS_ITEM in _IMSS_Result_ListView.CheckedItems)
                {



                    Application.DoEvents();



                    _IMSS_ITEM.Selected = true;
                    _IMSS_ITEM.EnsureVisible();
                    try
                    {

                        if (RegistryEdit._IMSS_REGISTRY_DELETE(_IMSS_ITEM.SubItems[1].Text, _IMSS_ITEM.SubItems[2].Text))
                        {

                            _IMSS_ITEM.Image = Properties.Resources._IMSS_GreenCheckMark_Icon_16x16;

                            _IMSS_TOTAL_FIX_PROBLEMS++;

                        }
                        else
                        {

                            _IMSS_ITEM.Image = Properties.Resources._IMSS_Error_Icon_16x16;

                        }
                    }
                    catch
                    {
                    }





                }

                _IMSS_Result_ListView.Items.Clear();
            }

            if (_IMSS_SELECTED_TAP != null)
                _IMSS_SELECTED_TAP.RaiseClick();

        }

        private void _IMSS_StartupResult_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_STARTUP");

            _IMSS_CheckIfItsEmpty();
        }


        private void _IMSS_SoundFiles_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_SFILES");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_ApplicationsLocations_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_ALOCATIONS");

            _IMSS_CheckIfItsEmpty();
        }


        private void _IMSS_SharedDlls_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_SDLLS");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_WindowsFonts_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS__WFONTS");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_WindowsDrivers_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_WDRIVERS");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_InstalledApps_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_IAPPS");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_HelpFiles_Tap_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_HFILES");

            _IMSS_CheckIfItsEmpty();
        }

        private void _IMSS_COMFILES_Click(object sender, EventArgs e)
        {
            _IMSS_ChangeSelectedGroup("_IMSS_CFILES");

            _IMSS_CheckIfItsEmpty();
        }



        private void _IMSS_ChangeSelectedGroup(string _IMSS_GROUP_INDEX)
        {

            _IMSS_Result_ListView.Groups.Clear();

            if (_IMSS_LIST_OF_GROUP_TARGETS.Count > 0)
            {

                foreach (BetterListViewGroup _IMSS_Group in _IMSS_LIST_OF_GROUP_TARGETS)
                {

                    if (_IMSS_Group.Tag != null)
                        if (_IMSS_Group.Tag.ToString() == _IMSS_GROUP_INDEX)
                        {
                            _IMSS_Result_ListView.Groups.Add(_IMSS_Group);
                        }

                }

            }

        }


        private void _IMSS_CheckIfItsEmpty()
        {

            if (_IMSS_Result_ListView.Groups.Count == 0)
            {

                BetterListViewGroup _IMSS_Group = new BetterListViewGroup();

                _IMSS_Group.Header = "There's no errors found in this category";

                _IMSS_Group.Image = Properties.Resources._IMSS_StatusOn_Icon_16x16;

                _IMSS_Result_ListView.Groups.Add(_IMSS_Group);
            }


        }


        private void _IMSS_Result_ListView_ItemChecked(object sender, BetterListViewItemCheckedEventArgs eventArgs)
        {

            if (eventArgs.Item.Checked)
            {

                _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS = "Selected items : " + ((_IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG) + 1).ToString();
                _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG = (_IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG) + 1;

            }
            else
            {

                _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS = "Selected items : " + ((_IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG) - 1).ToString();
                _IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG = (_IMSS_START_CEANNING._IMSS_SELECTED_ITEMIS_TAG) - 1;

            }

        }


    }


}