/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 19/11/2019
 * Time: 6:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace final
{

    public partial class MainForm : Form
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
        private SoundPlayer splayer;
        public MainForm()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            splayer = new SoundPlayer("Puzzle-Game_Looping.wav");
        }
		private void BtneasyClick(object sender, EventArgs e)
		{
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Do you want to start Hidden Object Level?", "Are you Ready?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
         {
                Story story = new Story();
                story.Owner = this;
                story.Show(this);
            }
        }
		void BtnmedClick(object sender, EventArgs e)
		{
            DialogResult YesOrNo = new DialogResult();
            YesOrNo = MessageBox.Show("Welcome to PUZZLEMENIA Game ", "Random Mode");
            YesOrNo = MessageBox.Show("Let's Play the Game", "Are you Ready?", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                FormRandom2 ran = new FormRandom2();
                ran.Owner = this;
                ran.Show(this);
            }
        }
		void BtnhardClick(object sender, EventArgs e)
		{
            Boss boss = new Boss();
            boss.Owner = this;
            boss.Show(this);
        }
		void BtnleadbdClick(object sender, EventArgs e)
		{
			FormInstruc ins = new FormInstruc();
			ins.Show();
            btnmed.Enabled = true;
            label5.Visible = false;
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
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg) {
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
						m.Result = (IntPtr)0x2;
					return;
			}

			base.WndProc(ref m);
		}

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Puzzle Game are time killer and annoying for some user/gamer, " +
                "you can't proceed to mode that you want, you need to finished first Random " +
                "to moved into the next level.(We provide a difficulty in the game to make the game not so bored!)" +
                "The game have a randomized number mode, picture mode and words mode to make the goal state" +
                "\n\nCreated By: AQP, PT, ES\n(LSPU CCS BSCS-2A 2019 👀)",
                "Welcome to PUZZLEMENIA Game ", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHint hint = new FormHint();
            hint.Show();
        }
		void Label4Click(object sender, EventArgs e)
		{
			MessageBox.Show("YOU NEED TO FINISHED RANDOM and \nHIDDEN OBJECT MODE TO PROCCED!");
		}
		void Label3Click(object sender, EventArgs e)
		{
			MessageBox.Show("YOU NEED TO FINISHED RANDOM MODE TO PROCCED!");
		}
		void Label5Click(object sender, EventArgs e)
		{
			MessageBox.Show("READ THE GAME INSTRUCTION FIRST!");
		}

        private void label6_Click(object sender, EventArgs e)
        {
            splayer.Play();
            label6.Visible = false;
            label7.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            splayer.Stop();
            label7.Visible = false;
            label6.Visible = true;
        }
    }
}
