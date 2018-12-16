namespace TravailfinaleBD
{
    partial class AjouterMonument
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NomMonument = new System.Windows.Forms.TextBox();
            this.RTB_HistoireMonument = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PrixMonument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_Monument = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du monument";
            // 
            // TB_NomMonument
            // 
            this.TB_NomMonument.Location = new System.Drawing.Point(155, 21);
            this.TB_NomMonument.Name = "TB_NomMonument";
            this.TB_NomMonument.Size = new System.Drawing.Size(204, 22);
            this.TB_NomMonument.TabIndex = 1;
            // 
            // RTB_HistoireMonument
            // 
            this.RTB_HistoireMonument.Location = new System.Drawing.Point(154, 147);
            this.RTB_HistoireMonument.Name = "RTB_HistoireMonument";
            this.RTB_HistoireMonument.Size = new System.Drawing.Size(204, 96);
            this.RTB_HistoireMonument.TabIndex = 2;
            this.RTB_HistoireMonument.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_PrixMonument);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DTP_Monument);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_NomMonument);
            this.groupBox1.Controls.Add(this.RTB_HistoireMonument);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Histoire du monument";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre d\'étoile";
            // 
            // TB_PrixMonument
            // 
            this.TB_PrixMonument.Location = new System.Drawing.Point(154, 77);
            this.TB_PrixMonument.Name = "TB_PrixMonument";
            this.TB_PrixMonument.Size = new System.Drawing.Size(204, 22);
            this.TB_PrixMonument.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix de la visite ";
            // 
            // DTP_Monument
            // 
            this.DTP_Monument.Location = new System.Drawing.Point(155, 49);
            this.DTP_Monument.Name = "DTP_Monument";
            this.DTP_Monument.Size = new System.Drawing.Size(203, 22);
            this.DTP_Monument.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de construction";
            // 
            // AjouterMonument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 270);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterMonument";
            this.Text = "AjouterMonument";
            this.Load += new System.EventHandler(this.AjouterMonument_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_HistoireMonument;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_PrixMonument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_Monument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_NomMonument;
    }
}