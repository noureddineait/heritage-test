using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Ecercice01
{
    internal class Employe
    {
        protected string nom;
        protected string fonction;
        protected int bureau;
        protected string email;

        public void Afficher()
        {
            Console.WriteLine(this.nom + " " + this.fonction + " " + this.bureau.ToString()+ " " + this.email);
        }
        public void Louer(Livre Livre)
        {


        }

        public Employe( string nom, string fonction ,int bureau,string email)
        {
            this.nom = nom;
            this.fonction = fonction;
            this.bureau = bureau;
            this.email = email;

        }
    }
}
