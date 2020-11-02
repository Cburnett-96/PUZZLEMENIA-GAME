/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 20/11/2019
 * Time: 8:23 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final
{
	partial class FormRandom
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label exit;
		private System.Windows.Forms.GroupBox PuzzleBox;
		private System.Windows.Forms.PictureBox pbx1;
		private System.Windows.Forms.PictureBox pbx2;
		private System.Windows.Forms.PictureBox pbx3;
		private System.Windows.Forms.PictureBox pbx4;
		private System.Windows.Forms.PictureBox pbx5;
		private System.Windows.Forms.PictureBox pbx6;
		private System.Windows.Forms.PictureBox pbx7;
		private System.Windows.Forms.PictureBox pbx8;
		private System.Windows.Forms.PictureBox pbx9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnback;
		private System.Windows.Forms.Button btnpause;
		private System.Windows.Forms.Button btnshuffle;
		private System.Windows.Forms.Label lblTimeElapsed;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandom));
            this.exit = new System.Windows.Forms.Label();
            this.PuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnshuffle = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tboxletter = new System.Windows.Forms.TextBox();
            this.btnguess = new System.Windows.Forms.Button();
            this.listans = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 24);
            this.exit.TabIndex = 7;
            this.exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // PuzzleBox
            // 
            this.PuzzleBox.BackColor = System.Drawing.Color.Transparent;
            this.PuzzleBox.Controls.Add(this.pbx1);
            this.PuzzleBox.Controls.Add(this.pbx2);
            this.PuzzleBox.Controls.Add(this.pbx3);
            this.PuzzleBox.Controls.Add(this.pbx4);
            this.PuzzleBox.Controls.Add(this.pbx5);
            this.PuzzleBox.Controls.Add(this.pbx6);
            this.PuzzleBox.Controls.Add(this.pbx7);
            this.PuzzleBox.Controls.Add(this.pbx8);
            this.PuzzleBox.Controls.Add(this.pbx9);
            this.PuzzleBox.Location = new System.Drawing.Point(35, 45);
            this.PuzzleBox.Name = "PuzzleBox";
            this.PuzzleBox.Size = new System.Drawing.Size(329, 335);
            this.PuzzleBox.TabIndex = 9;
            this.PuzzleBox.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(6, 14);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 100);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(112, 14);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 100);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(218, 14);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 100);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(6, 120);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 100);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(112, 120);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(100, 100);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(218, 120);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(100, 100);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(6, 226);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(100, 100);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(112, 226);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(100, 100);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(218, 226);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(100, 100);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "GYYHIOLPN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(253, 403);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(97, 44);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnbackClick);
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.Color.Transparent;
            this.btnpause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpause.BackgroundImage")));
            this.btnpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpause.FlatAppearance.BorderSize = 0;
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.Location = new System.Drawing.Point(151, 403);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(97, 44);
            this.btnpause.TabIndex = 21;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnshuffle
            // 
            this.btnshuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnshuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshuffle.BackgroundImage")));
            this.btnshuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshuffle.FlatAppearance.BorderSize = 0;
            this.btnshuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshuffle.Location = new System.Drawing.Point(45, 403);
            this.btnshuffle.Name = "btnshuffle";
            this.btnshuffle.Size = new System.Drawing.Size(97, 44);
            this.btnshuffle.TabIndex = 20;
            this.btnshuffle.Text = "Shuffle";
            this.btnshuffle.UseVisualStyleBackColor = false;
            this.btnshuffle.Click += new System.EventHandler(this.btnshuffle_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(471, 395);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(147, 43);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // tboxletter
            // 
            this.tboxletter.Location = new System.Drawing.Point(453, 88);
            this.tboxletter.MaxLength = 9;
            this.tboxletter.Name = "tboxletter";
            this.tboxletter.Size = new System.Drawing.Size(190, 20);
            this.tboxletter.TabIndex = 24;
            // 
            // btnguess
            // 
            this.btnguess.BackColor = System.Drawing.Color.Transparent;
            this.btnguess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguess.BackgroundImage")));
            this.btnguess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguess.FlatAppearance.BorderSize = 0;
            this.btnguess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguess.Location = new System.Drawing.Point(494, 114);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(97, 44);
            this.btnguess.TabIndex = 25;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = false;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // listans
            // 
            this.listans.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listans.FormattingEnabled = true;
            this.listans.ItemHeight = 16;
            this.listans.Location = new System.Drawing.Point(470, 164);
            this.listans.Name = "listans";
            this.listans.Size = new System.Drawing.Size(148, 228);
            this.listans.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(636, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 28;
            this.toolTip1.SetToolTip(this.label3, "Find All Possible Word.\r\nYou have time limit to finish this stage.\r\nYou need atle" +
        "ast 20 words to complete this stage.");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(86, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 29;
            this.toolTip1.SetToolTip(this.label2, "You need atleast 10 words to enable.");
            this.label2.Visible = false;
            // 
            // FormRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listans);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.tboxletter);
            this.Controls.Add(this.PuzzleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnshuffle);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMed";
            this.Load += new System.EventHandler(this.FormMed_Load);
            this.PuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tboxletter;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.ListBox listans;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label label2;
    }
}
