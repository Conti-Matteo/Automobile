using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Auto
    {
        //attributi
        private bool motore;//dichiaro la variabile utilizzata per l'accensione dell'auto
        private int tacchimetro;//dichiaro variable per la visualizzazione della velocità
        private int cambio;//dichiaro variabile per la visualizzazione della marcia

        public Auto()
        {
            Motore = false;
            Tacchimetro = 0;
            Cambio = 0;
        }
        //funzioni get e set
        bool Motore
        {
            get { return motore; }
            set { motore = value; }
        }
        int Tacchimetro
        {
            get { return tacchimetro; }
            set { tacchimetro = value; }
        }
        int Cambio
        {
            get { return cambio; }
            set { cambio = value; }
        }
    }
}
