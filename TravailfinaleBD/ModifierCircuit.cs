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
using Validation;
       

namespace TravailfinaleBD
    {
        public partial class ModifierCircuit : Form
        {

        ValidationProvider validation;
        public string[] myTab = new string[14];
        public OracleConnection conn;
        public DataSet monDataSet;
        public OracleDataAdapter Adapter = new OracleDataAdapter();


        public ModifierCircuit()
        {
            InitializeComponent();
        }



        private void TB_Durée_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ModifierCircuit_Load(object sender, EventArgs e)
        {
                Initier_CBB_Ville(CBB_VilleArrivee);
                Initier_CBB_Ville(CBB_VilleDepart);
                BTN_Ajouter.Enabled = false;
                Load_validation();
        }
        

            private void Inserer_Circuit() //AjoutCircuit
            {
                try
                {
                    string SQLInsert = "insert into circuit(Nom,VilleDebut,VilleArrivee,NombreMax,Duree,NumCircuit)" +
                        " values" + "(:Nom,:VilleDebut,:VilleArrivee,:NombreMax,:Duree,seqCircuit.nextval)";
                    OracleParameter OraNom = new OracleParameter(":Nom", OracleDbType.Varchar2, 20);
                    OracleParameter OraVilleD = new OracleParameter(":VilleDebut", OracleDbType.Char, 3);
                    OracleParameter OraVilleA = new OracleParameter(":VilleArrivee", OracleDbType.Char, 3);
                    OracleParameter OraNBMax = new OracleParameter(":NombreMax", OracleDbType.Int64);
                    OracleParameter OraDuree = new OracleParameter(":Duree", OracleDbType.Int64);

                    OraNom.Value = TB_NomCircuit.Text;
                    OraVilleD.Value = CBB_VilleDepart.SelectedItem.ToString();
                    OraVilleA.Value = CBB_VilleArrivee.SelectedItem.ToString();
                    OraNBMax.Value = TB_NBPersonneMax.Text;
                    OraDuree.Value = TB_Durée.Text;


                    OracleCommand Insert = new OracleCommand(SQLInsert, conn);
                    Insert.CommandType = CommandType.Text;
                    Insert.Parameters.Add(OraNom);
                    Insert.Parameters.Add(OraVilleD);
                    Insert.Parameters.Add(OraVilleA);
                    Insert.Parameters.Add(OraNBMax);
                    Insert.Parameters.Add(OraDuree);


                    Insert.ExecuteNonQuery();
                    Adapter.Update(monDataSet.Tables["ListeCircuit"]);
                    monDataSet.AcceptChanges();

                    MessageBox.Show("Circuit ajoutés");
                }
                catch (Exception me)
                {
                    MessageBox.Show(me.Message.ToString());
                }
            }

            private void Inserer_Circuit_Monument()
            {
                for(int i = 0; i < 4;i++)
                 {
                     string SQLInsert = "INSERT INTO CircuitMonument(NumCircuit,NumeroMonument,OrdreVisite)"
                    + "values" + "((select NumCircuit from Circuit where Nom = '" + TB_NomCircuit + "'),(select NumeroMonument From Monument where Nom = '" + myTab[i] + "'), SEQCIRCUITMONUMENT.nextval)";

                    OracleCommand Insert = new OracleCommand(SQLInsert, conn);
                    Insert.ExecuteNonQuery();
                    Adapter.Update(monDataSet.Tables["ListeCircuitMonument"]);
                    monDataSet.AcceptChanges();
                }
                
            }


            private void Initier_CBB_Ville(ComboBox CBB)
            {
                try
                {
                    CBB.Items.Clear();
                    string sql3 = "Select Code from Ville";
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

            private void BT_ChoixMonuments_Click(object sender, EventArgs e)
            {
                ChoixMonument choix = new ChoixMonument();
                choix.conn = conn;
                choix.ShowDialog();
                if (choix.DialogResult == DialogResult.OK)
                {
                    BTN_Ajouter.Enabled = true;
                }
                myTab = choix.myTab;
            }

            private void Load_validation()
            {
                validation = new ValidationProvider(this, submitTask);
                validation.AddControlToValidate(TB_NomCircuit, Validate_Nom);
                validation.AddControlToValidate(TB_NBPersonneMax, Validate_NBMax);
                validation.AddControlToValidate(TB_Durée, Validate_Duree);
            }
            private bool Validate_Nom(ref string message)
            {
                message = "Nom manquant";
                return TB_NomCircuit.Text != "";
            }
            private bool Validate_NBMax(ref string message)
            {
                message = "Nombre de personne max manquant";
                return TB_NomCircuit.Text != "";
            }
            private bool Validate_Duree(ref string message)
            {
                message = "durée du ciruit manquant";
                return TB_NomCircuit.Text != "";
            }

            private void submitTask()
            {
                Inserer_Circuit();
                Inserer_Circuit_Monument();
            }

        
    }
}



