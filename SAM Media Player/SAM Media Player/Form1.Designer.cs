namespace SAM_Media_Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.bdumbchk = new System.Windows.Forms.CheckBox();
            this.Tpmst = new System.Windows.Forms.CheckBox();
            this.SP = new System.Windows.Forms.PictureBox();
            this.Openfile = new System.Windows.Forms.PictureBox();
            this.Closethis = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.VolumeAdj = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ply = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Openfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeAdj)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ply)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            this.Open.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_FileOk);
            // 
            // bdumbchk
            // 
            this.bdumbchk.AutoSize = true;
            this.bdumbchk.BackColor = System.Drawing.Color.Transparent;
            this.bdumbchk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bdumbchk.Checked = true;
            this.bdumbchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bdumbchk.Location = new System.Drawing.Point(123, 51);
            this.bdumbchk.Name = "bdumbchk";
            this.bdumbchk.Size = new System.Drawing.Size(15, 14);
            this.bdumbchk.TabIndex = 117;
            this.bdumbchk.UseVisualStyleBackColor = false;
            this.bdumbchk.Visible = false;
            this.bdumbchk.CheckedChanged += new System.EventHandler(this.bdumbchk_CheckedChanged);
            // 
            // Tpmst
            // 
            this.Tpmst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tpmst.AutoSize = true;
            this.Tpmst.BackColor = System.Drawing.Color.Transparent;
            this.Tpmst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpmst.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tpmst.Location = new System.Drawing.Point(173, 342);
            this.Tpmst.Name = "Tpmst";
            this.Tpmst.Size = new System.Drawing.Size(85, 17);
            this.Tpmst.TabIndex = 287;
            this.Tpmst.Text = "Topmost ?";
            this.Tpmst.UseVisualStyleBackColor = false;
            this.Tpmst.CheckedChanged += new System.EventHandler(this.Tpmst_CheckedChanged);
            // 
            // SP
            // 
            this.SP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconC;
            this.SP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SP.Location = new System.Drawing.Point(283, 8);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(30, 30);
            this.SP.TabIndex = 116;
            this.SP.TabStop = false;
            this.SP.Click += new System.EventHandler(this.SP_Click);
            this.SP.MouseEnter += new System.EventHandler(this.SP_MouseEnter);
            this.SP.MouseLeave += new System.EventHandler(this.SP_MouseLeave);
            // 
            // Openfile
            // 
            this.Openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Openfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Openfile.BackgroundImage = global::SAM_Media_Player.Properties.Resources.folderC;
            this.Openfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Openfile.Location = new System.Drawing.Point(247, 8);
            this.Openfile.Name = "Openfile";
            this.Openfile.Size = new System.Drawing.Size(30, 30);
            this.Openfile.TabIndex = 1;
            this.Openfile.TabStop = false;
            this.Openfile.Click += new System.EventHandler(this.Openfile_Click);
            this.Openfile.MouseEnter += new System.EventHandler(this.Openfile_MouseEnter);
            this.Openfile.MouseLeave += new System.EventHandler(this.Openfile_MouseLeave);
            // 
            // Closethis
            // 
            this.Closethis.BackColor = System.Drawing.Color.Transparent;
            this.Closethis.BackgroundImage = global::SAM_Media_Player.Properties.Resources.close_icon;
            this.Closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closethis.Location = new System.Drawing.Point(340, 51);
            this.Closethis.Name = "Closethis";
            this.Closethis.Size = new System.Drawing.Size(22, 22);
            this.Closethis.TabIndex = 288;
            this.Closethis.TabStop = false;
            this.Closethis.Click += new System.EventHandler(this.Closethis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Previous);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Openfile);
            this.panel1.Controls.Add(this.SP);
            this.panel1.Controls.Add(this.Pause);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 46);
            this.panel1.TabIndex = 293;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SRC;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next.Location = new System.Drawing.Point(196, 8);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(31, 30);
            this.Next.TabIndex = 293;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseEnter += new System.EventHandler(this.Next_MouseEnter);
            this.Next.MouseLeave += new System.EventHandler(this.Next_MouseLeave);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SLC;
            this.Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previous.Location = new System.Drawing.Point(159, 8);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(31, 30);
            this.Previous.TabIndex = 294;
            this.Previous.TabStop = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            this.Previous.MouseEnter += new System.EventHandler(this.Previous_MouseEnter);
            this.Previous.MouseLeave += new System.EventHandler(this.Previous_MouseLeave);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PlayC;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play.Location = new System.Drawing.Point(3, 1);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(42, 42);
            this.Play.TabIndex = 293;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            this.Play.MouseEnter += new System.EventHandler(this.Play_MouseEnter);
            this.Play.MouseLeave += new System.EventHandler(this.Play_MouseLeave);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PauseC;
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pause.Location = new System.Drawing.Point(54, 1);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(42, 42);
            this.Pause.TabIndex = 292;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            this.Pause.MouseEnter += new System.EventHandler(this.Pause_MouseEnter);
            this.Pause.MouseLeave += new System.EventHandler(this.Pause_MouseLeave);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BackgroundImage = global::SAM_Media_Player.Properties.Resources.StopC;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop.Location = new System.Drawing.Point(102, 1);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(42, 42);
            this.Stop.TabIndex = 291;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            this.Stop.MouseEnter += new System.EventHandler(this.Stop_MouseEnter);
            this.Stop.MouseLeave += new System.EventHandler(this.Stop_MouseLeave);
            // 
            // VolumeAdj
            // 
            this.VolumeAdj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VolumeAdj.Location = new System.Drawing.Point(280, 0);
            this.VolumeAdj.Name = "VolumeAdj";
            this.VolumeAdj.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeAdj.Size = new System.Drawing.Size(45, 104);
            this.VolumeAdj.TabIndex = 294;
            this.VolumeAdj.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeAdj.Value = 10;
            this.VolumeAdj.Scroll += new System.EventHandler(this.VolumeAdj_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.VolumeAdj);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.ply);
            this.panel2.Location = new System.Drawing.Point(42, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 256);
            this.panel2.TabIndex = 302;
            // 
            // ply
            // 
            this.ply.Enabled = true;
            this.ply.Location = new System.Drawing.Point(0, 0);
            this.ply.Name = "ply";
            this.ply.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ply.OcxState")));
            this.ply.Size = new System.Drawing.Size(327, 256);
            this.ply.TabIndex = 303;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PlayerWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(395, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tpmst);
            this.Controls.Add(this.Closethis);
            this.Controls.Add(this.bdumbchk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "SAM.Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Openfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeAdj)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.PictureBox Openfile;
        private System.Windows.Forms.PictureBox SP;
        private System.Windows.Forms.CheckBox bdumbchk;
        private System.Windows.Forms.CheckBox Tpmst;
        private System.Windows.Forms.PictureBox Closethis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Previous;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.TrackBar VolumeAdj;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer ply;
    }

}


