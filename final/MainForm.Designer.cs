/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 19/11/2019
 * Time: 6:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button btnboss;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnhidden = new System.Windows.Forms.Button();
            this.btnmed = new System.Windows.Forms.Button();
            this.btnboss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnleadbd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhidden
            // 
            this.btnhidden.BackColor = System.Drawing.Color.Transparent;
            this.btnhidden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhidden.BackgroundImage")));
            this.btnhidden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhidden.FlatAppearance.BorderSize = 0;
            this.btnhidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhidden.Location = new System.Drawing.Point(54, 171);
            this.btnhidden.Name = "btnhidden";
            this.btnhidden.Size = new System.Drawing.Size(188, 38);
            this.btnhidden.TabIndex = 0;
            this.btnhidden.Text = "Hidden Object";
            this.toolTip1.SetToolTip(this.btnhidden, "On this Mode you can play number mode 1 to 8 \r\nand at the next level will be addi" +
        "ng a timer.");
            this.btnhidden.UseVisualStyleBackColor = false;
            this.btnhidden.Click += new System.EventHandler(this.BtneasyClick);
            // 
            // btnmed
            // 
            this.btnmed.BackColor = System.Drawing.Color.Transparent;
            this.btnmed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmed.BackgroundImage")));
            this.btnmed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmed.FlatAppearance.BorderSize = 0;
            this.btnmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmed.Location = new System.Drawing.Point(93, 127);
            this.btnmed.Name = "btnmed";
            this.btnmed.Size = new System.Drawing.Size(113, 38);
            this.btnmed.TabIndex = 1;
            this.btnmed.Text = "Random";
            this.toolTip1.SetToolTip(this.btnmed, "NOTE: You have only ONE MINUTES to Finished this stage!\r\nNOTE: You only 5 allowed" +
        " to reset the puzzle!");
            this.btnmed.UseVisualStyleBackColor = false;
            this.btnmed.Click += new System.EventHandler(this.BtnmedClick);
            // 
            // btnboss
            // 
            this.btnboss.BackColor = System.Drawing.Color.Transparent;
            this.btnboss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnboss.BackgroundImage")));
            this.btnboss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnboss.FlatAppearance.BorderSize = 0;
            this.btnboss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnboss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboss.Location = new System.Drawing.Point(93, 215);
            this.btnboss.Name = "btnboss";
            this.btnboss.Size = new System.Drawing.Size(113, 38);
            this.btnboss.TabIndex = 2;
            this.btnboss.Text = "Boss";
            this.btnboss.UseVisualStyleBackColor = false;
            this.btnboss.Click += new System.EventHandler(this.BtnhardClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "PUZZLEMENIA GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(2, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 24);
            this.exit.TabIndex = 5;
            this.exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(279, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(228, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.label3, "YOU NEED TO FINISHED RANDOM MODE TO PROCCED");
            this.label3.Click += new System.EventHandler(this.Label3Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(197, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 9;
            this.toolTip1.SetToolTip(this.label4, "YOU NEED TO FINISHED RANDOM and HIDDEN OBJECT MODE TO PROCCED");
            this.label4.Click += new System.EventHandler(this.Label4Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(199, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 11;
            this.toolTip1.SetToolTip(this.label5, "READ THE GAME INSTRUCTION FIRST!");
            this.label5.Click += new System.EventHandler(this.Label5Click);
            // 
            // btnleadbd
            // 
            this.btnleadbd.BackColor = System.Drawing.Color.Transparent;
            this.btnleadbd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnleadbd.BackgroundImage")));
            this.btnleadbd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnleadbd.FlatAppearance.BorderSize = 0;
            this.btnleadbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleadbd.Location = new System.Drawing.Point(1, 296);
            this.btnleadbd.Name = "btnleadbd";
            this.btnleadbd.Size = new System.Drawing.Size(113, 23);
            this.btnleadbd.TabIndex = 3;
            this.btnleadbd.Text = "Instructions";
            this.btnleadbd.UseVisualStyleBackColor = false;
            this.btnleadbd.Click += new System.EventHandler(this.BtnleadbdClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(191, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hints to solve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(248, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 12;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(248, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 13;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 320);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnleadbd);
            this.Controls.Add(this.btnboss);
            this.Controls.Add(this.btnmed);
            this.Controls.Add(this.btnhidden);
            this.Controls.Add(this.label7);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "final";
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnleadbd;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btnhidden;
        private System.Windows.Forms.Button btnmed;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
