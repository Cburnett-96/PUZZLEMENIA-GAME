﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class FormBossPic : Form
    {
        List<Bitmap> PictureList = new List<Bitmap>();
        int NullIndex = 0 ;
        private int count = 0;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        public FormBossPic()
        {
            InitializeComponent();
            PictureList.AddRange(new Bitmap[] {
                Properties.Resources.row_1_col_1,
                Properties.Resources.row_1_col_2,
                Properties.Resources.row_1_col_3,
                Properties.Resources.row_1_col_4,
                Properties.Resources.row_2_col_1,
                Properties.Resources.row_2_col_2,
                Properties.Resources.row_2_col_3,
                Properties.Resources.row_2_col_4,
                Properties.Resources.row_3_col_1,
                Properties.Resources.row_3_col_2,
                Properties.Resources.row_3_col_3,
                Properties.Resources.row_3_col_4,
                Properties.Resources.row_4_col_1,
                Properties.Resources.row_4_col_2,
                Properties.Resources.row_4_col_3,
                Properties.Resources.row_4_col_4,
                Properties.Resources.null2
            });
            lblTimeElapsed.Text = "00:00:00";
            btnreset.Click += click;
             this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }
        private void FormMed1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
        private void click(Object sender, EventArgs e)
        {
            count++;
            if (count > 5)
            {
                btnreset.Click -= click;
                count = 0;
                MessageBox.Show("Only 5 shuffle allow to reset!");
                this.Close();
            }
        }
        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] {
                    0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,16
                });//15 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 16; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)PuzzleBox.Controls[i]).Image = PictureList[j];
                    if (j == 16)
                        NullIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Puzzlemenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                
            }
        }
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = PuzzleBox.Controls.IndexOf(sender as Control);
            if (NullIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] {
                   ((inPictureBoxIndex % 4 == 0) ? -1 : inPictureBoxIndex - 1),
					inPictureBoxIndex - 4,
					(inPictureBoxIndex % 4 == 3) ? -1 : inPictureBoxIndex + 1,
					inPictureBoxIndex + 4
                });
                if (FourBrothers.Contains(NullIndex))
                {
                    ((PictureBox)PuzzleBox.Controls[NullIndex]).Image = ((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image = PictureList[16];
                    NullIndex = inPictureBoxIndex;
                    if (CheckWin())
                    {
                        timer.Stop();
                        (PuzzleBox.Controls[15] as PictureBox).Image = PictureList[15];
                        MessageBox.Show("Congratulations...\nTime Elapsed : " + timer.Elapsed.ToString().Remove(15));
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                        DialogResult YesOrNo = new DialogResult();
                        YesOrNo = MessageBox.Show("Procced to next level?" +
                            "\nTo Close another door", "Congratulations...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (YesOrNo == DialogResult.Yes)
                        {
                            (this.Owner as Boss).pbxImage1.Visible = false;
                            this.Close();
                        }
                    }
                }
            }
        }
        bool CheckWin()
        {
            int i;
            
            for (i = 0; i < 15; i++)
            {
                if ((PuzzleBox.Controls[i] as PictureBox).Image != PictureList[i])
                    break;
            }
            if (i == 15)
                return true;
            else
                return false;
        }
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnpause.Enabled = false;
            else
                btnpause.Enabled = true;

                if (timer.Elapsed.Minutes.ToString() == "10")
                {
                    timer.Reset();
                    lblTimeElapsed.Text = "00:00:00";
                    btnpause.Enabled = false;
                    MessageBox.Show("Time Is Up\nTry Again", "Puzzlemenia Game");
                    this.Close();
            }
        }
        private void btnpause_Click(object sender, EventArgs e)
        {
            if (btnpause.Text == "Pause")
            {
                timer.Stop();
                PuzzleBox.Visible = false;
                btnpause.Text = "Resume";
            }
            else
            {
                timer.Start();
                PuzzleBox.Visible = true;
                btnpause.Text = "Pause";
            }
        }
        void ExitClick(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to Exit?\nYou loss the opportunity to save the game", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (YesOrNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void btnbackClick(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to exit?", "Are you sure to exit?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
