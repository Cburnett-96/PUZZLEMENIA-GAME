using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class FormRandom : Form
    {
        List<Bitmap> PictureList = new List<Bitmap>();
        public ArrayList al;
        private int count = 0;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        //Curved Edgeds
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
        public FormRandom()
        {
            InitializeComponent();
            PictureList.AddRange(new Bitmap[] {
                Properties.Resources.g,
                Properties.Resources.h,
                Properties.Resources.i,
                Properties.Resources.l,
                Properties.Resources.n,
                Properties.Resources.y,
                Properties.Resources.y1,
                Properties.Resources.o,
                Properties.Resources.p
            });
            //All correct answers
            al = new ArrayList();
            al.Add("holing");
            al.Add("hoping");
            al.Add("hyping");
            al.Add("loping");
            al.Add("plying");
            al.Add("poling");
            al.Add("gipon");
            al.Add("hying");
            al.Add("lingo");
            al.Add("login");
            al.Add("lying");
            al.Add("oping");
            al.Add("yogin");
            al.Add("only");
            al.Add("oily");
            al.Add("liny");
            al.Add("lion");
            al.Add("loin");
            al.Add("nigh");
            al.Add("noil");
            al.Add("oily");
            al.Add("pig");
            al.Add("ping");
            al.Add("piny");
            al.Add("lop");
            al.Add("log");
            al.Add("hop");
            al.Add("gin");
            al.Add("hog");
            al.Add("go");
            al.Add("in");
            al.Add("no");
            al.Add("on");

            lblTimeElapsed.Text = "00:00:00";
            btnshuffle.Click += click;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void FormMed_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
        private void click(Object sender, EventArgs e)
        {
            count++;
                if (count >= 20)
                {
                    btnshuffle.Click -= click;
                    count = 0;
                MessageBox.Show("You Have Only 20 times to Shuffle if greater than " +
                "\n your game have been reset from start",
                "PUZZLEMENIA");
                timer.Reset();
                    lblTimeElapsed.Text = "00:00:00";
                    listans.Items.Clear();
                btnshuffle.Enabled = false;
                label2.Visible = true;
                }
        }
        void Shuffle()
        {
                int j;
                List<int> Indexes = new List<int>(new int[] {
                    0,1,2,3,4,5,6,7,8
                });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)PuzzleBox.Controls[i]).Image = PictureList[j];
                }
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
                MessageBox.Show("Time Is Up\nTry Again", "PUZZLEMENIA");
                Shuffle();
            }
        }
        private void btnpause_Click(object sender, EventArgs e)
        {
            if (btnpause.Text == "Pause")
            {
                timer.Stop();
                PuzzleBox.Visible = false;
                btnpause.Text = "Resume";
                label1.Visible = false;
            }
            else
            {
                timer.Start();
                PuzzleBox.Visible = true;
                btnpause.Text = "Pause";
                label1.Visible = true;
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
        private void btnshuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Do you want to shuffle?", "Are you sure to shuffle?", MessageBoxButtons.YesNo);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
            }
        }
        private void btnguess_Click(object sender, EventArgs e)
        {
            if (listans.Items.Contains(tboxletter.Text))
            {
                MessageBox.Show("Word exists");
                tboxletter.Clear();
            }
            else if (al.Contains(tboxletter.Text))
            {
                timer.Start();
                MessageBox.Show("Correct");
                listans.Items.Add(tboxletter.Text);
                if (listans.Items.Count == 20)
                {
                    MessageBox.Show("Procced to next level" +
                        "\nNOTE: Picture Puzzle to Match into goal state!", "Congratulations...");
                    MessageBox.Show("You have only Five MINUTES to Finished this stage!" +
                    "\nNOTE: You only 5 times to reset the puzzle", "NOTE:");
                    FormRandom2 ran = new FormRandom2();
                    ran.Owner = this;
                    ran.Show(this);
                    this.Hide();
                }
                if (listans.Items.Count == 10)
                {
                    btnshuffle.Enabled = true;
                    label2.Visible = false;
                }
                tboxletter.Clear();
            }
            else if (tboxletter.Text == "")
            {
                MessageBox.Show("Please Input!");
            }
            else
            {
                MessageBox.Show("Wrong");
                tboxletter.Clear();
            }
        }
    }
}
