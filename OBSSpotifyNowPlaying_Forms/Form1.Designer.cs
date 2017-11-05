namespace OBSSpotifyNowPlaying_Forms {
	partial class OBSSpotifyNowPlaying {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OBSSpotifyNowPlaying));
			this.text_file = new System.Windows.Forms.TextBox();
			this.btn_browse = new System.Windows.Forms.Button();
			this.text_output = new System.Windows.Forms.TextBox();
			this.btn_start = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// text_file
			// 
			this.text_file.Location = new System.Drawing.Point(12, 12);
			this.text_file.Name = "text_file";
			this.text_file.Size = new System.Drawing.Size(260, 20);
			this.text_file.TabIndex = 0;
			this.text_file.TextChanged += new System.EventHandler(this.text_file_TextChanged);
			// 
			// btn_browse
			// 
			this.btn_browse.Location = new System.Drawing.Point(12, 38);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(75, 23);
			this.btn_browse.TabIndex = 1;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = true;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// text_output
			// 
			this.text_output.Location = new System.Drawing.Point(12, 89);
			this.text_output.Multiline = true;
			this.text_output.Name = "text_output";
			this.text_output.ReadOnly = true;
			this.text_output.Size = new System.Drawing.Size(260, 59);
			this.text_output.TabIndex = 2;
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(197, 38);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(75, 23);
			this.btn_start.TabIndex = 3;
			this.btn_start.Text = "Start";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "now-playing.txt";
			// 
			// OBSSpotifyNowPlaying
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 158);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.text_output);
			this.Controls.Add(this.btn_browse);
			this.Controls.Add(this.text_file);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OBSSpotifyNowPlaying";
			this.Text = "Spotify Now Playing";
			this.Load += new System.EventHandler(this.OBSSpotifyNowPlaying_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox text_file;
		private System.Windows.Forms.Button btn_browse;
		private System.Windows.Forms.TextBox text_output;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

