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
        private bool Motore;//dichiaro la variabile utilizzata per l'accensione dell'auto
        private int Tacchimetro;//dichiaro variable per la visualizzazione della velocità
        private int Cambio;//dichiaro variabile per la visualizzazione della marcia

        public Auto()
        {
            motore = false;
            tacchimetro = 0;
            cambio = 0;
        }
        //funzioni get e set
        public bool motore
        {
            get { return Motore; }
            set { Motore = value; }
        }
        public int tacchimetro
        {
            get { return Tacchimetro; }
            set { Tacchimetro = value; }
        }
        public int cambio
        {
            get { return Cambio; }
            set { Cambio = value; }
        }
        //funzioni
        public void accensione()
        {
            if (motore == false)
            {
                motore = true;
            }
            else
            {
                motore = false;
            }
        }
        public void accelleratore()
        {
            Tacchimetro = tacchimetro + 10;
        }
        public void freno()
        {
            Tacchimetro = tacchimetro - 10;
        }

    }
}
