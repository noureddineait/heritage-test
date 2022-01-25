using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Ecercice01
{
    internal class Livre
    {
        private string titre;
        private string auteur;
        private int edition;
        public Employe locataire ;
        private bool disponible;

        public void EstLouer()
        {

        }
        public  Livre(string titre,string auteur,int edition,bool disponible)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.edition = edition;
            this.disponible = disponible;   
        }


    }
}
