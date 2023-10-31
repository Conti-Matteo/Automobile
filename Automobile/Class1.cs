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
        private bool _motore;//dichiaro la variabile utilizzata per l'accensione dell'auto
        private int _tacchimetro;//dichiaro variable per la visualizzazione della velocità
        private int _cambio;//dichiaro variabile per la visualizzazione della marcia
        private bool _frizione;

        public Auto()
        {
            motore = false;
            tacchimetro = 0;
            cambio = 0;
            frizione = false;
        }
        //funzioni get e set
        public bool motore
        {
            get { return _motore; }
            set { _motore = value; }
        }
        public int tacchimetro
        {
            get { return _tacchimetro; }
            set
            {
                if(_tacchimetro<0)
                {
                    _tacchimetro = 0;
                }
                else
                {
                    _tacchimetro = value;
                }
            }
        }
        public int cambio
        {
            get { return _cambio; }
            set 
            { 
                if ( _cambio < 0 || _cambio > 7 )
                {
                    _cambio = 0;
                }
                else
                {
                    _cambio = value;
                }
            }
        }
        public bool frizione
        {
            get { return _frizione; }
            set { _frizione = value; }
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
            if (cambio == 0)
            {
                _tacchimetro = tacchimetro + 0;
            }
            else if (cambio == 1)
            {
                if (tacchimetro == 20)
                {
                    _tacchimetro = tacchimetro + 0;
                }
                else if (cambio == 2)
                {
                    if (tacchimetro == 40)
                    {
                        _tacchimetro = tacchimetro + 0;
                    }
                    else if (cambio == 3)
                    {
                        if (tacchimetro == 60)
                        {
                            _tacchimetro = tacchimetro + 0;
                        }
                        else if (cambio == 4)
                        {
                            if (tacchimetro == 90)
                            {
                                _tacchimetro = tacchimetro + 0;
                            }
                            else if (cambio == 5)
                            {
                                if (tacchimetro == 120)
                                {
                                    _tacchimetro = tacchimetro + 0;
                                }
                            }
                            else if (cambio == 6)
                            {
                                if (tacchimetro == 150)
                                {
                                    _tacchimetro = tacchimetro + 0;
                                }
                                else
                                {
                                    _tacchimetro = tacchimetro + 10;
                                }
                            }
                        }
                    }
                }
            }
                            }
        public void freno()
        {
            if(_tacchimetro <= 0)
            {
                _tacchimetro = 0;
            }
            else
            {
                _tacchimetro = tacchimetro - 10;
            }
        }
    }
}
