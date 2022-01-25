using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Ecercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1= new Employe("houda","fonction1",1,"aaaaaa");
            employe1.Afficher();
            Console.ReadKey();
        }
    }
}
