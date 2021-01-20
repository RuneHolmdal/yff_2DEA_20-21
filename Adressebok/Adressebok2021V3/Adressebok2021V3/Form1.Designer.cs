namespace Adressebok2021V3
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
        private void InitializeComponent()
        {
            this.tbNavn = new System.Windows.Forms.TextBox();
            this.tbTlf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLagre = new System.Windows.Forms.Button();
            this.lbInnhold = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAntall = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSøk = new System.Windows.Forms.TextBox();
            this.tbEpost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRediger = new System.Windows.Forms.Button();
            this.btSlett = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNavn
            // 
            this.tbNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNavn.Location = new System.Drawing.Point(153, 92);
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.Size = new System.Drawing.Size(220, 39);
            this.tbNavn.TabIndex = 0;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(153, 148);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(220, 39);
            this.tbTlf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Navn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon:";
            // 
            // btLagre
            // 
            this.btLagre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLagre.Location = new System.Drawing.Point(153, 285);
            this.btLagre.Name = "btLagre";
            this.btLagre.Size = new System.Drawing.Size(220, 104);
            this.btLagre.TabIndex = 4;
            this.btLagre.Text = "Lagre oppføring";
            this.btLagre.UseVisualStyleBackColor = true;
            this.btLagre.Click += new System.EventHandler(this.btLagre_Click);
            // 
            // lbInnhold
            // 
            this.lbInnhold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInnhold.FormattingEnabled = true;
            this.lbInnhold.ItemHeight = 32;
            this.lbInnhold.Location = new System.Drawing.Point(448, 144);
            this.lbInnhold.Name = "lbInnhold";
            this.lbInnhold.Size = new System.Drawing.Size(200, 132);
            this.lbInnhold.TabIndex = 5;
            this.lbInnhold.SelectedIndexChanged += new System.EventHandler(this.lbInnhold_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Innhold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antall:";
            // 
            // lbAntall
            // 
            this.lbAntall.AutoSize = true;
            this.lbAntall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAntall.Location = new System.Drawing.Point(550, 309);
            this.lbAntall.Name = "lbAntall";
            this.lbAntall.Size = new System.Drawing.Size(31, 32);
            this.lbAntall.TabIndex = 8;
            this.lbAntall.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Søk:";
            // 
            // tbSøk
            // 
            this.tbSøk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSøk.Location = new System.Drawing.Point(677, 148);
            this.tbSøk.Name = "tbSøk";
            this.tbSøk.Size = new System.Drawing.Size(100, 39);
            this.tbSøk.TabIndex = 10;
            this.tbSøk.TextChanged += new System.EventHandler(this.tbSøk_TextChanged);
            // 
            // tbEpost
            // 
            this.tbEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpost.Location = new System.Drawing.Point(153, 212);
            this.tbEpost.Name = "tbEpost";
            this.tbEpost.Size = new System.Drawing.Size(220, 39);
            this.tbEpost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 12;
            this.label6.Tag = "";
            this.label6.Text = "Epost:";
            // 
            // btRediger
            // 
            this.btRediger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRediger.Location = new System.Drawing.Point(153, 395);
            this.btRediger.Name = "btRediger";
            this.btRediger.Size = new System.Drawing.Size(220, 104);
            this.btRediger.TabIndex = 13;
            this.btRediger.Text = "Rediger oppføring";
            this.btRediger.UseVisualStyleBackColor = true;
            this.btRediger.Click += new System.EventHandler(this.btRediger_Click);
            // 
            // btSlett
            // 
            this.btSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSlett.Location = new System.Drawing.Point(404, 395);
            this.btSlett.Name = "btSlett";
            this.btSlett.Size = new System.Drawing.Size(220, 104);
            this.btSlett.TabIndex = 14;
            this.btSlett.Text = "Slett oppføring";
            this.btSlett.UseVisualStyleBackColor = true;
            this.btSlett.Click += new System.EventHandler(this.btSlett_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.btSlett);
            this.Controls.Add(this.btRediger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEpost);
            this.Controls.Add(this.tbSøk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAntall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbInnhold);
            this.Controls.Add(this.btLagre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTlf);
            this.Controls.Add(this.tbNavn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNavn;
        private System.Windows.Forms.TextBox tbTlf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLagre;
        private System.Windows.Forms.ListBox lbInnhold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAntall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSøk;
        private System.Windows.Forms.TextBox tbEpost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRediger;
        private System.Windows.Forms.Button btSlett;
    }
}