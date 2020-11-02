using System;
using System.Collections;
using System.Windows.Forms;

namespace final
{
    public partial class StoryAns : Form
    {
        public StoryAns()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add("baseball");
            al.Add("BASEBALL");
            al.Add("Baseball");

            if (al.Contains(textBox1.Text))
            {
                MessageBox.Show("Correct");
                Story1 st1 = new Story1();
                st1.Owner = this;
                st1.Show(this);
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
