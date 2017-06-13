namespace IMSS_Registry_Cleaner
{
    partial class ScanComplete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this._IMSS_ShowResult_TapControl = new DevComponents.DotNetBar.SuperTabStrip();
            this._IMSS_StartupResult_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_SoundFiles_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_ApplicationsLocations_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_SharedDlls_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_HelpFiles_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_WindowsFonts_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_WindowsDrivers_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_InstalledApps_Tap = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_COMFILES = new DevComponents.DotNetBar.SuperTabItem();
            this._IMSS_Result_ListView = new ComponentOwl.BetterListView.BetterListView();
            this._IMSS_PROBLEM = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this._IMSS_DATA = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this._IMSS_VALUE = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this._IMSS_CLICKS_PANEL = new DevComponents.DotNetBar.PanelEx();
            this._IMSS_START_CEANNING = new IMSS_Registry_Cleaner.StartCleanning();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_ShowResult_TapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_Result_ListView)).BeginInit();
            this._IMSS_CLICKS_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this._IMSS_ShowResult_TapControl);
            this.panelEx3.Controls.Add(this._IMSS_Result_ListView);
            this.panelEx3.Controls.Add(this.panelEx4);
            this.panelEx3.Location = new System.Drawing.Point(3, 3);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(941, 512);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // _IMSS_ShowResult_TapControl
            // 
            this._IMSS_ShowResult_TapControl.AutoSelectAttachedControl = false;
            // 
            // 
            // 
            this._IMSS_ShowResult_TapControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._IMSS_ShowResult_TapControl.ContainerControlProcessDialogKey = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this._IMSS_ShowResult_TapControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this._IMSS_ShowResult_TapControl.ControlBox.MenuBox.Name = "";
            this._IMSS_ShowResult_TapControl.ControlBox.Name = "";
            this._IMSS_ShowResult_TapControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this._IMSS_ShowResult_TapControl.ControlBox.MenuBox,
            this._IMSS_ShowResult_TapControl.ControlBox.CloseBox});
            this._IMSS_ShowResult_TapControl.Location = new System.Drawing.Point(0, 24);
            this._IMSS_ShowResult_TapControl.Name = "_IMSS_ShowResult_TapControl";
            this._IMSS_ShowResult_TapControl.ReorderTabsEnabled = true;
            this._IMSS_ShowResult_TapControl.SelectedTabFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._IMSS_ShowResult_TapControl.SelectedTabIndex = 0;
            this._IMSS_ShowResult_TapControl.Size = new System.Drawing.Size(166, 487);
            this._IMSS_ShowResult_TapControl.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right;
            this._IMSS_ShowResult_TapControl.TabCloseButtonHot = null;
            this._IMSS_ShowResult_TapControl.TabFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_ShowResult_TapControl.TabHorizontalSpacing = 14;
            this._IMSS_ShowResult_TapControl.TabIndex = 5;
            this._IMSS_ShowResult_TapControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this._IMSS_StartupResult_Tap,
            this._IMSS_SoundFiles_Tap,
            this._IMSS_ApplicationsLocations_Tap,
            this._IMSS_SharedDlls_Tap,
            this._IMSS_HelpFiles_Tap,
            this._IMSS_WindowsFonts_Tap,
            this._IMSS_WindowsDrivers_Tap,
            this._IMSS_InstalledApps_Tap,
            this._IMSS_COMFILES});
            // 
            // _IMSS_StartupResult_Tap
            // 
            this._IMSS_StartupResult_Tap.GlobalItem = false;
            this._IMSS_StartupResult_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_Startup_Icon_16x16;
            this._IMSS_StartupResult_Tap.Name = "_IMSS_StartupResult_Tap";
            this._IMSS_StartupResult_Tap.Text = "Startup Files";
            this._IMSS_StartupResult_Tap.Click += new System.EventHandler(this._IMSS_StartupResult_Tap_Click);
            // 
            // _IMSS_SoundFiles_Tap
            // 
            this._IMSS_SoundFiles_Tap.GlobalItem = false;
            this._IMSS_SoundFiles_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_SoundFiles_Icon_16x16;
            this._IMSS_SoundFiles_Tap.Name = "_IMSS_SoundFiles_Tap";
            this._IMSS_SoundFiles_Tap.Text = "Sound Files";
            this._IMSS_SoundFiles_Tap.Click += new System.EventHandler(this._IMSS_SoundFiles_Tap_Click);
            // 
            // _IMSS_ApplicationsLocations_Tap
            // 
            this._IMSS_ApplicationsLocations_Tap.GlobalItem = false;
            this._IMSS_ApplicationsLocations_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_ApplicationsLocations_Icon_16x16;
            this._IMSS_ApplicationsLocations_Tap.Name = "_IMSS_ApplicationsLocations_Tap";
            this._IMSS_ApplicationsLocations_Tap.Text = "Apps Locations";
            this._IMSS_ApplicationsLocations_Tap.Click += new System.EventHandler(this._IMSS_ApplicationsLocations_Tap_Click);
            // 
            // _IMSS_SharedDlls_Tap
            // 
            this._IMSS_SharedDlls_Tap.GlobalItem = false;
            this._IMSS_SharedDlls_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_DLLS_Icon_16x16;
            this._IMSS_SharedDlls_Tap.Name = "_IMSS_SharedDlls_Tap";
            this._IMSS_SharedDlls_Tap.Text = "Shared DLLs";
            this._IMSS_SharedDlls_Tap.Click += new System.EventHandler(this._IMSS_SharedDlls_Tap_Click);
            // 
            // _IMSS_HelpFiles_Tap
            // 
            this._IMSS_HelpFiles_Tap.GlobalItem = false;
            this._IMSS_HelpFiles_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_HFILES_Icon_16x16;
            this._IMSS_HelpFiles_Tap.Name = "_IMSS_HelpFiles_Tap";
            this._IMSS_HelpFiles_Tap.Text = "Help Files";
            this._IMSS_HelpFiles_Tap.Click += new System.EventHandler(this._IMSS_HelpFiles_Tap_Click);
            // 
            // _IMSS_WindowsFonts_Tap
            // 
            this._IMSS_WindowsFonts_Tap.GlobalItem = false;
            this._IMSS_WindowsFonts_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_WFONTS_Icon_16x16;
            this._IMSS_WindowsFonts_Tap.Name = "_IMSS_WindowsFonts_Tap";
            this._IMSS_WindowsFonts_Tap.Text = "Windows Fonts";
            this._IMSS_WindowsFonts_Tap.Click += new System.EventHandler(this._IMSS_WindowsFonts_Tap_Click);
            // 
            // _IMSS_WindowsDrivers_Tap
            // 
            this._IMSS_WindowsDrivers_Tap.GlobalItem = false;
            this._IMSS_WindowsDrivers_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_WDRIVERS_Icon_16x16;
            this._IMSS_WindowsDrivers_Tap.Name = "_IMSS_WindowsDrivers_Tap";
            this._IMSS_WindowsDrivers_Tap.Text = "Drivers Files";
            this._IMSS_WindowsDrivers_Tap.Click += new System.EventHandler(this._IMSS_WindowsDrivers_Tap_Click);
            // 
            // _IMSS_InstalledApps_Tap
            // 
            this._IMSS_InstalledApps_Tap.GlobalItem = false;
            this._IMSS_InstalledApps_Tap.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_InstalledApps_Icon_16x16;
            this._IMSS_InstalledApps_Tap.Name = "_IMSS_InstalledApps_Tap";
            this._IMSS_InstalledApps_Tap.Text = "Installed Apps";
            this._IMSS_InstalledApps_Tap.Click += new System.EventHandler(this._IMSS_InstalledApps_Tap_Click);
            // 
            // _IMSS_COMFILES
            // 
            this._IMSS_COMFILES.GlobalItem = false;
            this._IMSS_COMFILES.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_COMFILES_Icion_16x16;
            this._IMSS_COMFILES.Name = "_IMSS_COMFILES";
            this._IMSS_COMFILES.Text = "COM Files";
            this._IMSS_COMFILES.Click += new System.EventHandler(this._IMSS_COMFILES_Click);
            // 
            // _IMSS_Result_ListView
            // 
            this._IMSS_Result_ListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState;
            this._IMSS_Result_ListView.Columns.AddRange(new object[] {
            this._IMSS_PROBLEM,
            this._IMSS_DATA,
            this._IMSS_VALUE});
            this._IMSS_Result_ListView.Location = new System.Drawing.Point(171, 27);
            this._IMSS_Result_ListView.Name = "_IMSS_Result_ListView";
            this._IMSS_Result_ListView.ShowEmptyGroups = true;
            this._IMSS_Result_ListView.ShowGroups = true;
            this._IMSS_Result_ListView.Size = new System.Drawing.Size(767, 482);
            this._IMSS_Result_ListView.TabIndex = 4;
            this._IMSS_Result_ListView.ItemChecked += new ComponentOwl.BetterListView.BetterListViewItemCheckedEventHandler(this._IMSS_Result_ListView_ItemChecked);
            // 
            // _IMSS_PROBLEM
            // 
            this._IMSS_PROBLEM.Name = "_IMSS_PROBLEM";
            this._IMSS_PROBLEM.Text = "Problem";
            this._IMSS_PROBLEM.Width = 254;
            // 
            // _IMSS_DATA
            // 
            this._IMSS_DATA.Name = "_IMSS_DATA";
            this._IMSS_DATA.Text = "Data";
            this._IMSS_DATA.Width = 292;
            // 
            // _IMSS_VALUE
            // 
            this._IMSS_VALUE.Name = "_IMSS_VALUE";
            this._IMSS_VALUE.Text = "Value";
            this._IMSS_VALUE.Width = 210;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(941, 24);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 3;
            this.panelEx4.Text = "Search Result";
            // 
            // _IMSS_CLICKS_PANEL
            // 
            this._IMSS_CLICKS_PANEL.CanvasColor = System.Drawing.SystemColors.Control;
            this._IMSS_CLICKS_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_START_CEANNING);
            this._IMSS_CLICKS_PANEL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._IMSS_CLICKS_PANEL.Location = new System.Drawing.Point(0, 521);
            this._IMSS_CLICKS_PANEL.Name = "_IMSS_CLICKS_PANEL";
            this._IMSS_CLICKS_PANEL.Size = new System.Drawing.Size(947, 48);
            this._IMSS_CLICKS_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._IMSS_CLICKS_PANEL.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._IMSS_CLICKS_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._IMSS_CLICKS_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this._IMSS_CLICKS_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._IMSS_CLICKS_PANEL.Style.GradientAngle = 90;
            this._IMSS_CLICKS_PANEL.TabIndex = 8;
            // 
            // _IMSS_START_CEANNING
            // 
            this._IMSS_START_CEANNING.Location = new System.Drawing.Point(0, 0);
            this._IMSS_START_CEANNING.Name = "_IMSS_START_CEANNING";
            this._IMSS_START_CEANNING.Size = new System.Drawing.Size(947, 165);
            this._IMSS_START_CEANNING.TabIndex = 0;
            // 
            // ScanComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this._IMSS_CLICKS_PANEL);
            this.Name = "ScanComplete";
            this.Size = new System.Drawing.Size(947, 569);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_ShowResult_TapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_Result_ListView)).EndInit();
            this._IMSS_CLICKS_PANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.PanelEx _IMSS_CLICKS_PANEL;
        private ComponentOwl.BetterListView.BetterListView _IMSS_Result_ListView;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader _IMSS_PROBLEM;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader _IMSS_DATA;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader _IMSS_VALUE;
        private DevComponents.DotNetBar.SuperTabStrip _IMSS_ShowResult_TapControl;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_StartupResult_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_SoundFiles_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_ApplicationsLocations_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_SharedDlls_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_WindowsFonts_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_WindowsDrivers_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_InstalledApps_Tap;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_HelpFiles_Tap;
        private StartCleanning _IMSS_START_CEANNING;
        private DevComponents.DotNetBar.SuperTabItem _IMSS_COMFILES;
    }
}
