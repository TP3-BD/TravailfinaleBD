using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailfinaleBD
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void BTN_AjouterCircuit_Click(object sender, EventArgs e)
        {
            AjouterCircuit ajouter = new AjouterCircuit();
            ajouter.Show();
        }

        private void BTN_SupprimerCircuit_Click(object sender, EventArgs e)
        {

        }
    }
}
