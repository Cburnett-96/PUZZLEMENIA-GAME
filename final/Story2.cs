using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class Story2 : Form
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
        public Story2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Read carefully and check the image before you proceed", "Are you sure to Start?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                MessageBox.Show("You need to figure out what object to match" +
                    "\nYou have only 3 mins and 5 shuffle allow", "Read Carefully");
                FormStory2 fs2 = new FormStory2();
                fs2.Owner = this;
                fs2.Show(this);
                this.Hide();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to exit?", "Are you sure to exit?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                Story1Ans stans1 = new Story1Ans();
                stans1.Show();
                this.Close();
            }
        }
    }
}
