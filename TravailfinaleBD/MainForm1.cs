using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace TravailfinaleBD
{
    public partial class MainForm1 : Form
    {
        public OracleConnection conn = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        private OracleDataAdapter Adapter1 = new OracleDataAdapter();

        public MainForm1()
        {
            InitializeComponent();
        }
        private void MainForm1_Load(object sender, EventArgs e)
        {
            Disable_TextBox();
            
        }

        private void Enable_TextBox()
        {
            BTN_AjouterCircuit.Enabled = true;
            BTN_Search.Enabled = true;
            BTN_Modifier.Enabled = true;
            BTN_SupprimerCircuit.Enabled = true;
            BTN_Modifier.Enabled = true;
        }

        private void Disable_TextBox()
        {
            BTN_AjouterCircuit.Enabled = false;
            BTN_Search.Enabled = false;
            BTN_SupprimerCircuit.Enabled = false;
            BTN_Modifier.Enabled = false;
        }

        private void BTN_AjouterCircuit_Click(object sender, EventArgs e)//to do
        {
            AjouterCircuit ajouter = new AjouterCircuit();
            ajouter.conn = conn;
            ajouter.monDataSet = monDataSet;
            ajouter.Adapter = Adapter1;
            ajouter.Show();
            if (ajouter.DialogResult == DialogResult.OK)
            {
                
            }
            afficherDGV();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)//to so
        {
            ModifierCircuit modifier = new ModifierCircuit();
            modifier.Show();
        }

        private void BTN_SupprimerCircuit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez vous vraiment supprimer ce circuit?", "Supprimer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //to do 
            }
        }

        private void BTN_connection_Click(object sender, EventArgs e)
        {
            try
            {
                string dsource = "(DESCRIPTION="
                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

                string ChaineDeConnection = "Data Source = " + dsource + "; User Id = bourgeoc; password = ORACLE1";
                conn.ConnectionString = ChaineDeConnection;
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
            Enable_TextBox();
            initier_ListeMonument(CBB_Monument);
            RBTN_ParNbEtoile.Select();
            CBB_Monument.DropDownStyle = ComboBoxStyle.DropDownList;
            afficherDGV();
        }

        private void BTN_quitter_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (RBTN_ParNbEtoile.Checked)
            {
                afficherDGV();
            }
            if (RBTN_ParVilleDebut.Checked)
            {
                AfficherParVilleDebut(TBX_ParNom.Text);//a faire
            }
            if(RBTN_ParPrix.Checked)
            {
                AfficherParPrix(TBX_ParPrix.Text);
            }
            if (RBTN_ParMonument.Checked)
            {
                AfficherParMonument(CBB_Monument.SelectedItem.ToString());//a faire
            }
        }

        

        private void afficherDGV()
        {
            try
            {
                string Tomastatar = "Select Nom,Prix,VilleDebut, VilleArrivee from Circuit";//ajouter le nombre détoile
               Adapter1.SelectCommand = new OracleCommand(Tomastatar, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeCircuit"))
                {
                    monDataSet.Tables["ListeCircuit"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeCircuit");
                Adapter1.Dispose();
                //on fait une liaison des données entre le DGV et le DataSet pour ListeEtudiants
                BindingSource maSource;
                maSource = new BindingSource(monDataSet, "ListeCircuit");
                DGV_Album.DataSource = maSource;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void AfficherParVilleDebut(string NomVille)//a completer
        {
            try
            {
                string sql3 = "Select Nom,Prix,VilleDebut, VilleArrivee from Circuit where VilleDebut ='" + NomVille + "'";
                Adapter1.SelectCommand = new OracleCommand(sql3, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeCircuit"))
                {
                    monDataSet.Tables["ListeCircuit"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeCircuit");
                Adapter1.Dispose();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }
        private void AfficherParPrix(string Prix)
        {
            try
            {
                string sql3 = "Select Nom,Prix,VilleDebut, VilleArrivee from Circuit where Prix <" + Prix;
                Adapter1.SelectCommand = new OracleCommand(sql3, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeCircuit"))
                {
                    monDataSet.Tables["ListeCircuit"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeCircuit");
                Adapter1.Dispose();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }
        private void AfficherParMonument(string Prix)//a faire plus tard 
        {
            try
            {
                string sql3 = "Select Nom,Prix,VilleDebut, VilleArrivee from Circuit where Prix =" + Prix;
                Adapter1.SelectCommand = new OracleCommand(sql3, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeCircuit"))
                {
                    monDataSet.Tables["ListeCircuit"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeCircuit");
                Adapter1.Dispose();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }

        private void CBB_Monument_MouseClick(object sender, MouseEventArgs e)
        {
            RBTN_ParMonument.Checked = true;
        }

        private void TBX_ParNom_MouseClick(object sender, MouseEventArgs e)
        {
            RBTN_ParVilleDebut.Checked = true;
        }

        private void TBX_ParPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TBX_ParPrix_MouseClick(object sender, MouseEventArgs e)
        {
            RBTN_ParPrix.Checked = true;
        }


        private void initier_ListeMonument(ComboBox CBB)
        {
            try
            {
                CBB.Items.Clear();
                string sql3 = "Select Nom from Monument";
                OracleCommand Requete3 = new OracleCommand(sql3, conn);
                OracleDataReader reader3 = Requete3.ExecuteReader();

                while (reader3.Read())
                {
                    CBB.Items.Add(reader3.GetString(0));
                }
                reader3.Close();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
            CBB.SelectedIndex = 0;
        }
    }
}
