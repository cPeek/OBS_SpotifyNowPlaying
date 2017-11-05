using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using System.IO;

namespace OBSSpotifyNowPlaying_Forms {
	public partial class OBSSpotifyNowPlaying : Form {

		private SpotifyLocalAPI spotify;
		private string filePath;

		public OBSSpotifyNowPlaying() {
			InitializeComponent();
		}

		private void OBSSpotifyNowPlaying_Load(object sender, EventArgs e) {
			spotify = new SpotifyLocalAPI();
			text_output.Text = "OBS Spotify Now Playing";
		}

		private void text_file_TextChanged(object sender, EventArgs e) {
			filePath = text_file.Text;
		}

		private void btn_start_Click(object sender, EventArgs e) {
			bool webHelperRunning = SpotifyLocalAPI.IsSpotifyWebHelperRunning();
			bool spotifyRunning = SpotifyLocalAPI.IsSpotifyRunning();

			if(spotifyRunning == true) {
				outputText("Spotify is running.");
			} else {
				outputText("Spotify is not running. Starting Spotify.");
				SpotifyLocalAPI.RunSpotify();
			}

			if(webHelperRunning == true) {
				outputText("WebHelper is running");
			} else {
				outputText("WebHelper is not running. Starting WebHelper.");
				SpotifyLocalAPI.RunSpotifyWebHelper();
			}

			if (spotify.Connect()) {
				outputText("Connected to Spotify.");
			} else {
				outputText("Couldn't connect to Spotify.");
			}

			
			clearText();

			StatusResponse sr = spotify.GetStatus();
			if(sr.Playing == true) {
				Track tr = sr.Track;
				string trackName = tr.TrackResource.Name;
				string artistName = tr.ArtistResource.Name;

				clearText();
				outputText(trackName);
				outputText(artistName);
				writeFile(trackName + "\n" + artistName);
			} else {
				clearText();
				outputText("No Track");
				outputText("N/A");
				writeFile("No Track \n N/A");
			}

			spotify.ListenForEvents = true;
			spotify.OnTrackChange += trackChanged;
			spotify.OnPlayStateChange += playStateChanged;

		}

		private void playStateChanged(object sender, PlayStateEventArgs e) {
			clearText();
			outputText("No Track");
			outputText("N/A");

			writeFile("No Track \n N/A");
		}

		private void trackChanged(object sender, TrackChangeEventArgs e) {
			Track track = e.NewTrack;
			string trackName = track.TrackResource.Name;
			string artistName = track.ArtistResource.Name;

			clearText();
			outputText(trackName);
			outputText(artistName);

			writeFile(trackName + "\n" + artistName);
		}

		private void btn_browse_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				filePath = openFileDialog1.FileName;
				text_file.Text = filePath;
			}
		}

		private void outputText(string output) {
			if (InvokeRequired) {
				this.Invoke(new Action<string>(outputText), new object[] { output });
				return;
			}
			text_output.Text+= "\r\n" + output;
		}
		private void clearText() {
			if (InvokeRequired) {
				this.Invoke(new Action(clearText));
				return;
			}
			text_output.Clear();
		}

		private void writeFile(string text) {
			try {
				StreamWriter sw = new StreamWriter(filePath);
				sw.Write(text);
				sw.Close();
			} catch(Exception ex) {
				clearText();
				outputText(ex.Message);
			}
		}
	}
}
