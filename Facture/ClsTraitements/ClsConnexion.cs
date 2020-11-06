using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduitGUI.Molo
{
    public class ClsConnexion
    {
        public string chemin;
        public void connect()
        {
            chemin = File.ReadAllText(ClsConstante.Table.chemin);
        }

    }
}
