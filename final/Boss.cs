using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{
    public partial class Boss : Form
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
        public Boss()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pbxImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image One");
            FormBossPic1 pic1 = new FormBossPic1();
            pic1.Owner = this;
            pic1.Show(this);
        }

        private void pbxWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Word");
            FormBossWord word = new FormBossWord();
            word.Owner = this;
            word.Show(this);
        }

        private void pbxNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number");
            FormBossNum num = new FormBossNum();
            num.Owner = this;
            num.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to Exit?\nYou loss the opportunity to save the game", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (YesOrNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
        	DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to Exit?\nYou loss the opportunity to save the game", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (YesOrNo == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void pbxImage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image");
            FormBossPic i = new FormBossPic();
            i.Owner = this;
            i.Show(this);
        }

        private void pbxNumber1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number One");
            FormBossNum1 num1 = new FormBossNum1();
            num1.Owner = this;
            num1.Show(this);
        }

        private void pbxWord1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Word One");
            FormBossWord1 word1 = new FormBossWord1();
            word1.Owner = this;
            word1.Show(this);
        }

        private void pbxImage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye!");
            pbxImage2.Visible = false;
        }
    }
}
