using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Ecercice01
{
    internal class Bibliothecaire : Employe
    {
        public void Retour(Livre livre)
        {

        }
        public Bibliothecaire (string nom, string fonction, int bureau, string email) : base(nom,fonction,bureau,email)
        {
            this.nom = nom;
            this.fonction = fonction;
            this.bureau = bureau;
            this.email = email;

        }
    }
}
