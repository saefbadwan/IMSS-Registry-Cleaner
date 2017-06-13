using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMSS_Registry_Cleaner
{

    public partial class StartCleanning : UserControl
    {

        private int _IMSS_TOTAL_FIX_PROBLEMS = 0;

        #region "Events"


        public delegate void _IMSS_START_CLEANNING_DOWORK(ref int IMSS_TOTAL_FIX_PROBLEMS);

        public event _IMSS_START_CLEANNING_DOWORK _IMSS_CLEANNING_DO_WORK;

        #endregion



        public string _IMSS_SELECTED_ITEMIS {
            set { _IMSS_SELECT_TO_DELETE_LABEl.Text = value; }
        }

        public int _IMSS_SELECTED_ITEMIS_TAG
        {
            get { return (int)_IMSS_SELECT_TO_DELETE_LABEl.Tag; }
            set { _IMSS_SELECT_TO_DELETE_LABEl.Tag = value; }
        }

        public string _IMSS_TOTAL_SELECTED_ITEMIS
        {
            set { _IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Text = value; }
        }

        public StartCleanning()
        {
            InitializeComponent();
        }

        private void _IMSS_CANCEL_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void _IMSS_CLEAN_UP_Click(object sender, EventArgs e)
        {

            _IMSS_CLEANING_PROGRESSBAR.Enabled = true;

            for (int i = 0; i > -61; i--){this._IMSS_CLICKS_PANEL.Location = new Point(0,i);Application.DoEvents();}

            // Raise Cleanning Events

            _IMSS_CLEANNING_DO_WORK(ref _IMSS_TOTAL_FIX_PROBLEMS);

            // On Event Raise Complete

            for (int i = -61; i > -110; i--) { this._IMSS_CLICKS_PANEL.Location = new Point(0, i); Application.DoEvents(); }

            _IMSS_COMPLETE_TOTAL_LABEL.Text = _IMSS_TOTAL_FIX_PROBLEMS.ToString() + " , Problems are fixed.";

        }

        private void _IMSS_CLOSE_BUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
