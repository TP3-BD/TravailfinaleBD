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
            this.BTN_Modifiersupprimer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBTN_ParCategorie = new System.Windows.Forms.RadioButton();
            this.RBTN_ParNom = new System.Windows.Forms.RadioButton();
            this.RBTN_TousLesAlbums = new System.Windows.Forms.RadioButton();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.CB_ChoixCatégorie = new System.Windows.Forms.ComboBox();
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
            this.BTN_quitter.Location = new System.Drawing.Point(691, 285);
            this.BTN_quitter.Name = "BTN_quitter";
            this.BTN_quitter.Size = new System.Drawing.Size(107, 42);
            this.BTN_quitter.TabIndex = 12;
            this.BTN_quitter.Text = "Quitter";
            this.BTN_quitter.UseVisualStyleBackColor = true;
            this.BTN_quitter.Click += new System.EventHandler(this.BTN_quitter_Click);
            // 
            // BTN_connection
            // 
            this.BTN_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_connection.Location = new System.Drawing.Point(579, 285);
            this.BTN_connection.Name = "BTN_connection";
            this.BTN_connection.Size = new System.Drawing.Size(107, 42);
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
            this.DGV_Album.Location = new System.Drawing.Point(355, 24);
            this.DGV_Album.Name = "DGV_Album";
            this.DGV_Album.Size = new System.Drawing.Size(443, 206);
            this.DGV_Album.TabIndex = 10;
            // 
            // BTN_Modifiersupprimer
            // 
            this.BTN_Modifiersupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modifiersupprimer.Location = new System.Drawing.Point(466, 285);
            this.BTN_Modifiersupprimer.Name = "BTN_Modifiersupprimer";
            this.BTN_Modifiersupprimer.Size = new System.Drawing.Size(107, 42);
            this.BTN_Modifiersupprimer.TabIndex = 9;
            this.BTN_Modifiersupprimer.Text = "Modifier/Supprimer";
            this.BTN_Modifiersupprimer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.RBTN_ParCategorie);
            this.groupBox2.Controls.Add(this.RBTN_ParNom);
            this.groupBox2.Controls.Add(this.RBTN_TousLesAlbums);
            this.groupBox2.Controls.Add(this.BTN_Search);
            this.groupBox2.Controls.Add(this.CB_ChoixCatégorie);
            this.groupBox2.Controls.Add(this.TBX_ParNom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 168);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche d\'un circuit";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Par Monument ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParCategorie
            // 
            this.RBTN_ParCategorie.AutoSize = true;
            this.RBTN_ParCategorie.Location = new System.Drawing.Point(9, 81);
            this.RBTN_ParCategorie.Name = "RBTN_ParCategorie";
            this.RBTN_ParCategorie.Size = new System.Drawing.Size(76, 19);
            this.RBTN_ParCategorie.TabIndex = 10;
            this.RBTN_ParCategorie.Text = "Par Prix";
            this.RBTN_ParCategorie.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParNom
            // 
            this.RBTN_ParNom.AutoSize = true;
            this.RBTN_ParNom.Location = new System.Drawing.Point(9, 56);
            this.RBTN_ParNom.Name = "RBTN_ParNom";
            this.RBTN_ParNom.Size = new System.Drawing.Size(150, 19);
            this.RBTN_ParNom.TabIndex = 9;
            this.RBTN_ParNom.Text = "Par ville de départ :";
            this.RBTN_ParNom.UseVisualStyleBackColor = true;
            // 
            // RBTN_TousLesAlbums
            // 
            this.RBTN_TousLesAlbums.AutoSize = true;
            this.RBTN_TousLesAlbums.Checked = true;
            this.RBTN_TousLesAlbums.Location = new System.Drawing.Point(9, 29);
            this.RBTN_TousLesAlbums.Name = "RBTN_TousLesAlbums";
            this.RBTN_TousLesAlbums.Size = new System.Drawing.Size(137, 19);
            this.RBTN_TousLesAlbums.TabIndex = 8;
            this.RBTN_TousLesAlbums.TabStop = true;
            this.RBTN_TousLesAlbums.Text = "Par ordre d\'étoile";
            this.RBTN_TousLesAlbums.UseVisualStyleBackColor = true;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Location = new System.Drawing.Point(237, 139);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(79, 23);
            this.BTN_Search.TabIndex = 7;
            this.BTN_Search.Text = "Rechercher";
            this.BTN_Search.UseVisualStyleBackColor = true;
            // 
            // CB_ChoixCatégorie
            // 
            this.CB_ChoixCatégorie.FormattingEnabled = true;
            this.CB_ChoixCatégorie.Location = new System.Drawing.Point(158, 77);
            this.CB_ChoixCatégorie.Name = "CB_ChoixCatégorie";
            this.CB_ChoixCatégorie.Size = new System.Drawing.Size(158, 23);
            this.CB_ChoixCatégorie.TabIndex = 4;
            // 
            // TBX_ParNom
            // 
            this.TBX_ParNom.Location = new System.Drawing.Point(182, 54);
            this.TBX_ParNom.Name = "TBX_ParNom";
            this.TBX_ParNom.Size = new System.Drawing.Size(134, 21);
            this.TBX_ParNom.TabIndex = 3;
            // 
            // BTN_AjouterCircuit
            // 
            this.BTN_AjouterCircuit.Location = new System.Drawing.Point(19, 24);
            this.BTN_AjouterCircuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AjouterCircuit.Name = "BTN_AjouterCircuit";
            this.BTN_AjouterCircuit.Size = new System.Drawing.Size(286, 50);
            this.BTN_AjouterCircuit.TabIndex = 13;
            this.BTN_AjouterCircuit.Text = "Ajouter un Circuit";
            this.BTN_AjouterCircuit.UseVisualStyleBackColor = true;
            this.BTN_AjouterCircuit.Click += new System.EventHandler(this.BTN_AjouterCircuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste des circuit :";
            // 
            // BTN_SupprimerCircuit
            // 
            this.BTN_SupprimerCircuit.Location = new System.Drawing.Point(19, 93);
            this.BTN_SupprimerCircuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_SupprimerCircuit.Name = "BTN_SupprimerCircuit";
            this.BTN_SupprimerCircuit.Size = new System.Drawing.Size(286, 50);
            this.BTN_SupprimerCircuit.TabIndex = 15;
            this.BTN_SupprimerCircuit.Text = "Supprimer ce circuit";
            this.BTN_SupprimerCircuit.UseVisualStyleBackColor = true;
            this.BTN_SupprimerCircuit.Click += new System.EventHandler(this.BTN_SupprimerCircuit_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 346);
            this.Controls.Add(this.BTN_SupprimerCircuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_AjouterCircuit);
            this.Controls.Add(this.BTN_quitter);
            this.Controls.Add(this.BTN_connection);
            this.Controls.Add(this.DGV_Album);
            this.Controls.Add(this.BTN_Modifiersupprimer);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button BTN_Modifiersupprimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBTN_ParCategorie;
        private System.Windows.Forms.RadioButton RBTN_ParNom;
        private System.Windows.Forms.RadioButton RBTN_TousLesAlbums;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.ComboBox CB_ChoixCatégorie;
        private System.Windows.Forms.TextBox TBX_ParNom;
        private System.Windows.Forms.Button BTN_AjouterCircuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SupprimerCircuit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

