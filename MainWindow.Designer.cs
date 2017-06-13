namespace IMSS_Registry_Cleaner
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._IMSS_MainPanel = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // _IMSS_MainPanel
            // 
            this._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._IMSS_MainPanel.Location = new System.Drawing.Point(0, 0);
            this._IMSS_MainPanel.Name = "_IMSS_MainPanel";
            this._IMSS_MainPanel.Size = new System.Drawing.Size(947, 569);
            this._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._IMSS_MainPanel.Style.GradientAngle = 90;
            this._IMSS_MainPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 569);
            this.Controls.Add(this._IMSS_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMSS Registry Cleaner";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx _IMSS_MainPanel;
    }
}

