namespace BassKickAss
{
    partial class MainKBOForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainKBOForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1Metronome = new System.Windows.Forms.TabPage();
            this.trackBarTempo = new System.Windows.Forms.TrackBar();
            this.labelCurrentBeat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxQuarterNote4 = new System.Windows.Forms.PictureBox();
            this.picBoxQuarterNote3 = new System.Windows.Forms.PictureBox();
            this.picBoxQuarterNote2 = new System.Windows.Forms.PictureBox();
            this.picBoxQuarterNote1 = new System.Windows.Forms.PictureBox();
            this.numUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescTempo = new System.Windows.Forms.Label();
            this.buttonMetronomePlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage2Notes = new System.Windows.Forms.TabPage();
            this.tabPage3Recorder = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRecDevice = new System.Windows.Forms.Label();
            this.pictureBoxRecording = new System.Windows.Forms.PictureBox();
            this.checkBoxPlayback = new System.Windows.Forms.CheckBox();
            this.buttonToWave = new System.Windows.Forms.Button();
            this.btnRefreshSources = new System.Windows.Forms.Button();
            this.listViewSources = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRecStop = new System.Windows.Forms.Button();
            this.buttonRecStart = new System.Windows.Forms.Button();
            this.tabPageDrumkit = new System.Windows.Forms.TabPage();
            this.tabPageExercises = new System.Windows.Forms.TabPage();
            this.tabPageTuner = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelRecordingTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage1Metronome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTempo)).BeginInit();
            this.tabPage3Recorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecording)).BeginInit();
            this.tabPageTuner.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1Metronome);
            this.tabControlMain.Controls.Add(this.tabPage2Notes);
            this.tabControlMain.Controls.Add(this.tabPage3Recorder);
            this.tabControlMain.Controls.Add(this.tabPageDrumkit);
            this.tabControlMain.Controls.Add(this.tabPageExercises);
            this.tabControlMain.Controls.Add(this.tabPageTuner);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(460, 385);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPage1Metronome
            // 
            this.tabPage1Metronome.Controls.Add(this.trackBarTempo);
            this.tabPage1Metronome.Controls.Add(this.labelCurrentBeat);
            this.tabPage1Metronome.Controls.Add(this.label2);
            this.tabPage1Metronome.Controls.Add(this.picBoxQuarterNote4);
            this.tabPage1Metronome.Controls.Add(this.picBoxQuarterNote3);
            this.tabPage1Metronome.Controls.Add(this.picBoxQuarterNote2);
            this.tabPage1Metronome.Controls.Add(this.picBoxQuarterNote1);
            this.tabPage1Metronome.Controls.Add(this.numUpDownTempo);
            this.tabPage1Metronome.Controls.Add(this.label1);
            this.tabPage1Metronome.Controls.Add(this.labelDescTempo);
            this.tabPage1Metronome.Controls.Add(this.buttonMetronomePlay);
            this.tabPage1Metronome.Controls.Add(this.menuStrip1);
            this.tabPage1Metronome.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Metronome.Name = "tabPage1Metronome";
            this.tabPage1Metronome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Metronome.Size = new System.Drawing.Size(452, 359);
            this.tabPage1Metronome.TabIndex = 0;
            this.tabPage1Metronome.Text = "Metronome";
            this.tabPage1Metronome.UseVisualStyleBackColor = true;
            // 
            // trackBarTempo
            // 
            this.trackBarTempo.LargeChange = 1;
            this.trackBarTempo.Location = new System.Drawing.Point(6, 55);
            this.trackBarTempo.Maximum = 240;
            this.trackBarTempo.Name = "trackBarTempo";
            this.trackBarTempo.Size = new System.Drawing.Size(440, 45);
            this.trackBarTempo.TabIndex = 14;
            this.trackBarTempo.Value = 80;
            this.trackBarTempo.ValueChanged += new System.EventHandler(this.trackBarTempo_ValueChanged);
            // 
            // labelCurrentBeat
            // 
            this.labelCurrentBeat.AutoSize = true;
            this.labelCurrentBeat.Location = new System.Drawing.Point(206, 157);
            this.labelCurrentBeat.Name = "labelCurrentBeat";
            this.labelCurrentBeat.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentBeat.TabIndex = 12;
            this.labelCurrentBeat.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Meter beats: 4/4";
            // 
            // picBoxQuarterNote4
            // 
            this.picBoxQuarterNote4.BackColor = System.Drawing.Color.Black;
            this.picBoxQuarterNote4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuarterNote4.Location = new System.Drawing.Point(171, 109);
            this.picBoxQuarterNote4.Name = "picBoxQuarterNote4";
            this.picBoxQuarterNote4.Size = new System.Drawing.Size(48, 45);
            this.picBoxQuarterNote4.TabIndex = 10;
            this.picBoxQuarterNote4.TabStop = false;
            // 
            // picBoxQuarterNote3
            // 
            this.picBoxQuarterNote3.BackColor = System.Drawing.Color.Black;
            this.picBoxQuarterNote3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuarterNote3.Location = new System.Drawing.Point(117, 109);
            this.picBoxQuarterNote3.Name = "picBoxQuarterNote3";
            this.picBoxQuarterNote3.Size = new System.Drawing.Size(48, 45);
            this.picBoxQuarterNote3.TabIndex = 9;
            this.picBoxQuarterNote3.TabStop = false;
            // 
            // picBoxQuarterNote2
            // 
            this.picBoxQuarterNote2.BackColor = System.Drawing.Color.Black;
            this.picBoxQuarterNote2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuarterNote2.Location = new System.Drawing.Point(63, 109);
            this.picBoxQuarterNote2.Name = "picBoxQuarterNote2";
            this.picBoxQuarterNote2.Size = new System.Drawing.Size(48, 45);
            this.picBoxQuarterNote2.TabIndex = 8;
            this.picBoxQuarterNote2.TabStop = false;
            // 
            // picBoxQuarterNote1
            // 
            this.picBoxQuarterNote1.BackColor = System.Drawing.Color.Black;
            this.picBoxQuarterNote1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuarterNote1.Location = new System.Drawing.Point(9, 109);
            this.picBoxQuarterNote1.Name = "picBoxQuarterNote1";
            this.picBoxQuarterNote1.Size = new System.Drawing.Size(48, 45);
            this.picBoxQuarterNote1.TabIndex = 7;
            this.picBoxQuarterNote1.TabStop = false;
            // 
            // numUpDownTempo
            // 
            this.numUpDownTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.numUpDownTempo.Location = new System.Drawing.Point(140, 17);
            this.numUpDownTempo.Name = "numUpDownTempo";
            this.numUpDownTempo.Size = new System.Drawing.Size(79, 32);
            this.numUpDownTempo.TabIndex = 6;
            this.numUpDownTempo.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numUpDownTempo.ValueChanged += new System.EventHandler(this.numUpDownTempo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(234, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "BPM";
            // 
            // labelDescTempo
            // 
            this.labelDescTempo.AutoSize = true;
            this.labelDescTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelDescTempo.Location = new System.Drawing.Point(6, 17);
            this.labelDescTempo.Name = "labelDescTempo";
            this.labelDescTempo.Size = new System.Drawing.Size(79, 26);
            this.labelDescTempo.TabIndex = 3;
            this.labelDescTempo.Text = "Tempo";
            // 
            // buttonMetronomePlay
            // 
            this.buttonMetronomePlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMetronomePlay.Location = new System.Drawing.Point(317, 6);
            this.buttonMetronomePlay.Name = "buttonMetronomePlay";
            this.buttonMetronomePlay.Size = new System.Drawing.Size(129, 43);
            this.buttonMetronomePlay.TabIndex = 1;
            this.buttonMetronomePlay.Text = "Play";
            this.buttonMetronomePlay.UseVisualStyleBackColor = true;
            this.buttonMetronomePlay.Click += new System.EventHandler(this.buttonMetronomePlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage2Notes
            // 
            this.tabPage2Notes.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Notes.Name = "tabPage2Notes";
            this.tabPage2Notes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Notes.Size = new System.Drawing.Size(452, 359);
            this.tabPage2Notes.TabIndex = 1;
            this.tabPage2Notes.Text = "    Notes";
            this.tabPage2Notes.UseVisualStyleBackColor = true;
            // 
            // tabPage3Recorder
            // 
            this.tabPage3Recorder.Controls.Add(this.groupBox1);
            this.tabPage3Recorder.Controls.Add(this.label4);
            this.tabPage3Recorder.Controls.Add(this.label3);
            this.tabPage3Recorder.Controls.Add(this.labelRecDevice);
            this.tabPage3Recorder.Controls.Add(this.btnRefreshSources);
            this.tabPage3Recorder.Controls.Add(this.listViewSources);
            this.tabPage3Recorder.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Recorder.Name = "tabPage3Recorder";
            this.tabPage3Recorder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Recorder.Size = new System.Drawing.Size(452, 359);
            this.tabPage3Recorder.TabIndex = 2;
            this.tabPage3Recorder.Text = "    Recorder";
            this.tabPage3Recorder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Input audio devices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Chosen device:";
            // 
            // labelRecDevice
            // 
            this.labelRecDevice.AutoSize = true;
            this.labelRecDevice.Location = new System.Drawing.Point(433, 54);
            this.labelRecDevice.Name = "labelRecDevice";
            this.labelRecDevice.Size = new System.Drawing.Size(13, 13);
            this.labelRecDevice.TabIndex = 26;
            this.labelRecDevice.Text = "0";
            // 
            // pictureBoxRecording
            // 
            this.pictureBoxRecording.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRecording.Location = new System.Drawing.Point(409, 14);
            this.pictureBoxRecording.Name = "pictureBoxRecording";
            this.pictureBoxRecording.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxRecording.TabIndex = 25;
            this.pictureBoxRecording.TabStop = false;
            // 
            // checkBoxPlayback
            // 
            this.checkBoxPlayback.AutoSize = true;
            this.checkBoxPlayback.Location = new System.Drawing.Point(327, 19);
            this.checkBoxPlayback.Name = "checkBoxPlayback";
            this.checkBoxPlayback.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPlayback.TabIndex = 24;
            this.checkBoxPlayback.Text = "playback";
            this.checkBoxPlayback.UseVisualStyleBackColor = true;
            // 
            // buttonToWave
            // 
            this.buttonToWave.Enabled = false;
            this.buttonToWave.Location = new System.Drawing.Point(327, 53);
            this.buttonToWave.Name = "buttonToWave";
            this.buttonToWave.Size = new System.Drawing.Size(110, 28);
            this.buttonToWave.TabIndex = 22;
            this.buttonToWave.Text = "Save To Wave";
            this.buttonToWave.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSources
            // 
            this.btnRefreshSources.Location = new System.Drawing.Point(336, 23);
            this.btnRefreshSources.Name = "btnRefreshSources";
            this.btnRefreshSources.Size = new System.Drawing.Size(110, 28);
            this.btnRefreshSources.TabIndex = 19;
            this.btnRefreshSources.Text = "Refresh";
            this.btnRefreshSources.UseVisualStyleBackColor = true;
            this.btnRefreshSources.Click += new System.EventHandler(this.btnRefreshSources_Click);
            // 
            // listViewSources
            // 
            this.listViewSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listViewSources.GridLines = true;
            this.listViewSources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSources.LabelWrap = false;
            this.listViewSources.Location = new System.Drawing.Point(3, 23);
            this.listViewSources.MultiSelect = false;
            this.listViewSources.Name = "listViewSources";
            this.listViewSources.Scrollable = false;
            this.listViewSources.ShowGroups = false;
            this.listViewSources.Size = new System.Drawing.Size(324, 81);
            this.listViewSources.TabIndex = 0;
            this.listViewSources.UseCompatibleStateImageBehavior = false;
            this.listViewSources.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 36;
            // 
            // buttonRecStop
            // 
            this.buttonRecStop.Location = new System.Drawing.Point(6, 53);
            this.buttonRecStop.Name = "buttonRecStop";
            this.buttonRecStop.Size = new System.Drawing.Size(110, 28);
            this.buttonRecStop.TabIndex = 21;
            this.buttonRecStop.Text = "Stop";
            this.buttonRecStop.UseVisualStyleBackColor = true;
            this.buttonRecStop.Click += new System.EventHandler(this.buttonRecStop_Click);
            // 
            // buttonRecStart
            // 
            this.buttonRecStart.Location = new System.Drawing.Point(6, 19);
            this.buttonRecStart.Name = "buttonRecStart";
            this.buttonRecStart.Size = new System.Drawing.Size(110, 28);
            this.buttonRecStart.TabIndex = 20;
            this.buttonRecStart.Text = "Start";
            this.buttonRecStart.UseVisualStyleBackColor = true;
            this.buttonRecStart.Click += new System.EventHandler(this.buttonRecStart_Click);
            // 
            // tabPageDrumkit
            // 
            this.tabPageDrumkit.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrumkit.Name = "tabPageDrumkit";
            this.tabPageDrumkit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrumkit.Size = new System.Drawing.Size(452, 359);
            this.tabPageDrumkit.TabIndex = 3;
            this.tabPageDrumkit.Text = "    Drumkit";
            this.tabPageDrumkit.UseVisualStyleBackColor = true;
            // 
            // tabPageExercises
            // 
            this.tabPageExercises.Location = new System.Drawing.Point(4, 22);
            this.tabPageExercises.Name = "tabPageExercises";
            this.tabPageExercises.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExercises.Size = new System.Drawing.Size(452, 359);
            this.tabPageExercises.TabIndex = 4;
            this.tabPageExercises.Text = "    Exercises";
            this.tabPageExercises.UseVisualStyleBackColor = true;
            // 
            // tabPageTuner
            // 
            this.tabPageTuner.Controls.Add(this.pictureBox1);
            this.tabPageTuner.Location = new System.Drawing.Point(4, 22);
            this.tabPageTuner.Name = "tabPageTuner";
            this.tabPageTuner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTuner.Size = new System.Drawing.Size(452, 359);
            this.tabPageTuner.TabIndex = 5;
            this.tabPageTuner.Text = "    Tuner";
            this.tabPageTuner.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(12, 403);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(397, 403);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // labelRecordingTime
            // 
            this.labelRecordingTime.AutoSize = true;
            this.labelRecordingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecordingTime.Location = new System.Drawing.Point(179, 38);
            this.labelRecordingTime.Name = "labelRecordingTime";
            this.labelRecordingTime.Size = new System.Drawing.Size(85, 16);
            this.labelRecordingTime.TabIndex = 29;
            this.labelRecordingTime.Text = "Time: 0:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRecStart);
            this.groupBox1.Controls.Add(this.labelRecordingTime);
            this.groupBox1.Controls.Add(this.buttonRecStop);
            this.groupBox1.Controls.Add(this.checkBoxPlayback);
            this.groupBox1.Controls.Add(this.pictureBoxRecording);
            this.groupBox1.Controls.Add(this.buttonToWave);
            this.groupBox1.Location = new System.Drawing.Point(3, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 89);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Recording";
            // 
            // MainKBOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainKBOForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kick Bass Ass Out!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1Metronome.ResumeLayout(false);
            this.tabPage1Metronome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuarterNote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTempo)).EndInit();
            this.tabPage3Recorder.ResumeLayout(false);
            this.tabPage3Recorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecording)).EndInit();
            this.tabPageTuner.ResumeLayout(false);
            this.tabPageTuner.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1Metronome;
        private System.Windows.Forms.Label labelDescTempo;
        private System.Windows.Forms.Button buttonMetronomePlay;
        private System.Windows.Forms.TabPage tabPage2Notes;
        private System.Windows.Forms.TabPage tabPage3Recorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownTempo;
        private System.Windows.Forms.PictureBox picBoxQuarterNote4;
        private System.Windows.Forms.PictureBox picBoxQuarterNote3;
        private System.Windows.Forms.PictureBox picBoxQuarterNote2;
        private System.Windows.Forms.PictureBox picBoxQuarterNote1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentBeat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonRecStop;
        private System.Windows.Forms.Button buttonRecStart;
        private System.Windows.Forms.Button btnRefreshSources;
        private System.Windows.Forms.ListView listViewSources;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonToWave;
        private System.Windows.Forms.CheckBox checkBoxPlayback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRecDevice;
        private System.Windows.Forms.PictureBox pictureBoxRecording;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPageDrumkit;
        private System.Windows.Forms.TabPage tabPageExercises;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.TrackBar trackBarTempo;
        private System.Windows.Forms.TabPage tabPageTuner;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelRecordingTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

