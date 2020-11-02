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
    partial class FormBossPic
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.GroupBox PuzzleBox;
        private System.Windows.Forms.PictureBox pbx12;
        private System.Windows.Forms.PictureBox pbx05;
        private System.Windows.Forms.PictureBox pbx06;
        private System.Windows.Forms.PictureBox pbx07;
        private System.Windows.Forms.PictureBox pbx08;
        private System.Windows.Forms.PictureBox pbx01;
        private System.Windows.Forms.PictureBox pbx02;
        private System.Windows.Forms.PictureBox pbx03;
        private System.Windows.Forms.PictureBox pbx04;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lblTimeElapsed;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBossPic));
            this.exit = new System.Windows.Forms.Label();
            this.PuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx01 = new System.Windows.Forms.PictureBox();
            this.pbx02 = new System.Windows.Forms.PictureBox();
            this.pbx03 = new System.Windows.Forms.PictureBox();
            this.pbx04 = new System.Windows.Forms.PictureBox();
            this.pbx05 = new System.Windows.Forms.PictureBox();
            this.pbx06 = new System.Windows.Forms.PictureBox();
            this.pbx07 = new System.Windows.Forms.PictureBox();
            this.pbx08 = new System.Windows.Forms.PictureBox();
            this.pbx09 = new System.Windows.Forms.PictureBox();
            this.pbx10 = new System.Windows.Forms.PictureBox();
            this.pbx11 = new System.Windows.Forms.PictureBox();
            this.pbx12 = new System.Windows.Forms.PictureBox();
            this.pbx13 = new System.Windows.Forms.PictureBox();
            this.pbx14 = new System.Windows.Forms.PictureBox();
            this.pbx15 = new System.Windows.Forms.PictureBox();
            this.pbx16 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PuzzleBox.Controls.Add(this.pbx01);
            this.PuzzleBox.Controls.Add(this.pbx02);
            this.PuzzleBox.Controls.Add(this.pbx03);
            this.PuzzleBox.Controls.Add(this.pbx04);
            this.PuzzleBox.Controls.Add(this.pbx05);
            this.PuzzleBox.Controls.Add(this.pbx06);
            this.PuzzleBox.Controls.Add(this.pbx07);
            this.PuzzleBox.Controls.Add(this.pbx08);
            this.PuzzleBox.Controls.Add(this.pbx09);
            this.PuzzleBox.Controls.Add(this.pbx10);
            this.PuzzleBox.Controls.Add(this.pbx11);
            this.PuzzleBox.Controls.Add(this.pbx12);
            this.PuzzleBox.Controls.Add(this.pbx13);
            this.PuzzleBox.Controls.Add(this.pbx14);
            this.PuzzleBox.Controls.Add(this.pbx15);
            this.PuzzleBox.Controls.Add(this.pbx16);
            this.PuzzleBox.Location = new System.Drawing.Point(28, 41);
            this.PuzzleBox.Name = "PuzzleBox";
            this.PuzzleBox.Size = new System.Drawing.Size(558, 560);
            this.PuzzleBox.TabIndex = 9;
            this.PuzzleBox.TabStop = false;
            // 
            // pbx01
            // 
            this.pbx01.InitialImage = global::final.Properties.Resources.row_1_col_1;
            this.pbx01.Location = new System.Drawing.Point(17, 23);
            this.pbx01.Name = "pbx01";
            this.pbx01.Size = new System.Drawing.Size(130, 130);
            this.pbx01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx01.TabIndex = 0;
            this.pbx01.TabStop = false;
            this.pbx01.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx02
            // 
            this.pbx02.InitialImage = global::final.Properties.Resources.row_1_col_2;
            this.pbx02.Location = new System.Drawing.Point(148, 23);
            this.pbx02.Name = "pbx02";
            this.pbx02.Size = new System.Drawing.Size(130, 130);
            this.pbx02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx02.TabIndex = 0;
            this.pbx02.TabStop = false;
            this.pbx02.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx03
            // 
            this.pbx03.InitialImage = global::final.Properties.Resources.row_1_col_3;
            this.pbx03.Location = new System.Drawing.Point(279, 23);
            this.pbx03.Name = "pbx03";
            this.pbx03.Size = new System.Drawing.Size(130, 130);
            this.pbx03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx03.TabIndex = 0;
            this.pbx03.TabStop = false;
            this.pbx03.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx04
            // 
            this.pbx04.InitialImage = global::final.Properties.Resources.row_1_col_4;
            this.pbx04.Location = new System.Drawing.Point(410, 23);
            this.pbx04.Name = "pbx04";
            this.pbx04.Size = new System.Drawing.Size(130, 130);
            this.pbx04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx04.TabIndex = 0;
            this.pbx04.TabStop = false;
            this.pbx04.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx05
            // 
            this.pbx05.InitialImage = global::final.Properties.Resources.row_2_col_1;
            this.pbx05.Location = new System.Drawing.Point(17, 154);
            this.pbx05.Name = "pbx05";
            this.pbx05.Size = new System.Drawing.Size(130, 130);
            this.pbx05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx05.TabIndex = 0;
            this.pbx05.TabStop = false;
            this.pbx05.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx06
            // 
            this.pbx06.InitialImage = global::final.Properties.Resources.row_2_col_2;
            this.pbx06.Location = new System.Drawing.Point(148, 154);
            this.pbx06.Name = "pbx06";
            this.pbx06.Size = new System.Drawing.Size(130, 130);
            this.pbx06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx06.TabIndex = 0;
            this.pbx06.TabStop = false;
            this.pbx06.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx07
            // 
            this.pbx07.InitialImage = global::final.Properties.Resources.row_2_col_3;
            this.pbx07.Location = new System.Drawing.Point(279, 154);
            this.pbx07.Name = "pbx07";
            this.pbx07.Size = new System.Drawing.Size(130, 130);
            this.pbx07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx07.TabIndex = 0;
            this.pbx07.TabStop = false;
            this.pbx07.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx08
            // 
            this.pbx08.InitialImage = global::final.Properties.Resources.row_2_col_4;
            this.pbx08.Location = new System.Drawing.Point(410, 154);
            this.pbx08.Name = "pbx08";
            this.pbx08.Size = new System.Drawing.Size(130, 130);
            this.pbx08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx08.TabIndex = 0;
            this.pbx08.TabStop = false;
            this.pbx08.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx09
            // 
            this.pbx09.InitialImage = global::final.Properties.Resources.row_3_col_1;
            this.pbx09.Location = new System.Drawing.Point(17, 285);
            this.pbx09.Name = "pbx09";
            this.pbx09.Size = new System.Drawing.Size(130, 130);
            this.pbx09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx09.TabIndex = 3;
            this.pbx09.TabStop = false;
            this.pbx09.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx10
            // 
            this.pbx10.InitialImage = global::final.Properties.Resources.row_3_col_2;
            this.pbx10.Location = new System.Drawing.Point(148, 285);
            this.pbx10.Name = "pbx10";
            this.pbx10.Size = new System.Drawing.Size(130, 130);
            this.pbx10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx10.TabIndex = 2;
            this.pbx10.TabStop = false;
            this.pbx10.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx11
            // 
            this.pbx11.InitialImage = global::final.Properties.Resources.row_3_col_3;
            this.pbx11.Location = new System.Drawing.Point(279, 285);
            this.pbx11.Name = "pbx11";
            this.pbx11.Size = new System.Drawing.Size(130, 130);
            this.pbx11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx11.TabIndex = 1;
            this.pbx11.TabStop = false;
            this.pbx11.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx12
            // 
            this.pbx12.InitialImage = global::final.Properties.Resources.row_3_col_4;
            this.pbx12.Location = new System.Drawing.Point(410, 285);
            this.pbx12.Name = "pbx12";
            this.pbx12.Size = new System.Drawing.Size(130, 130);
            this.pbx12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx12.TabIndex = 0;
            this.pbx12.TabStop = false;
            this.pbx12.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx13
            // 
            this.pbx13.InitialImage = global::final.Properties.Resources.row_4_col_1;
            this.pbx13.Location = new System.Drawing.Point(17, 416);
            this.pbx13.Name = "pbx13";
            this.pbx13.Size = new System.Drawing.Size(130, 130);
            this.pbx13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx13.TabIndex = 7;
            this.pbx13.TabStop = false;
            this.pbx13.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx14
            // 
            this.pbx14.InitialImage = global::final.Properties.Resources.row_4_col_2;
            this.pbx14.Location = new System.Drawing.Point(148, 416);
            this.pbx14.Name = "pbx14";
            this.pbx14.Size = new System.Drawing.Size(130, 130);
            this.pbx14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx14.TabIndex = 6;
            this.pbx14.TabStop = false;
            this.pbx14.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx15
            // 
            this.pbx15.InitialImage = global::final.Properties.Resources.row_4_col_3;
            this.pbx15.Location = new System.Drawing.Point(279, 416);
            this.pbx15.Name = "pbx15";
            this.pbx15.Size = new System.Drawing.Size(130, 130);
            this.pbx15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx15.TabIndex = 5;
            this.pbx15.TabStop = false;
            this.pbx15.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx16
            // 
            this.pbx16.InitialImage = global::final.Properties.Resources.row_4_col_4;
            this.pbx16.Location = new System.Drawing.Point(410, 416);
            this.pbx16.Name = "pbx16";
            this.pbx16.Size = new System.Drawing.Size(130, 130);
            this.pbx16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx16.TabIndex = 4;
            this.pbx16.TabStop = false;
            this.pbx16.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "GOAL STATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(812, 444);
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
            this.btnpause.Location = new System.Drawing.Point(709, 444);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(97, 44);
            this.btnpause.TabIndex = 21;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Transparent;
            this.btnreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreset.BackgroundImage")));
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(606, 444);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(97, 44);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.ForeColor = System.Drawing.Color.White;
            this.lblTimeElapsed.Location = new System.Drawing.Point(701, 370);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(628, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormBossPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PuzzleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBossPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMed";
            this.Load += new System.EventHandler(this.FormMed1_Load);
            this.PuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbx13;
        private System.Windows.Forms.PictureBox pbx14;
        private System.Windows.Forms.PictureBox pbx15;
        private System.Windows.Forms.PictureBox pbx16;
        private System.Windows.Forms.PictureBox pbx09;
        private System.Windows.Forms.PictureBox pbx10;
        private System.Windows.Forms.PictureBox pbx11;
    }
}
