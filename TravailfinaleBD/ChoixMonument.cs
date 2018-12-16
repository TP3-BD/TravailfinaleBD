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
    public partial class ChoixMonument : Form
    {
        public string[] myTab = new string[14];
        public OracleConnection conn = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        private OracleDataAdapter Adapter1 = new OracleDataAdapter();
        public ChoixMonument()
        {
            InitializeComponent();
        }

        private void ChoixMonument_Load(object sender, EventArgs e)
        {
            initier_ListeMonument(comboBox1);
            initier_ListeMonument(comboBox2);
            initier_ListeMonument(comboBox3);
            initier_ListeMonument(comboBox4);
            initier_ListeMonument(comboBox5);
           
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
            CBB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        
    }
}
