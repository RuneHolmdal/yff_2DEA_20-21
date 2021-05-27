namespace Prøve_2021_04_22
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Oppg1 = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Oppg2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Oppg3 = new System.Windows.Forms.TabPage();
			this.Oppg4 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.Oppg4PB = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Oppg4Timer = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.Oppg1.SuspendLayout();
			this.Oppg2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Oppg4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Oppg4PB)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Oppg1);
			this.tabControl1.Controls.Add(this.Oppg2);
			this.tabControl1.Controls.Add(this.Oppg3);
			this.tabControl1.Controls.Add(this.Oppg4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(833, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// Oppg1
			// 
			this.Oppg1.Controls.Add(this.richTextBox1);
			this.Oppg1.Controls.Add(this.button1);
			this.Oppg1.Location = new System.Drawing.Point(4, 22);
			this.Oppg1.Name = "Oppg1";
			this.Oppg1.Padding = new System.Windows.Forms.Padding(3);
			this.Oppg1.Size = new System.Drawing.Size(825, 424);
			this.Oppg1.TabIndex = 0;
			this.Oppg1.Text = "Oppg1";
			this.Oppg1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(819, 161);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 74);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Oppg2
			// 
			this.Oppg2.Controls.Add(this.button2);
			this.Oppg2.Controls.Add(this.pictureBox1);
			this.Oppg2.Location = new System.Drawing.Point(4, 22);
			this.Oppg2.Name = "Oppg2";
			this.Oppg2.Padding = new System.Windows.Forms.Padding(3);
			this.Oppg2.Size = new System.Drawing.Size(825, 424);
			this.Oppg2.TabIndex = 1;
			this.Oppg2.Text = "Oppg2";
			this.Oppg2.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lime;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(112, 138);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 72);
			this.button2.TabIndex = 1;
			this.button2.Text = "Start";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Prøve_2021_04_22.Properties.Resources.wheels;
			this.pictureBox1.Location = new System.Drawing.Point(394, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 300);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Oppg3
			// 
			this.Oppg3.Location = new System.Drawing.Point(4, 22);
			this.Oppg3.Name = "Oppg3";
			this.Oppg3.Padding = new System.Windows.Forms.Padding(3);
			this.Oppg3.Size = new System.Drawing.Size(825, 424);
			this.Oppg3.TabIndex = 2;
			this.Oppg3.Text = "Oppg3";
			this.Oppg3.UseVisualStyleBackColor = true;
			// 
			// Oppg4
			// 
			this.Oppg4.Controls.Add(this.button3);
			this.Oppg4.Controls.Add(this.Oppg4PB);
			this.Oppg4.Location = new System.Drawing.Point(4, 22);
			this.Oppg4.Name = "Oppg4";
			this.Oppg4.Padding = new System.Windows.Forms.Padding(3);
			this.Oppg4.Size = new System.Drawing.Size(825, 424);
			this.Oppg4.TabIndex = 3;
			this.Oppg4.Text = "Oppg4";
			this.Oppg4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(681, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(138, 72);
			this.button3.TabIndex = 3;
			this.button3.Text = "Start";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Oppg4PB
			// 
			this.Oppg4PB.Image = global::Prøve_2021_04_22.Properties.Resources.wheels;
			this.Oppg4PB.Location = new System.Drawing.Point(8, 8);
			this.Oppg4PB.Name = "Oppg4PB";
			this.Oppg4PB.Size = new System.Drawing.Size(113, 115);
			this.Oppg4PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Oppg4PB.TabIndex = 2;
			this.Oppg4PB.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Oppg4Timer
			// 
			this.Oppg4Timer.Interval = 2;
			this.Oppg4Timer.Tick += new System.EventHandler(this.Oppg4Timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.Oppg1.ResumeLayout(false);
			this.Oppg2.ResumeLayout(false);
			this.Oppg2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Oppg4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Oppg4PB)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Oppg1;
		private System.Windows.Forms.TabPage Oppg2;
		private System.Windows.Forms.TabPage Oppg3;
		private System.Windows.Forms.TabPage Oppg4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox Oppg4PB;
		private System.Windows.Forms.Timer Oppg4Timer;
	}
}

