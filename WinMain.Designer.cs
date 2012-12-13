namespace iTunes_De_Dupulator
{
    partial class WinMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.dgTracks = new System.Windows.Forms.DataGridView();
            this.TrackDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackBitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblDurationTolerance = new System.Windows.Forms.Label();
            this.txtDurationTolerance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbIgnoreUntitled = new System.Windows.Forms.CheckBox();
            this.lblIgnoreUntitled = new System.Windows.Forms.Label();
            this.cbIgnoreAlbum = new System.Windows.Forms.CheckBox();
            this.lblIgnoreAlbum = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgTracks)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTracks
            // 
            this.dgTracks.AllowUserToAddRows = false;
            this.dgTracks.AllowUserToDeleteRows = false;
            this.dgTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackDelete,
            this.TrackNumber,
            this.TrackName,
            this.TrackAlbum,
            this.TrackArtist,
            this.TrackDuration,
            this.TrackBitRate,
            this.TrackLocation});
            this.dgTracks.Location = new System.Drawing.Point(0, 1);
            this.dgTracks.Name = "dgTracks";
            this.dgTracks.RowHeadersVisible = false;
            this.dgTracks.Size = new System.Drawing.Size(782, 292);
            this.dgTracks.TabIndex = 1;
            this.dgTracks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTracks_CellContentClick_1);
            // 
            // TrackDelete
            // 
            this.TrackDelete.FalseValue = "false";
            this.TrackDelete.HeaderText = "";
            this.TrackDelete.MinimumWidth = 25;
            this.TrackDelete.Name = "TrackDelete";
            this.TrackDelete.TrueValue = "true";
            this.TrackDelete.Width = 25;
            // 
            // TrackNumber
            // 
            this.TrackNumber.DataPropertyName = "TrackNumber";
            this.TrackNumber.HeaderText = "#";
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.ReadOnly = true;
            this.TrackNumber.Width = 30;
            // 
            // TrackName
            // 
            this.TrackName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackName.DataPropertyName = "Name";
            this.TrackName.FillWeight = 125F;
            this.TrackName.HeaderText = "Name";
            this.TrackName.MinimumWidth = 75;
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
            // 
            // TrackAlbum
            // 
            this.TrackAlbum.DataPropertyName = "Album";
            this.TrackAlbum.HeaderText = "Album";
            this.TrackAlbum.Name = "TrackAlbum";
            this.TrackAlbum.ReadOnly = true;
            // 
            // TrackArtist
            // 
            this.TrackArtist.DataPropertyName = "Artist";
            this.TrackArtist.HeaderText = "Artist";
            this.TrackArtist.Name = "TrackArtist";
            this.TrackArtist.ReadOnly = true;
            // 
            // TrackDuration
            // 
            this.TrackDuration.DataPropertyName = "Duration";
            this.TrackDuration.HeaderText = "Duration";
            this.TrackDuration.Name = "TrackDuration";
            this.TrackDuration.ReadOnly = true;
            this.TrackDuration.Width = 55;
            // 
            // TrackBitRate
            // 
            this.TrackBitRate.DataPropertyName = "BitRate";
            this.TrackBitRate.HeaderText = "BitRate";
            this.TrackBitRate.Name = "TrackBitRate";
            this.TrackBitRate.Width = 50;
            // 
            // TrackLocation
            // 
            this.TrackLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackLocation.DataPropertyName = "Location";
            this.TrackLocation.FillWeight = 150F;
            this.TrackLocation.HeaderText = "Location";
            this.TrackLocation.MinimumWidth = 50;
            this.TrackLocation.Name = "TrackLocation";
            this.TrackLocation.ReadOnly = true;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(613, 9);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(155, 23);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze Library";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblDurationTolerance
            // 
            this.lblDurationTolerance.AutoSize = true;
            this.lblDurationTolerance.Location = new System.Drawing.Point(10, 14);
            this.lblDurationTolerance.Name = "lblDurationTolerance";
            this.lblDurationTolerance.Size = new System.Drawing.Size(275, 13);
            this.lblDurationTolerance.TabIndex = 5;
            this.lblDurationTolerance.Text = "Ignore songs where difference in duration is greater than:";
            // 
            // txtDurationTolerance
            // 
            this.txtDurationTolerance.Location = new System.Drawing.Point(289, 11);
            this.txtDurationTolerance.Name = "txtDurationTolerance";
            this.txtDurationTolerance.Size = new System.Drawing.Size(44, 20);
            this.txtDurationTolerance.TabIndex = 6;
            this.txtDurationTolerance.Text = "5";
            this.txtDurationTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDurationTolerance.TextChanged += new System.EventHandler(this.txtDurationTolerance_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkAbout);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cbIgnoreUntitled);
            this.panel1.Controls.Add(this.lblIgnoreUntitled);
            this.panel1.Controls.Add(this.cbIgnoreAlbum);
            this.panel1.Controls.Add(this.lblIgnoreAlbum);
            this.panel1.Controls.Add(this.lblDurationTolerance);
            this.panel1.Controls.Add(this.txtDurationTolerance);
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 97);
            this.panel1.TabIndex = 7;
            // 
            // linkAbout
            // 
            this.linkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(689, 73);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(79, 13);
            this.linkAbout.TabIndex = 12;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "verysimple.com";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(613, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Checked Tracks";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbIgnoreUntitled
            // 
            this.cbIgnoreUntitled.AutoSize = true;
            this.cbIgnoreUntitled.Checked = true;
            this.cbIgnoreUntitled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreUntitled.Location = new System.Drawing.Point(289, 63);
            this.cbIgnoreUntitled.Name = "cbIgnoreUntitled";
            this.cbIgnoreUntitled.Size = new System.Drawing.Size(44, 17);
            this.cbIgnoreUntitled.TabIndex = 10;
            this.cbIgnoreUntitled.Text = "Yes";
            this.cbIgnoreUntitled.UseVisualStyleBackColor = true;
            // 
            // lblIgnoreUntitled
            // 
            this.lblIgnoreUntitled.AutoSize = true;
            this.lblIgnoreUntitled.Location = new System.Drawing.Point(10, 64);
            this.lblIgnoreUntitled.Name = "lblIgnoreUntitled";
            this.lblIgnoreUntitled.Size = new System.Drawing.Size(182, 13);
            this.lblIgnoreUntitled.TabIndex = 9;
            this.lblIgnoreUntitled.Text = "Ignore blank name or \'untitled\' songs:";
            // 
            // cbIgnoreAlbum
            // 
            this.cbIgnoreAlbum.AutoSize = true;
            this.cbIgnoreAlbum.Checked = true;
            this.cbIgnoreAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreAlbum.Location = new System.Drawing.Point(289, 38);
            this.cbIgnoreAlbum.Name = "cbIgnoreAlbum";
            this.cbIgnoreAlbum.Size = new System.Drawing.Size(44, 17);
            this.cbIgnoreAlbum.TabIndex = 8;
            this.cbIgnoreAlbum.Text = "Yes";
            this.cbIgnoreAlbum.UseVisualStyleBackColor = true;
            // 
            // lblIgnoreAlbum
            // 
            this.lblIgnoreAlbum.AutoSize = true;
            this.lblIgnoreAlbum.Location = new System.Drawing.Point(10, 39);
            this.lblIgnoreAlbum.Name = "lblIgnoreAlbum";
            this.lblIgnoreAlbum.Size = new System.Drawing.Size(214, 13);
            this.lblIgnoreAlbum.TabIndex = 7;
            this.lblIgnoreAlbum.Text = "Ignore songs when Album Name is different:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbStatus,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbStatus
            // 
            this.pbStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(158, 17);
            this.lblStatus.Text = "Press \'Analyze Library\' To Begin";
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgTracks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTunes De-Duplulator";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgTracks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTracks;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblDurationTolerance;
        private System.Windows.Forms.TextBox txtDurationTolerance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblIgnoreAlbum;
        private System.Windows.Forms.CheckBox cbIgnoreAlbum;
        private System.Windows.Forms.CheckBox cbIgnoreUntitled;
        private System.Windows.Forms.Label lblIgnoreUntitled;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrackDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackBitRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLocation;
        private System.Windows.Forms.LinkLabel linkAbout;
    }
}

