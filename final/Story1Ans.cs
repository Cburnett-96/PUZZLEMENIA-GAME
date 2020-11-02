using System;
using System.Collections;
using System.Windows.Forms;

namespace final
{
    public partial class Story1Ans : Form
    {
        public Story1Ans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add("f");
            al.Add("F");

            if (al.Contains(textBox1.Text))
            {
                MessageBox.Show("Correct");
                Story2 st2 = new Story2();
                st2.Owner = this;
                st2.Show(this);
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
