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

        private void Inserer() //AjoutDisque
        {
            //try
            //{
            //    string SQLInsert = "insert into Disques(NoDisque ,TitreDisque,NomArtiste,AnneeDisque,CodeCategorie) values(NoDisquesequence.nextval,'" + TB_TitreDisque.Text + "','" + TB_NomArtiste.Text + "'," + TB_AnnéDisque.Text + "," + "(select CodeCategorie from Categories where NomCategorie ='" + CB_ChoixCatégorie1.SelectedItem.ToString() + "'))";
            //    OracleCommand Insert = new OracleCommand(SQLInsert, conn);
            //    Insert.ExecuteNonQuery();
            //    MessageBox.Show("Album ajoutés");
            //}
            //catch (Exception me)
            //{
            //    MessageBox.Show(me.Message.ToString());
            //}
        }
    }
}
