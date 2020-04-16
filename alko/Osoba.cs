using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alko
{
    public class Osoba : Tajemnica
    {
        private string _Imie;
        private string _Nazwisko;
        private int _Wiek;
        private float _Waga;
        private char _Sex;
        private double _Gender;

        public string Imie
        {
            get
            {
                return _Imie;
            }
            set
            {
                _Imie = value;
            }

        }
        public string Nazwisko
        {
            get
            {
                return _Nazwisko;

            }
            set
            {
                _Nazwisko = value;
            }
        }
        public int Wiek
        {
            get
            {
                return _Wiek;
            }
            set
            {
                _Wiek = value;
            }

        }

        public float Waga
        {
            get
            {
                return _Waga;
            }
            set
            {
                _Waga = value;
            }
        }
        public char Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }

        }
        public double Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }

        }
    }


}

