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
        public MainForm1()
        {
            InitializeComponent();
        }
        private void MainForm1_Load(object sender, EventArgs e)
        {
            BTN_AjouterCircuit.Enabled = false;
            BTN_Search.Enabled = false;
            BTN_SupprimerCircuit.Enabled = false;
        }
        private void BTN_AjouterCircuit_Click(object sender, EventArgs e)
        {
            AjouterCircuit ajouter = new AjouterCircuit();
            ajouter.Show();
        }

        private void BTN_SupprimerCircuit_Click(object sender, EventArgs e)
        {

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
            BTN_AjouterCircuit.Enabled = true;
            BTN_Search.Enabled = true;
            BTN_Modifiersupprimer.Enabled = true;
            BTN_SupprimerCircuit.Enabled = true;
            //UPDATE_UI();
            //initier_Liste_Categorie(CB_ChoixCatégorie1);
            //initier_Liste_Categorie(CB_ChoixCatégorie);
            //CB_ChoixCatégorie.SelectedIndex = 0;
            //CB_ChoixCatégorie1.SelectedIndex = 0;
            //RBTN_TousLesAlbums.Select();
            //CB_ChoixCatégorie.DropDownStyle = ComboBoxStyle.DropDownList;
            //CB_ChoixCatégorie1.DropDownStyle = ComboBoxStyle.DropDownList;
            //afficherDGV();
        }

        private void BTN_quitter_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        
    }
}
