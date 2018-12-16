namespace TravailfinaleBD
{
    partial class AjouterCircuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCircuit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_ChoixMonuments = new System.Windows.Forms.Button();
            this.CBB_VilleArrivee = new System.Windows.Forms.ComboBox();
            this.CBB_VilleDepart = new System.Windows.Forms.ComboBox();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.TB_NBPersonneMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Durée = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NomCircuit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BT_ChoixMonuments);
            this.groupBox1.Controls.Add(this.CBB_VilleArrivee);
            this.groupBox1.Controls.Add(this.CBB_VilleDepart);
            this.groupBox1.Controls.Add(this.BTN_Annuler);
            this.groupBox1.Controls.Add(this.TB_NBPersonneMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TB_Durée);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BTN_Ajouter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_NomCircuit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BT_ChoixMonuments
            // 
            resources.ApplyResources(this.BT_ChoixMonuments, "BT_ChoixMonuments");
            this.BT_ChoixMonuments.Name = "BT_ChoixMonuments";
            this.BT_ChoixMonuments.UseVisualStyleBackColor = true;
            this.BT_ChoixMonuments.Click += new System.EventHandler(this.BT_ChoixMonuments_Click);
            // 
            // CBB_VilleArrivee
            // 
            resources.ApplyResources(this.CBB_VilleArrivee, "CBB_VilleArrivee");
            this.CBB_VilleArrivee.FormattingEnabled = true;
            this.CBB_VilleArrivee.Name = "CBB_VilleArrivee";
            // 
            // CBB_VilleDepart
            // 
            resources.ApplyResources(this.CBB_VilleDepart, "CBB_VilleDepart");
            this.CBB_VilleDepart.FormattingEnabled = true;
            this.CBB_VilleDepart.Name = "CBB_VilleDepart";
            // 
            // BTN_Annuler
            // 
            resources.ApplyResources(this.BTN_Annuler, "BTN_Annuler");
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // TB_NBPersonneMax
            // 
            resources.ApplyResources(this.TB_NBPersonneMax, "TB_NBPersonneMax");
            this.TB_NBPersonneMax.Name = "TB_NBPersonneMax";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TB_Durée
            // 
            resources.ApplyResources(this.TB_Durée, "TB_Durée");
            this.TB_Durée.Name = "TB_Durée";
            this.TB_Durée.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Durée_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // BTN_Ajouter
            // 
            resources.ApplyResources(this.BTN_Ajouter, "BTN_Ajouter");
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TB_NomCircuit
            // 
            resources.ApplyResources(this.TB_NomCircuit, "TB_NomCircuit");
            this.TB_NomCircuit.Name = "TB_NomCircuit";
            // 
            // AjouterCircuit
            // 
            this.AcceptButton = this.BTN_Ajouter;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterCircuit";
            this.Load += new System.EventHandler(this.AjouterCircuit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NomCircuit;
        private System.Windows.Forms.TextBox TB_Durée;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NBPersonneMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.ComboBox CBB_VilleArrivee;
        private System.Windows.Forms.ComboBox CBB_VilleDepart;
        private System.Windows.Forms.Button BT_ChoixMonuments;
    }
}