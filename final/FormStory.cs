using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
	public partial class FormStory : Form
	{
		List<Bitmap> PictureList = new List<Bitmap>();
		int NullIndex = 0;
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
        public FormStory()
		{
			InitializeComponent();
			PictureList.AddRange(new Bitmap[] {
				Properties.Resources.b1_1,
				Properties.Resources.b1_2,
				Properties.Resources.b1_3,
				Properties.Resources.b2_1,
				Properties.Resources.b2_2,
				Properties.Resources.b2_3,
				Properties.Resources.b3_1,
				Properties.Resources.b3_2,
				Properties.Resources.b3_3,
				Properties.Resources._null
			});
			lblTimeElapsed.Text = "00:00:00";
			btnreset.Click += click;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
		private void FormEasy_Load(object sender, EventArgs e)
		{
			Shuffle();
        }
		private void click(Object sender, EventArgs e)
		{
			count++;
			if (count > 5) {
				btnreset.Click -= click;
				count = 0;
				MessageBox.Show("Only 5 shuffle allow to reset!");
                Story st = new Story();
                st.Show();
                this.Close();
			}
		}
		void Shuffle()
		{
			do {
				int j;
				List<int> Indexes = new List<int>(new int[] {
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					9
				});//8 is not present - since it is the last slice.
				Random r = new Random();
				for (int i = 0; i < 9; i++) {
					Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
					((PictureBox)PuzzleBox.Controls[i]).Image = PictureList[j];
					if (j == 9)
						NullIndex = i;//store empty picture box index
				}
			} while (CheckWin());
		}
		private void btnreset_Click(object sender, EventArgs e)
		{
			DialogResult YesOrNo = new DialogResult();
			if (lblTimeElapsed.Text != "00:00:00") {
				YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Puzzlenian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00") {
				Shuffle();
				timer.Reset();
				lblTimeElapsed.Text = "00:00:00";
				
			}
		}
		private void SwitchPictureBox(object sender, EventArgs e)
		{
            pictureBox1.Visible = false;
            if (lblTimeElapsed.Text == "00:00:00")
				timer.Start();
			int inPictureBoxIndex = PuzzleBox.Controls.IndexOf(sender as Control);
			if (NullIndex != inPictureBoxIndex) {
				List<int> mixs = new List<int>(new int[] {
					((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1),
					inPictureBoxIndex - 3,
					(inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1,
					inPictureBoxIndex + 3
				});
				if (mixs.Contains(NullIndex)) {
					((PictureBox)PuzzleBox.Controls[NullIndex]).Image = ((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image;
					((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image = PictureList[9];
					NullIndex = inPictureBoxIndex;
					if (CheckWin()) {
						timer.Stop();
						(PuzzleBox.Controls[8] as PictureBox).Image = PictureList[8];
						MessageBox.Show("Congratulations...\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8));
						lblTimeElapsed.Text = "00:00:00";
						timer.Reset();
						Shuffle();
                        StoryAns stans = new StoryAns();
                        stans.Owner = this;
                        stans.Show(this);
                        this.Hide();
                    }
				}
			}
		}
		bool CheckWin()
		{
			int i;
			for (i = 0; i < 8; i++) {
				if ((PuzzleBox.Controls[i] as PictureBox).Image != PictureList[i])
					break;
			}
			if (i == 8)
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
			if (timer.Elapsed.Minutes.ToString() == "3") {
				timer.Reset();
				lblTimeElapsed.Text = "00:00:00";
				btnpause.Enabled = false;
				MessageBox.Show("Time Is Up\nTry Again");
                Story st = new Story();
                st.Show();
                this.Close();
            }
		}
		private void btnpause_Click(object sender, EventArgs e)
		{
			if (btnpause.Text == "Pause") {
				timer.Stop();
				PuzzleBox.Visible = false;
				btnpause.Text = "Resume";
			} else {
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
            YesOrNo = MessageBox.Show("Do you want to exit?","Are you sure to exit?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                Story st = new Story();
                st.Show();
                
            }
		}

        private void label4_Click(object sender, EventArgs e)
        {
                pictureBox1.Visible = true;
        }
    }
}
