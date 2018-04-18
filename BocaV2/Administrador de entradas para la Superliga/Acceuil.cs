using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrador_de_entradas_para_la_Superliga.GlobalSvc;

namespace Administrador_de_entradas_para_la_Superliga
{
    public partial class Acceuil : Form
    {
        public string idSocio; 
        BaseSvc bS = BaseSvc.Instance;
        public Acceuil(string numSocio)
        {
            InitializeComponent();
            idSocio = numSocio;

            /* Alimentation des ComboBox */
            foreach (Match m in bS.getListMatchs())
            {
                cbxMatch.Items.Add(m.intitule);
            }

            foreach (Tribunes t in bS.getListTribunes())
            {
                cbxTribunes.Items.Add(t.nom);
            }
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            bS.achatBillet(Convert.ToInt32(cbxTribunes.Text), Convert.ToInt32(cbxMatch.Text), Convert.ToInt32(txtbNbPlace), idSocio);
        }
    }
}
