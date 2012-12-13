using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesLib;
using System.Collections;
using System.IO;

namespace iTunes_De_Dupulator
{
    public partial class WinMain : Form
    {
        private ArrayList duplicateTracks;
        private Dictionary<string,IITTrack> uniqueTracks;

        /// <summary>
        /// initialize the UI
        /// </summary>
        public WinMain()
        {
            InitializeComponent();
            linkAbout.Links.Add(0, linkAbout.Text.Length, "www.verysimple.com");
        }

        /// <summary>
        /// converts string to lower case, checking for null first.
        /// if null, empty string is returned
        /// </summary>
        /// <param name="prop"></param>
        /// <returns></returns>
        private string safeToLower(string prop)
        {
            return prop == null ? "" : prop.ToLower();
        }

        /// <summary>
        /// enumerate all tracks in the itunes library and check for dups
        /// bind results to the visible datagrid
        /// </summary>
        public void analyzeTracks()
        {
            pbStatus.Value = 0;
            lblStatus.Text = "Opening iTunes... (this may take a moment)";
            btnDelete.Enabled = false;
            dgTracks.DataSource = null;
            statusStrip1.Refresh();

            int durationTolerance = int.Parse(txtDurationTolerance.Text);

            iTunesApp app;
            IITTrackCollection tracks;
            try
            {
                app = new iTunesAppClass();
                tracks = app.LibraryPlaylist.Tracks;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "ERROR: Unable to initialize iTunes Library!"; // +ex.Message;
                statusStrip1.Refresh();
                return;
            }

            // clear out the arrays
            duplicateTracks = new ArrayList();
            uniqueTracks = new Dictionary<string,IITTrack>();

            int limit = tracks.Count;
            pbStatus.Maximum = limit;

            for (int i = 0; i < limit; i++)
            {

                IITTrack track = tracks[i + 1];

                // this unique key will be used to detect if we've seen this track before
                string uniqueTrackKey = safeToLower(track.Name) + safeToLower(track.Artist) + (cbIgnoreAlbum.Checked ? safeToLower(track.Album) : "");

                pbStatus.Value = i + 1;
                lblStatus.Text = "Analyzing Artist: " + track.Artist;
                statusStrip1.Refresh();

                if (uniqueTracks.ContainsKey(uniqueTrackKey))
                {
                    IITTrack origTrack = uniqueTracks[uniqueTrackKey];
                    int upperRange = origTrack.Duration + durationTolerance;
                    int lowerRange = origTrack.Duration - durationTolerance;

                    // check the duration tolerance
                    if (track.Duration > upperRange || track.Duration < lowerRange)
                    {
                        // this is not a duplicate because the duration is
                        // significantly different
                    }
                    else
                    {

                        // add the original track to the duplicate array unless it is already 
                        // there (ie, there are multiple dups of the same song)
                        if (!duplicateTracks.Contains(origTrack))
                            duplicateTracks.Add(origTrack);

                        // add the detected dup
                        duplicateTracks.Add(track);
                    }
                }
                else
                {
                    // we have not seen this song yet so add it to our unique track dictionary

                    if (cbIgnoreUntitled.Checked && (track.Name == null || track.Name.ToLower() == "untitled" || track.Name == ""))
                    {
                        // ignore this song
                    }
                    else
                    {
                        uniqueTracks.Add(uniqueTrackKey, track);
                    }
                }
            }

            lblStatus.Text = "Library Analysis Complete.  Possible Duplicates Found: " + duplicateTracks.Count;
            pbStatus.Value = 0;

            dgTracks.AutoGenerateColumns = false;
            dgTracks.DataSource = duplicateTracks;


            if (duplicateTracks.Count > 0)
            {
                // dgTracks.Sort(TrackName, ListSortDirection.Ascending);
                btnDelete.Enabled = true;
            }

        }

        /// <summary>
        /// Analyze button in clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            this.analyzeTracks();
        }

        /// <summary>
        /// validate the tolerance entered is a valid int
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDurationTolerance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtDurationTolerance.Text);
            }
            catch (Exception)
            {
                txtDurationTolerance.Text = "0";
            }

        }

        /// <summary>
        /// Delete is clicked.  enumerate grid for all checked items and delete them from
        /// the filesystem and library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all checked songs?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int numDeleted = 0;
                for (int i = 0; i < dgTracks.Rows.Count; i++)
                {
                    DataGridViewCell cell = dgTracks.Rows[i].Cells[0];
                    if (true == (bool)cell.EditedFormattedValue)
                    {
                        IITTrack track = (IITTrack)duplicateTracks[i];
                        System.Console.WriteLine("Delete Track " + track.Name);

                        try
                        {
                            DataGridViewCell locationCell = dgTracks.Rows[i].Cells[7];
                            string filePath = (string)locationCell.FormattedValue;
                            File.Delete(filePath);
                        }
                        catch (Exception ex)
                        {
                            lblStatus.Text = ex.Message;
                        }

                        track.Delete();
                        numDeleted++;
                    }
                }


                MessageBox.Show("Removed and deleted " + numDeleted + " songs.  Press 'Analyze' again to refresh results.");
                dgTracks.DataSource = null;
            }
        }

        /// <summary>
        /// Play the song in iTunes when the song name is clicked in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgTracks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                IITTrack track = (IITTrack)duplicateTracks[e.RowIndex];
                track.Play();
            }
        }

        /// <summary>
        /// Open the About URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }


    }
}
