namespace TravailfinaleBD
{
    partial class MainForm1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_quitter = new System.Windows.Forms.Button();
            this.BTN_connection = new System.Windows.Forms.Button();
            this.DGV_Album = new System.Windows.Forms.DataGridView();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBX_ParPrix = new System.Windows.Forms.TextBox();
            this.CBB_Monument = new System.Windows.Forms.ComboBox();
            this.RBTN_ParMonument = new System.Windows.Forms.RadioButton();
            this.RBTN_ParPrix = new System.Windows.Forms.RadioButton();
            this.RBTN_ParVilleDebut = new System.Windows.Forms.RadioButton();
            this.RBTN_ParNbEtoile = new System.Windows.Forms.RadioButton();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TBX_ParNom = new System.Windows.Forms.TextBox();
            this.BTN_AjouterCircuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SupprimerCircuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Album)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_quitter
            // 
            this.BTN_quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_quitter.Location = new System.Drawing.Point(961, 370);
            this.BTN_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_quitter.Name = "BTN_quitter";
            this.BTN_quitter.Size = new System.Drawing.Size(143, 52);
            this.BTN_quitter.TabIndex = 12;
            this.BTN_quitter.Text = "Quitter";
            this.BTN_quitter.UseVisualStyleBackColor = true;
            this.BTN_quitter.Click += new System.EventHandler(this.BTN_quitter_Click);
            // 
            // BTN_connection
            // 
            this.BTN_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_connection.Location = new System.Drawing.Point(810, 370);
            this.BTN_connection.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_connection.Name = "BTN_connection";
            this.BTN_connection.Size = new System.Drawing.Size(143, 52);
            this.BTN_connection.TabIndex = 11;
            this.BTN_connection.Text = "Connection";
            this.BTN_connection.UseVisualStyleBackColor = true;
            this.BTN_connection.Click += new System.EventHandler(this.BTN_connection_Click);
            // 
            // DGV_Album
            // 
            this.DGV_Album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Album.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Album.Location = new System.Drawing.Point(513, 47);
            this.DGV_Album.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Album.Name = "DGV_Album";
            this.DGV_Album.Size = new System.Drawing.Size(591, 296);
            this.DGV_Album.TabIndex = 10;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modifier.Location = new System.Drawing.Point(16, 79);
            this.BTN_Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(440, 49);
            this.BTN_Modifier.TabIndex = 9;
            this.BTN_Modifier.Text = "Modifier ce circuit ";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TBX_ParPrix);
            this.groupBox2.Controls.Add(this.CBB_Monument);
            this.groupBox2.Controls.Add(this.RBTN_ParMonument);
            this.groupBox2.Controls.Add(this.RBTN_ParPrix);
            this.groupBox2.Controls.Add(this.RBTN_ParVilleDebut);
            this.groupBox2.Controls.Add(this.RBTN_ParNbEtoile);
            this.groupBox2.Controls.Add(this.BTN_Search);
            this.groupBox2.Controls.Add(this.TBX_ParNom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 212);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche d\'un circuit";
            // 
            // TBX_ParPrix
            // 
            this.TBX_ParPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_ParPrix.Location = new System.Drawing.Point(210, 103);
            this.TBX_ParPrix.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_ParPrix.Name = "TBX_ParPrix";
            this.TBX_ParPrix.Size = new System.Drawing.Size(210, 24);
            this.TBX_ParPrix.TabIndex = 13;
            this.TBX_ParPrix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBX_ParPrix_MouseClick);
            this.TBX_ParPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_ParPrix_KeyPress);
            // 
            // CBB_Monument
            // 
            this.CBB_Monument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBB_Monument.FormattingEnabled = true;
            this.CBB_Monument.Location = new System.Drawing.Point(210, 135);
            this.CBB_Monument.Margin = new System.Windows.Forms.Padding(4);
            this.CBB_Monument.Name = "CBB_Monument";
            this.CBB_Monument.Size = new System.Drawing.Size(209, 26);
            this.CBB_Monument.TabIndex = 12;
            this.CBB_Monument.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CBB_Monument_MouseClick);
            // 
            // RBTN_ParMonument
            // 
            this.RBTN_ParMonument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_ParMonument.AutoSize = true;
            this.RBTN_ParMonument.Location = new System.Drawing.Point(12, 135);
            this.RBTN_ParMonument.Margin = new System.Windows.Forms.Padding(4);
            this.RBTN_ParMonument.Name = "RBTN_ParMonument";
            this.RBTN_ParMonument.Size = new System.Drawing.Size(144, 22);
            this.RBTN_ParMonument.TabIndex = 11;
            this.RBTN_ParMonument.Text = "Par Monument ";
            this.RBTN_ParMonument.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParPrix
            // 
            this.RBTN_ParPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_ParPrix.AutoSize = true;
            this.RBTN_ParPrix.Location = new System.Drawing.Point(12, 105);
            this.RBTN_ParPrix.Margin = new System.Windows.Forms.Padding(4);
            this.RBTN_ParPrix.Name = "RBTN_ParPrix";
            this.RBTN_ParPrix.Size = new System.Drawing.Size(89, 22);
            this.RBTN_ParPrix.TabIndex = 10;
            this.RBTN_ParPrix.Text = "Par Prix";
            this.RBTN_ParPrix.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParVilleDebut
            // 
            this.RBTN_ParVilleDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_ParVilleDebut.AutoSize = true;
            this.RBTN_ParVilleDebut.Location = new System.Drawing.Point(12, 74);
            this.RBTN_ParVilleDebut.Margin = new System.Windows.Forms.Padding(4);
            this.RBTN_ParVilleDebut.Name = "RBTN_ParVilleDebut";
            this.RBTN_ParVilleDebut.Size = new System.Drawing.Size(174, 22);
            this.RBTN_ParVilleDebut.TabIndex = 9;
            this.RBTN_ParVilleDebut.Text = "Par ville de départ :";
            this.RBTN_ParVilleDebut.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParNbEtoile
            // 
            this.RBTN_ParNbEtoile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_ParNbEtoile.AutoSize = true;
            this.RBTN_ParNbEtoile.Checked = true;
            this.RBTN_ParNbEtoile.Location = new System.Drawing.Point(12, 41);
            this.RBTN_ParNbEtoile.Margin = new System.Windows.Forms.Padding(4);
            this.RBTN_ParNbEtoile.Name = "RBTN_ParNbEtoile";
            this.RBTN_ParNbEtoile.Size = new System.Drawing.Size(159, 22);
            this.RBTN_ParNbEtoile.TabIndex = 8;
            this.RBTN_ParNbEtoile.TabStop = true;
            this.RBTN_ParNbEtoile.Text = "Par ordre d\'étoile";
            this.RBTN_ParNbEtoile.UseVisualStyleBackColor = true;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Location = new System.Drawing.Point(316, 176);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(105, 28);
            this.BTN_Search.TabIndex = 7;
            this.BTN_Search.Text = "Rechercher";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TBX_ParNom
            // 
            this.TBX_ParNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_ParNom.Location = new System.Drawing.Point(211, 71);
            this.TBX_ParNom.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_ParNom.Name = "TBX_ParNom";
            this.TBX_ParNom.Size = new System.Drawing.Size(209, 24);
            this.TBX_ParNom.TabIndex = 3;
            this.TBX_ParNom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBX_ParNom_MouseClick);
            // 
            // BTN_AjouterCircuit
            // 
            this.BTN_AjouterCircuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AjouterCircuit.Location = new System.Drawing.Point(15, 24);
            this.BTN_AjouterCircuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AjouterCircuit.Name = "BTN_AjouterCircuit";
            this.BTN_AjouterCircuit.Size = new System.Drawing.Size(439, 49);
            this.BTN_AjouterCircuit.TabIndex = 13;
            this.BTN_AjouterCircuit.Text = "Ajouter un Circuit";
            this.BTN_AjouterCircuit.UseVisualStyleBackColor = true;
            this.BTN_AjouterCircuit.Click += new System.EventHandler(this.BTN_AjouterCircuit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste des circuit :";
            // 
            // BTN_SupprimerCircuit
            // 
            this.BTN_SupprimerCircuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SupprimerCircuit.Location = new System.Drawing.Point(15, 134);
            this.BTN_SupprimerCircuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SupprimerCircuit.Name = "BTN_SupprimerCircuit";
            this.BTN_SupprimerCircuit.Size = new System.Drawing.Size(440, 51);
            this.BTN_SupprimerCircuit.TabIndex = 15;
            this.BTN_SupprimerCircuit.Text = "Supprimer ce circuit";
            this.BTN_SupprimerCircuit.UseVisualStyleBackColor = true;
            this.BTN_SupprimerCircuit.Click += new System.EventHandler(this.BTN_SupprimerCircuit_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 438);
            this.Controls.Add(this.BTN_SupprimerCircuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_AjouterCircuit);
            this.Controls.Add(this.BTN_quitter);
            this.Controls.Add(this.BTN_connection);
            this.Controls.Add(this.DGV_Album);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm1";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Album)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_quitter;
        private System.Windows.Forms.Button BTN_connection;
        private System.Windows.Forms.DataGridView DGV_Album;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBTN_ParPrix;
        private System.Windows.Forms.RadioButton RBTN_ParVilleDebut;
        private System.Windows.Forms.RadioButton RBTN_ParNbEtoile;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TBX_ParNom;
        private System.Windows.Forms.Button BTN_AjouterCircuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SupprimerCircuit;
        private System.Windows.Forms.ComboBox CBB_Monument;
        private System.Windows.Forms.RadioButton RBTN_ParMonument;
        private System.Windows.Forms.TextBox TBX_ParPrix;
    }
}

