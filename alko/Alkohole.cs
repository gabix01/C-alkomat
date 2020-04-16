using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alko
{

    public class Alkohole : Osoba
    {
       
        private double _Piwo;
        private double _Wodka;
        private double _Wino;
        private double _Whisky;
        public double Piwo


        {
           
            get
            {
                return _Piwo * 10;
            }
            set
            {
                _Piwo = value;
            }
        }
        //250ml piwa 5%= 10g czystego alko
        public double Wodka
        {
        //30ml wódki 40% = 10g czystego alko

            get
            {
                return _Wodka * 10;
            }
            set
            {
                _Wodka = value;
            }
        }

    
        public double Wino
        {
            get
            {
                return _Wino * 10;
            }
            set
            {
                _Wino = value;
            }
            //100ml wina 12% = 10g czystego alko 

        }
        public double Whisky
        {
            //30ml whisky 40% = 10g czystego alko
            get
            {
                return _Whisky * 10;
            }
            set
            {
                _Whisky = value;
            }
        }
       
        /*public void WyswietlDane()
        {
            Console.WriteLine($"piwo={(this.Piwo)}");
        }
        public void Wynik()
        {
            double wynik = (Whisky + Piwo + Wino + Wodka )/ Gender * Waga;
            Console.WriteLine(wynik);

            Console.ReadKey();
        }*/

    }
}
