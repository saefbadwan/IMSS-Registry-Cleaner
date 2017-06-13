using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using IMSS_Registry_Cleaner.Classes;

namespace IMSS_Registry_Cleaner
{
    public partial class StartScanning : UserControl
    {

        #region "Events"

        public delegate void _IMSS_ON_ALL_SCAN_COMPLETE_DELEGATE(ref List<BetterListViewGroup> _IMSS_LIST_OF_GROUP_TARGETS);

        public event _IMSS_ON_ALL_SCAN_COMPLETE_DELEGATE _IMSS_ON_ALL_SCAN_COMPLETE;

        #endregion



        #region "General Var"

        private List<BetterListViewGroup> _IMSS_lIST_OF_GROUPS = new List<BetterListViewGroup>();

        #endregion


        private static StartScanning _IMSS_CONTROL;

        public static StartScanning _IMSS_CREATE_CONTROLE()
        {
            if (_IMSS_CONTROL == null)
            {

                _IMSS_CONTROL = new StartScanning();
            }

            return _IMSS_CONTROL;
        }


        public StartScanning()
        {

            InitializeComponent();

            Thread _IMSS_THREAD = new Thread(_IMSS_START_SCANNING);

            _IMSS_THREAD.IsBackground = true;

            _IMSS_THREAD.Start();

        }




        private void _IMSS_START_SCANNING()
        {

            _IMSS_DO_TEXT("Current Category : Scanning startup values");

            StartupScan _IMSS_StartupScan = new StartupScan();

            _IMSS_StartupScan._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_StartupScan._IMSS_SCAN_STARTUP();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning sound files values");

            SoundFilesScan _IMSS_SoundFilesScan = new SoundFilesScan();

            _IMSS_SoundFilesScan._IMSS_StartSoundFilesScan();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning application locations values");

            ApplicationLoctions _IMSS_ApplicationLocation = new ApplicationLoctions();

            _IMSS_ApplicationLocation._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_ApplicationLocation._IMSS_StartScanning();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning shared DLLS values");

            SharedDlls _IMSS_ScanSharedDlls = new SharedDlls();

            _IMSS_ScanSharedDlls._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_ScanSharedDlls._IMSS_SCAN_SHARED_DLLS();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning windows installed fonts values");

            ScanFonts _IMSS_SCAN_FOLNTS = new ScanFonts();

            _IMSS_SCAN_FOLNTS._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_SCAN_FOLNTS._IMSS_SCAN_FONTS();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning drivers files values");

            ScanDrivers _IMSS_SCAN_DRIVERS = new ScanDrivers();

            _IMSS_SCAN_DRIVERS._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_SCAN_DRIVERS._IMSS_SCAN_DRIVERS();

            _IMSS_ADD_SETP();

            _IMSS_DO_TEXT("Current Category : Scanning installed application values");

            InstalledApps _IMSS_SCAN_INSTALLEDAPPS = new InstalledApps();

            _IMSS_SCAN_INSTALLEDAPPS._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_SCAN_INSTALLEDAPPS._IMSS_SCAN_INSTALLEDAPPS();

            _IMSS_ADD_SETP();

            COMFiles _IMSS_SCAN_COMFILES = new COMFiles();

            _IMSS_SCAN_COMFILES._IMSS_AddGroupItems += _IMSS_ON_SCAN_COMPLETE;

            _IMSS_SCAN_COMFILES._IMSS_SCAN_COM();



            // On Complete all Scans

            if (_IMSS_ON_ALL_SCAN_COMPLETE != null)
            {

                _IMSS_ON_ALL_SCAN_COMPLETE(ref _IMSS_lIST_OF_GROUPS);

            }

        }

        private void _IMSS_CANCEL_BUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private delegate void _IMSS_DO_PRPGRESSBAR_DELEGATE(string _IMSS_CURRENT_CATOGRY);
        private void _IMSS_DO_TEXT(string _IMSS_CURRENT_CATOGRY)
        {

            if (_IMSS_CURRENT_CATOGRY_LBL.InvokeRequired == true)
                this._IMSS_CURRENT_CATOGRY_LBL.Invoke(new _IMSS_DO_PRPGRESSBAR_DELEGATE(_IMSS_DO_TEXT),
                    _IMSS_CURRENT_CATOGRY);
            else
                this._IMSS_CURRENT_CATOGRY_LBL.Text = _IMSS_CURRENT_CATOGRY;
        }


        private void _IMSS_ADD_SETP()
        {
            if (_IMSS_SETINDCATOR.InvokeRequired == true)
                _IMSS_SETINDCATOR.Invoke(new MethodInvoker(_IMSS_ADD_SETP));
            else
                _IMSS_SETINDCATOR.CurrentStep += 1;
        }

        private void _IMSS_ON_SCAN_COMPLETE(ref BetterListViewGroup _IMSS_lIST_OF_TARGETS)
        {

            _IMSS_lIST_OF_GROUPS.Add(_IMSS_lIST_OF_TARGETS);

        }


    }
}
