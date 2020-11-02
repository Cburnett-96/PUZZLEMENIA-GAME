using System;
using System.Collections;
using System.Windows.Forms;

namespace final
{
    public partial class Story2Ans : Form
    {
        public Story2Ans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add("envelope");
            al.Add("ENVELOPE");
            al.Add("Envelope");

            if (al.Contains(textBox1.Text))
            {
                MessageBox.Show("Correct");
                StoryEnd end = new StoryEnd();
                end.Owner = this;
                end.Show(this);
                this.Hide();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please Input");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }
    }
}
