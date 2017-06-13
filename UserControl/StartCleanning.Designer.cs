namespace IMSS_Registry_Cleaner
{
    partial class StartCleanning
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
            this._IMSS_CLICKS_PANEL = new DevComponents.DotNetBar.PanelEx();
            this._IMSS_CLOSE_BUTTON = new DevComponents.DotNetBar.ButtonX();
            this._IMSS_CLEANING_PROGRESSBAR = new System.Windows.Forms.ProgressBar();
            this._IMSS_CANCEL_CLEANNING_BUTTON = new DevComponents.DotNetBar.ButtonX();
            this._IMSS_SELECT_TO_DELETE_LABEl = new System.Windows.Forms.Label();
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl = new System.Windows.Forms.Label();
            this._IMSS_CANCEL = new DevComponents.DotNetBar.ButtonX();
            this._IMSS_CLEAN_UP = new DevComponents.DotNetBar.ButtonX();
            this._IMSS_COMPLETE_TOTAL_LABEL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._IMSS_CLICKS_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _IMSS_CLICKS_PANEL
            // 
            this._IMSS_CLICKS_PANEL.CanvasColor = System.Drawing.SystemColors.Control;
            this._IMSS_CLICKS_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_COMPLETE_TOTAL_LABEL);
            this._IMSS_CLICKS_PANEL.Controls.Add(this.pictureBox1);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CLOSE_BUTTON);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CLEANING_PROGRESSBAR);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CANCEL_CLEANNING_BUTTON);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_SELECT_TO_DELETE_LABEl);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CANCEL);
            this._IMSS_CLICKS_PANEL.Controls.Add(this._IMSS_CLEAN_UP);
            this._IMSS_CLICKS_PANEL.Location = new System.Drawing.Point(0, 1);
            this._IMSS_CLICKS_PANEL.Name = "_IMSS_CLICKS_PANEL";
            this._IMSS_CLICKS_PANEL.Size = new System.Drawing.Size(947, 158);
            this._IMSS_CLICKS_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._IMSS_CLICKS_PANEL.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke;
            this._IMSS_CLICKS_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._IMSS_CLICKS_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._IMSS_CLICKS_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this._IMSS_CLICKS_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._IMSS_CLICKS_PANEL.Style.GradientAngle = 90;
            this._IMSS_CLICKS_PANEL.TabIndex = 9;
            // 
            // _IMSS_CLOSE_BUTTON
            // 
            this._IMSS_CLOSE_BUTTON.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._IMSS_CLOSE_BUTTON.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._IMSS_CLOSE_BUTTON.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_CLOSE_BUTTON.Location = new System.Drawing.Point(858, 119);
            this._IMSS_CLOSE_BUTTON.Name = "_IMSS_CLOSE_BUTTON";
            this._IMSS_CLOSE_BUTTON.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 4, 4, 0);
            this._IMSS_CLOSE_BUTTON.Size = new System.Drawing.Size(73, 26);
            this._IMSS_CLOSE_BUTTON.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CLOSE_BUTTON.TabIndex = 6;
            this._IMSS_CLOSE_BUTTON.Text = "Close";
            this._IMSS_CLOSE_BUTTON.Click += new System.EventHandler(this._IMSS_CLOSE_BUTTON_Click);
            // 
            // _IMSS_CLEANING_PROGRESSBAR
            // 
            this._IMSS_CLEANING_PROGRESSBAR.Enabled = false;
            this._IMSS_CLEANING_PROGRESSBAR.Location = new System.Drawing.Point(18, 73);
            this._IMSS_CLEANING_PROGRESSBAR.MarqueeAnimationSpeed = 4;
            this._IMSS_CLEANING_PROGRESSBAR.Name = "_IMSS_CLEANING_PROGRESSBAR";
            this._IMSS_CLEANING_PROGRESSBAR.Size = new System.Drawing.Size(820, 23);
            this._IMSS_CLEANING_PROGRESSBAR.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this._IMSS_CLEANING_PROGRESSBAR.TabIndex = 5;
            // 
            // _IMSS_CANCEL_CLEANNING_BUTTON
            // 
            this._IMSS_CANCEL_CLEANNING_BUTTON.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._IMSS_CANCEL_CLEANNING_BUTTON.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._IMSS_CANCEL_CLEANNING_BUTTON.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_CANCEL_CLEANNING_BUTTON.Location = new System.Drawing.Point(858, 72);
            this._IMSS_CANCEL_CLEANNING_BUTTON.Name = "_IMSS_CANCEL_CLEANNING_BUTTON";
            this._IMSS_CANCEL_CLEANNING_BUTTON.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 4, 4, 0);
            this._IMSS_CANCEL_CLEANNING_BUTTON.Size = new System.Drawing.Size(73, 26);
            this._IMSS_CANCEL_CLEANNING_BUTTON.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CANCEL_CLEANNING_BUTTON.TabIndex = 4;
            this._IMSS_CANCEL_CLEANNING_BUTTON.Text = "Cancel";
            // 
            // _IMSS_SELECT_TO_DELETE_LABEl
            // 
            this._IMSS_SELECT_TO_DELETE_LABEl.AutoSize = true;
            this._IMSS_SELECT_TO_DELETE_LABEl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_SELECT_TO_DELETE_LABEl.Location = new System.Drawing.Point(6, 8);
            this._IMSS_SELECT_TO_DELETE_LABEl.Name = "_IMSS_SELECT_TO_DELETE_LABEl";
            this._IMSS_SELECT_TO_DELETE_LABEl.Size = new System.Drawing.Size(115, 15);
            this._IMSS_SELECT_TO_DELETE_LABEl.TabIndex = 3;
            this._IMSS_SELECT_TO_DELETE_LABEl.Text = "Selected Items : 16";
            // 
            // _IMSS_TOTAL_SELECT_TO_DELETE_LABEl
            // 
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.AutoSize = true;
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Location = new System.Drawing.Point(6, 26);
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Name = "_IMSS_TOTAL_SELECT_TO_DELETE_LABEl";
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Size = new System.Drawing.Size(174, 15);
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.TabIndex = 2;
            this._IMSS_TOTAL_SELECT_TO_DELETE_LABEl.Text = "Total selected for clean-up : 16";
            // 
            // _IMSS_CANCEL
            // 
            this._IMSS_CANCEL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._IMSS_CANCEL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._IMSS_CANCEL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_CANCEL.Location = new System.Drawing.Point(765, 11);
            this._IMSS_CANCEL.Name = "_IMSS_CANCEL";
            this._IMSS_CANCEL.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 4, 4, 0);
            this._IMSS_CANCEL.Size = new System.Drawing.Size(73, 26);
            this._IMSS_CANCEL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CANCEL.TabIndex = 1;
            this._IMSS_CANCEL.Text = "Cancel";
            this._IMSS_CANCEL.Click += new System.EventHandler(this._IMSS_CANCEL_Click);
            // 
            // _IMSS_CLEAN_UP
            // 
            this._IMSS_CLEAN_UP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._IMSS_CLEAN_UP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._IMSS_CLEAN_UP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_CLEAN_UP.Location = new System.Drawing.Point(844, 11);
            this._IMSS_CLEAN_UP.Name = "_IMSS_CLEAN_UP";
            this._IMSS_CLEAN_UP.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 4, 4, 0);
            this._IMSS_CLEAN_UP.Size = new System.Drawing.Size(87, 26);
            this._IMSS_CLEAN_UP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._IMSS_CLEAN_UP.TabIndex = 0;
            this._IMSS_CLEAN_UP.Text = "Clean up";
            this._IMSS_CLEAN_UP.Click += new System.EventHandler(this._IMSS_CLEAN_UP_Click);
            // 
            // _IMSS_COMPLETE_TOTAL_LABEL
            // 
            this._IMSS_COMPLETE_TOTAL_LABEL.AutoSize = true;
            this._IMSS_COMPLETE_TOTAL_LABEL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._IMSS_COMPLETE_TOTAL_LABEL.ForeColor = System.Drawing.Color.Green;
            this._IMSS_COMPLETE_TOTAL_LABEL.Location = new System.Drawing.Point(72, 123);
            this._IMSS_COMPLETE_TOTAL_LABEL.Name = "_IMSS_COMPLETE_TOTAL_LABEL";
            this._IMSS_COMPLETE_TOTAL_LABEL.Size = new System.Drawing.Size(175, 22);
            this._IMSS_COMPLETE_TOTAL_LABEL.TabIndex = 8;
            this._IMSS_COMPLETE_TOTAL_LABEL.Text = "Problems are fixed.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMSS_Registry_Cleaner.Properties.Resources._IMSS_GreenCheckMark_Icon_48x48;
            this.pictureBox1.Location = new System.Drawing.Point(18, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StartCleanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._IMSS_CLICKS_PANEL);
            this.Name = "StartCleanning";
            this.Size = new System.Drawing.Size(947, 159);
            this._IMSS_CLICKS_PANEL.ResumeLayout(false);
            this._IMSS_CLICKS_PANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx _IMSS_CLICKS_PANEL;
        private System.Windows.Forms.Label _IMSS_SELECT_TO_DELETE_LABEl;
        private System.Windows.Forms.Label _IMSS_TOTAL_SELECT_TO_DELETE_LABEl;
        private DevComponents.DotNetBar.ButtonX _IMSS_CANCEL;
        private DevComponents.DotNetBar.ButtonX _IMSS_CLEAN_UP;
        private System.Windows.Forms.ProgressBar _IMSS_CLEANING_PROGRESSBAR;
        private DevComponents.DotNetBar.ButtonX _IMSS_CANCEL_CLEANNING_BUTTON;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX _IMSS_CLOSE_BUTTON;
        private System.Windows.Forms.Label _IMSS_COMPLETE_TOTAL_LABEL;
    }
}
