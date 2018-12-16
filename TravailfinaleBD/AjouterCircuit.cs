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
    public partial class AjouterCircuit : Form
    {

        public OracleConnection conn;
        public DataSet monDataSet;
        public AjouterCircuit()
        {
            InitializeComponent();
        }
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Inserer();
            this.Close();
        }

        private void AjouterCircuit_Load(object sender, EventArgs e)
        {
            
        }

        private void Inserer() //AjoutCircuit
        {
            try
            {
                string SQLInsert = "insert into circuit(Nom ,Prix,VilleDebut,VilleArrivee,NombreMax,Duree,NumCircuit) values('"+TB_NomCircuit.Text +"'," + TB_PrixCircuit.Text + ",)";
                OracleCommand Insert = new OracleCommand(SQLInsert, conn);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Album ajoutés");
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
    }
}
