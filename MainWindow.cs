using System.Collections.Generic;
using System.Windows.Forms;
using ComponentOwl.BetterListView;

namespace IMSS_Registry_Cleaner
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


            StartScanning _IMSS_START_SCANNING = StartScanning._IMSS_CREATE_CONTROLE();

            _IMSS_START_SCANNING._IMSS_ON_ALL_SCAN_COMPLETE += _IMSS_ON_SCAN_COMPLETE;

            this._IMSS_MainPanel.Controls.Add(_IMSS_START_SCANNING);


        }






        ScanComplete _IMSS_ON_COMPLETE = new ScanComplete();

        public void _IMSS_ON_SCAN_COMPLETE(ref List<BetterListViewGroup> _IMSS_LIST_OF_GROUP_TARGETS)
        {




            List<BetterListViewGroup> IMSS_LIST_OF_GROUP_TARGETS = _IMSS_LIST_OF_GROUP_TARGETS;

            _IMSS_ON_COMPLETE._IMSS_AddRangeTargets(ref IMSS_LIST_OF_GROUP_TARGETS);

            this._IMSS_MainPanel.Invoke(new MethodInvoker(() =>
            {

                this._IMSS_MainPanel.Controls.Clear();

                this._IMSS_MainPanel.Controls.Add(_IMSS_ON_COMPLETE);

            }));


        }
    }
}
