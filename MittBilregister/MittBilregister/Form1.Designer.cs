namespace MittBilregister
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
            this.tbÅrsmodell = new System.Windows.Forms.TextBox();
            this.tbBilMerke = new System.Windows.Forms.TextBox();
            this.btnLagre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLagre = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBiler = new System.Windows.Forms.ListBox();
            this.tbForbruk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.cbEUgodkjent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelLagre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbÅrsmodell
            // 
            this.tbÅrsmodell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbÅrsmodell.Location = new System.Drawing.Point(242, 125);
            this.tbÅrsmodell.Margin = new System.Windows.Forms.Padding(4);
            this.tbÅrsmodell.Name = "tbÅrsmodell";
            this.tbÅrsmodell.Size = new System.Drawing.Size(164, 34);
            this.tbÅrsmodell.TabIndex = 10;
            // 
            // tbBilMerke
            // 
            this.tbBilMerke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBilMerke.Location = new System.Drawing.Point(242, 83);
            this.tbBilMerke.Margin = new System.Windows.Forms.Padding(4);
            this.tbBilMerke.Name = "tbBilMerke";
            this.tbBilMerke.Size = new System.Drawing.Size(164, 34);
            this.tbBilMerke.TabIndex = 8;
            // 
            // btnLagre
            // 
            this.btnLagre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLagre.Location = new System.Drawing.Point(242, 347);
            this.btnLagre.Margin = new System.Windows.Forms.Padding(4);
            this.btnLagre.Name = "btnLagre";
            this.btnLagre.Size = new System.Drawing.Size(164, 39);
            this.btnLagre.TabIndex = 13;
            this.btnLagre.Text = "Lagre";
            this.btnLagre.UseVisualStyleBackColor = true;
            this.btnLagre.Click += new System.EventHandler(this.btnLagre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bilmerke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Årsmodell:";
            // 
            // panelLagre
            // 
            this.panelLagre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLagre.Controls.Add(this.label7);
            this.panelLagre.Controls.Add(this.cbEUgodkjent);
            this.panelLagre.Controls.Add(this.tbKM);
            this.panelLagre.Controls.Add(this.label6);
            this.panelLagre.Controls.Add(this.tbForbruk);
            this.panelLagre.Controls.Add(this.label4);
            this.panelLagre.Controls.Add(this.label2);
            this.panelLagre.Controls.Add(this.label1);
            this.panelLagre.Controls.Add(this.tbBilMerke);
            this.panelLagre.Controls.Add(this.tbÅrsmodell);
            this.panelLagre.Controls.Add(this.label3);
            this.panelLagre.Controls.Add(this.btnLagre);
            this.panelLagre.Location = new System.Drawing.Point(34, 28);
            this.panelLagre.Name = "panelLagre";
            this.panelLagre.Size = new System.Drawing.Size(443, 404);
            this.panelLagre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Elev versjon";
            // 
            // listBoxBiler
            // 
            this.listBoxBiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBiler.FormattingEnabled = true;
            this.listBoxBiler.ItemHeight = 29;
            this.listBoxBiler.Location = new System.Drawing.Point(527, 28);
            this.listBoxBiler.Name = "listBoxBiler";
            this.listBoxBiler.Size = new System.Drawing.Size(435, 410);
            this.listBoxBiler.TabIndex = 22;
            // 
            // tbForbruk
            // 
            this.tbForbruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForbruk.Location = new System.Drawing.Point(242, 167);
            this.tbForbruk.Margin = new System.Windows.Forms.Padding(4);
            this.tbForbruk.Name = "tbForbruk";
            this.tbForbruk.Size = new System.Drawing.Size(164, 34);
            this.tbForbruk.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Forbruk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Km:";
            // 
            // tbKM
            // 
            this.tbKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKM.Location = new System.Drawing.Point(242, 253);
            this.tbKM.Margin = new System.Windows.Forms.Padding(4);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(164, 34);
            this.tbKM.TabIndex = 27;
            // 
            // cbEUgodkjent
            // 
            this.cbEUgodkjent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEUgodkjent.FormattingEnabled = true;
            this.cbEUgodkjent.Items.AddRange(new object[] {
            "Ja",
            "Nei"});
            this.cbEUgodkjent.Location = new System.Drawing.Point(242, 209);
            this.cbEUgodkjent.Name = "cbEUgodkjent";
            this.cbEUgodkjent.Size = new System.Drawing.Size(164, 37);
            this.cbEUgodkjent.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "EU godkjent:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 510);
            this.Controls.Add(this.panelLagre);
            this.Controls.Add(this.listBoxBiler);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLagre.ResumeLayout(false);
            this.panelLagre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbÅrsmodell;
        private System.Windows.Forms.TextBox tbBilMerke;
        private System.Windows.Forms.Button btnLagre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLagre;
        private System.Windows.Forms.ListBox listBoxBiler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbForbruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEUgodkjent;
    }
}

