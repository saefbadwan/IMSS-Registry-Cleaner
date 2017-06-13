namespace IMSS_Registry_Cleaner
{
    partial class StartScanning
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this._IMSS_SETINDCATOR = new DevComponents.DotNetBar.Controls.StepIndicator();
            this._IMSS_TITEL_LBL = new DevComponents.DotNetBar.LabelX();
            this._IMSS_DESCRIPTION_LABEL = new System.Windows.Forms.Label();
            this._IMSS_CURRENT_CATOGRY_LBL = new System.Windows.Forms.Label();
            this._IMSS_CLICKS_PANEL = new DevComponents.DotNetBar.PanelEx();
            this._IMSS_CANCEL_BUTTON = new System.Windows.Forms.Button();
            this._IMSS_LOADING_GIF = new System.Windows.Forms.PictureBox();
            this._IMSS_SCANNING_LOGO = new System.Windows.Forms.PictureBox();
            this._IMSS_CLICKS_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_LOADING_GIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_SCANNING_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 121);
            this.progressBar1.MarqueeAnimationSpeed = 4;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(830, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // _IMSS_SETINDCATOR
            // 
            this._IMSS_SETINDCATOR.Location = new System.Drawing.Point(95, 150);
            this._IMSS_SETINDCATOR.Name = "_IMSS_SETINDCATOR";
            this._IMSS_SETINDCATOR.Size = new System.Drawing.Size(830, 4);
            this._IMSS_SETINDCATOR.StepCount = 8;
            this._IMSS_SETINDCATOR.TabIndex = 2;
            // 
            // _IMSS_TITEL_LBL
            // 
            // 
            // 
            // 
            this._IMSS_TITEL_LBL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._IMSS_TITEL_LBL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_TITEL_LBL.Location = new System.Drawing.Point(73, 42);
            this._IMSS_TITEL_LBL.Name = "_IMSS_TITEL_LBL";
            this._IMSS_TITEL_LBL.Size = new System.Drawing.Size(506, 23);
            this._IMSS_TITEL_LBL.TabIndex = 3;
            this._IMSS_TITEL_LBL.Text = "Searching for registry errors that may be able to cleaned or fixed.";
            // 
            // _IMSS_DESCRIPTION_LABEL
            // 
            this._IMSS_DESCRIPTION_LABEL.AutoSize = true;
            this._IMSS_DESCRIPTION_LABEL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_DESCRIPTION_LABEL.Location = new System.Drawing.Point(70, 68);
            this._IMSS_DESCRIPTION_LABEL.Name = "_IMSS_DESCRIPTION_LABEL";
            this._IMSS_DESCRIPTION_LABEL.Size = new System.Drawing.Size(509, 14);
            this._IMSS_DESCRIPTION_LABEL.TabIndex = 4;
            this._IMSS_DESCRIPTION_LABEL.Text = "Please wait while IMSS Registry Cleaner searches your computer for registry error" +
    "s that could be fixed.";
            // 
            // _IMSS_CURRENT_CATOGRY_LBL
            // 
            this._IMSS_CURRENT_CATOGRY_LBL.AutoSize = true;
            this._IMSS_CURRENT_CATOGRY_LBL.Location = new System.Drawing.Point(92, 104);
            this._IMSS_CURRENT_CATOGRY_LBL.Name = "_IMSS_CURRENT_CATOGRY_LBL";
            this._IMSS_CURRENT_CATOGRY_LBL.Size = new System.Drawing.Size(92, 13);
            this._IMSS_CURRENT_CATOGRY_LBL.TabIndex = 5;
            this._IMSS_CURRENT_CATOGRY_LBL.Text = "Checking Catogry";
            // 
            // _IMSS_CLICKS_PANEL
            // 
            this._IMSS_CLICKS_PANEL.CanvasColor = System.Drawing.SystemColors.Control;
            this._IMSS_CLICKS_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CANCEL_BUTTON);
            this._IMSS_CLICKS_PANEL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._IMSS_CLICKS_PANEL.Location = new System.Drawing.Point(0, 523);
            this._IMSS_CLICKS_PANEL.Name = "_IMSS_CLICKS_PANEL";
            this._IMSS_CLICKS_PANEL.Size = new System.Drawing.Size(947, 46);
            this._IMSS_CLICKS_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._IMSS_CLICKS_PANEL.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._IMSS_CLICKS_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._IMSS_CLICKS_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this._IMSS_CLICKS_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._IMSS_CLICKS_PANEL.Style.GradientAngle = 90;
            this._IMSS_CLICKS_PANEL.TabIndex = 7;
            // 
            // _IMSS_CANCEL_BUTTON
            // 
            this._IMSS_CANCEL_BUTTON.Location = new System.Drawing.Point(850, 12);
            this._IMSS_CANCEL_BUTTON.Name = "_IMSS_CANCEL_BUTTON";
            this._IMSS_CANCEL_BUTTON.Size = new System.Drawing.Size(75, 23);
            this._IMSS_CANCEL_BUTTON.TabIndex = 0;
            this._IMSS_CANCEL_BUTTON.Text = "Cancel";
            this._IMSS_CANCEL_BUTTON.UseVisualStyleBackColor = true;
            this._IMSS_CANCEL_BUTTON.Click += new System.EventHandler(this._IMSS_CANCEL_BUTTON_Click);
            // 
            // _IMSS_LOADING_GIF
            // 
            this._IMSS_LOADING_GIF.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_LoadimgGif_Icon;
            this._IMSS_LOADING_GIF.Location = new System.Drawing.Point(73, 104);
            this._IMSS_LOADING_GIF.Name = "_IMSS_LOADING_GIF";
            this._IMSS_LOADING_GIF.Size = new System.Drawing.Size(16, 16);
            this._IMSS_LOADING_GIF.TabIndex = 6;
            this._IMSS_LOADING_GIF.TabStop = false;
            // 
            // _IMSS_SCANNING_LOGO
            // 
            this._IMSS_SCANNING_LOGO.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_ReistryScanning_Icon_111x111;
            this._IMSS_SCANNING_LOGO.Location = new System.Drawing.Point(73, 397);
            this._IMSS_SCANNING_LOGO.Name = "_IMSS_SCANNING_LOGO";
            this._IMSS_SCANNING_LOGO.Size = new System.Drawing.Size(111, 111);
            this._IMSS_SCANNING_LOGO.TabIndex = 0;
            this._IMSS_SCANNING_LOGO.TabStop = false;
            // 
            // StartScanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._IMSS_CLICKS_PANEL);
            this.Controls.Add(this._IMSS_LOADING_GIF);
            this.Controls.Add(this._IMSS_CURRENT_CATOGRY_LBL);
            this.Controls.Add(this._IMSS_DESCRIPTION_LABEL);
            this.Controls.Add(this._IMSS_TITEL_LBL);
            this.Controls.Add(this._IMSS_SETINDCATOR);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this._IMSS_SCANNING_LOGO);
            this.Name = "StartScanning";
            this.Size = new System.Drawing.Size(947, 569);
            this._IMSS_CLICKS_PANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_LOADING_GIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IMSS_SCANNING_LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _IMSS_SCANNING_LOGO;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevComponents.DotNetBar.Controls.StepIndicator _IMSS_SETINDCATOR;
        private DevComponents.DotNetBar.LabelX _IMSS_TITEL_LBL;
        private System.Windows.Forms.Label _IMSS_DESCRIPTION_LABEL;
        private System.Windows.Forms.Label _IMSS_CURRENT_CATOGRY_LBL;
        private System.Windows.Forms.PictureBox _IMSS_LOADING_GIF;
        private DevComponents.DotNetBar.PanelEx _IMSS_CLICKS_PANEL;
        private System.Windows.Forms.Button _IMSS_CANCEL_BUTTON;

    }
}
