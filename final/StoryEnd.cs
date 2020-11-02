using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class StoryEnd : Form
    {
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
        ArrayList al;
        public StoryEnd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            al = new ArrayList();
            al.Add("comb");
            al.Add("COMB");
            al.Add("birdhouse");
            al.Add("BIRDHOUSE");
            al.Add("kite");
            al.Add("KITE");
            al.Add("matchstick");
            al.Add("MATCHSTICK");
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            if (al.Contains(tbxans.Text))
            {
                MessageBox.Show("Correct");
                listans.Items.Add(tbxans.Text);
                if (tbxans.Text == "comb"|| tbxans.Text == "COMB")
                {
                    comb.Visible = true;
                }
                if (tbxans.Text == "birdhouse"|| tbxans.Text == "BIRDHOUSE")
                {
                    birdhouse.Visible = true;
                }
                if (tbxans.Text == "kite"|| tbxans.Text == "KITE")
                {
                    kite.Visible = true;
                }
                if (tbxans.Text == "matchstick"|| tbxans.Text == "MATCHSTICK")
                {
                    matchstick.Visible = true;
                }
                if (listans.Items.Count == 4)
                {
                    MessageBox.Show("Mission Completed!" +
                        "\nProcced to Boss?", "Congratulations");
                    this.Close();
                }
                tbxans.Clear();
            }
            else if (tbxans.Text == "")
            {
                MessageBox.Show("Please Input");
            }
            else
            {
                MessageBox.Show("Wrong");
                tbxans.Clear();
            }
        }
    }
}
