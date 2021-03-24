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
            this.panelLagre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbÅrsmodell
            // 
            this.tbÅrsmodell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbÅrsmodell.Location = new System.Drawing.Point(242, 169);
            this.tbÅrsmodell.Margin = new System.Windows.Forms.Padding(4);
            this.tbÅrsmodell.Name = "tbÅrsmodell";
            this.tbÅrsmodell.Size = new System.Drawing.Size(164, 34);
            this.tbÅrsmodell.TabIndex = 10;
            // 
            // tbBilMerke
            // 
            this.tbBilMerke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBilMerke.Location = new System.Drawing.Point(242, 127);
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
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bilmerke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Årsmodell:";
            // 
            // panelLagre
            // 
            this.panelLagre.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
    }
}

