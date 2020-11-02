using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
	public partial class FormRandom1 : Form
	{
		List<Bitmap> PictureList = new List<Bitmap>();
		int NullIndex = 0;
		private int count = 0;

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
		public FormRandom1()
		{
			InitializeComponent();
			PictureList.AddRange(new Bitmap[] {
				Properties.Resources.one,
				Properties.Resources.two,
				Properties.Resources.three,
				Properties.Resources.four,
				Properties.Resources.five,
				Properties.Resources.six,
				Properties.Resources.seven,
				Properties.Resources.eight,
				Properties.Resources.null2,
				Properties.Resources.null1
			});
			btnreset.Click += click;
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}
		private void FormEasy1_Load(object sender, EventArgs e)
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
				this.Close();
			}
		}
		void Shuffle()
		{
			do {
				int j;
				List<int> Indexes = new List<int>(new int[] {
					0,1,2,3,4,5,6,7,9
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
			YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Puzzlenian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (YesOrNo == DialogResult.Yes) {
				Shuffle();
			}
		}
		private void SwitchPictureBox(object sender, EventArgs e)
		{
			int inPictureBoxIndex = PuzzleBox.Controls.IndexOf(sender as Control);
			if (NullIndex != inPictureBoxIndex) {
				List<int> FourBrothers = new List<int>(new int[] {
					((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1),
					inPictureBoxIndex - 3,
					(inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1,
					inPictureBoxIndex + 3
				});
				if (FourBrothers.Contains(NullIndex)) {
					((PictureBox)PuzzleBox.Controls[NullIndex]).Image = ((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image;
					((PictureBox)PuzzleBox.Controls[inPictureBoxIndex]).Image = PictureList[9];
					NullIndex = inPictureBoxIndex;
					if (CheckWin()) {
						(PuzzleBox.Controls[8] as PictureBox).Image = PictureList[8];
						Shuffle();
						MessageBox.Show("Procced to next level" +
                            "\nNOTE: The next level are not similar from previous" +
                            "\nYou need to find all possible word to complete.", "Congratulations...");
							MessageBox.Show("You have only TEN MINUTES to Finished this stage!" +
							"\nNOTE: You only 30 times to shuffle the puzzle", "NOTE:");
							FormRandom ran = new FormRandom();
                            ran.Owner = this;
							ran.Show(this);
                            (this.Owner as MainForm).btnhidden.Enabled = true;
                            (this.Owner as MainForm).label3.Visible = false;
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
			if (YesOrNo == DialogResult.Yes) {
                this.Close();
			}
		}
    }
}
