using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class FormBossWord : Form
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
        public FormBossWord()
        {
            InitializeComponent();
            PictureList.AddRange(new Bitmap[] {
                Properties.Resources.a,
                Properties.Resources.b,
                Properties.Resources.d,
                Properties.Resources.f,
                Properties.Resources.j,
                Properties.Resources.k,
                Properties.Resources.y11,
                Properties.Resources.n1,
                Properties.Resources.u,
                Properties.Resources.z,
                Properties.Resources.z1,
                Properties.Resources.h1,
                Properties.Resources.L1,
                Properties.Resources.n2,
                Properties.Resources.o1,
                Properties.Resources.v1
            });
            //All correct answers
            al = new ArrayList();
            al.Add("unfondly");
            al.Add("annoyful");
            al.Add("bunkload");
            al.Add("nonflaky");
            al.Add("dofunny");
            al.Add("handful");
            al.Add("boundly");
            al.Add("unflank");
            al.Add("unnobly");
            al.Add("unflaky");
            al.Add("unhandy");
            al.Add("flanky");
            al.Add("baulky");
            al.Add("hodful");
            al.Add("doubly");
            al.Add("fundal");
            al.Add("byland");
            al.Add("blanky");
            al.Add("blazon");
            al.Add("danzon");
            al.Add("dankly");
            al.Add("fondly");
            al.Add("joyful");
            al.Add("flunky");
            al.Add("noyful");
            al.Add("adnoun");
            al.Add("unably");
            al.Add("unbody");
            al.Add("unbank");
            al.Add("unload");
            al.Add("unfond");
            al.Add("unfold");
            al.Add("unland");
            al.Add("unhold");
            al.Add("unhazy");
            al.Add("unholy");
            al.Add("unbold");
            al.Add("unhand");
            al.Add("abound");
            al.Add("funny");
            al.Add("funky");
            al.Add("hunky");
            al.Add("flunk");
            al.Add("fluky");
            al.Add("halfy");
            al.Add("bandy");
            al.Add("fload");
            al.Add("flank");
            al.Add("flaky");
            al.Add("ahold");
            al.Add("baldy");
            al.Add("balky");
            al.Add("dunno");
            al.Add("honky");
            al.Add("afoul");
            al.Add("hulky");
            al.Add("found");
            al.Add("blazy");
            al.Add("vodka");
            al.Add("blond");
            al.Add("dauby");
            al.Add("fonly");
            al.Add("badly");
            al.Add("bulky");
            al.Add("folky");
            al.Add("foldy");
            al.Add("nobly");
            al.Add("nylon");
            al.Add("aloud");

            lblTimeElapsed.Text = "00:00:00";
            btnshuffle.Click += click;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void FormBossWord_Load(object sender, EventArgs e)
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
                    0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
                });
            Random r = new Random();
            for (int i = 0; i < 16; i++)
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
            YesOrNo = MessageBox.Show("Do you want to Exit?\nYou loss the opportunity to save the game", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                if (listans.Items.Count == 30)
                {
                    MessageBox.Show("Procced to next level?" +
                             "\nTo Close another door", "Congratulations...");
                    (this.Owner as Boss).pbxWord.Visible = false;
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
            else if (tboxletter.Text.Length <= 4)
            {
                MessageBox.Show("Need atleast 5 letters!");
            }
            else
            {
                MessageBox.Show("Wrong");
                tboxletter.Clear();
            }
        }
		void Label3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Find All possible words,\nbetween 5 to 8 letters only.\nNeed atleast 30 words to complete.");
		}
    }
}
