using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alko
{
    public class Tajemnica 
    {

        public double wspolczynnik;
         public void wprowadzanie()
        {
            Osoba osoba = new Osoba();
            Alkohole alkohole = new Alkohole();

            while (true)

            {
                try
                {


                    Console.Write("Sex(F=Female/M=Male): ");
                    osoba.Sex = char.Parse(Console.ReadLine());
                    if ((osoba.Sex != 'f') && (osoba.Sex != 'F') && (osoba.Sex != 'm') && (osoba.Sex != 'M'))
                        Console.WriteLine("\nInvalid Answer - Try Again");

                    while ((osoba.Sex != 'f') && (osoba.Sex != 'F') && (osoba.Sex != 'm') && (osoba.Sex != 'M')) ;

                    if ((osoba.Sex == 'f') || (osoba.Sex == 'F'))
                        osoba.Gender = 0.6;
                    else if ((osoba.Sex == 'm') || (osoba.Sex == 'M'))
                        osoba.Gender = 0.7;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }
            }
            while (true)

            {
                try
                {
                    Console.WriteLine("imię: ");
                    osoba.Imie = Console.ReadLine();
                    //     Console.WriteLine($"{osoba.Imie}");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            }
            while (true)

            {
                try
                {
                    Console.WriteLine("Nazwisko: ");

                    osoba.Nazwisko = Console.ReadLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            }
            while (true)

            {
                try
                {
                    Console.WriteLine("Wiek: ");
                    osoba.Wiek = int.Parse(Console.ReadLine());
                    break;
                
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            }

            while (true)

            {
                try
                {
                    Console.WriteLine("Waga: ");
                    osoba.Waga = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                  }

            }



            while (true)

            {
                try
                {
                    Console.WriteLine("Ile Kufli piwa wypiles 250ml: ");
                    alkohole.Piwo = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            } while (true)

            {
                try
                {
                    Console.WriteLine("Ile kieliszków Wodki 40ml wypiles: ");
                    alkohole.Wodka = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            } while (true)

            {
                try
                {
                    Console.WriteLine("Ile kieliszków whisky 40ml wypiles: ");
                    alkohole.Whisky = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }

            } while (true)

            {
                try
                {
                    Console.WriteLine("Ile kieliszków wina 100ml wypiles: ");
                    alkohole.Wino = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadź dane jeszcze raz");
                }
            }
            double wynik = ((alkohole.Whisky + alkohole.Piwo + alkohole.Wino + alkohole.Wodka) / (osoba.Gender * osoba.Waga));
            Console.WriteLine($" wynik: {wynik}promila") ;
            Console.ReadKey();

            StreamWriter SW = new StreamWriter(@"C:\Users\Konrad.Mielnik\Desktop\plik.txt", true);
            {
                SW.Write(" Imie: ");
                SW.Write(osoba.Imie);
                SW.Write(" , ");
                SW.Write(" Nazwisko: ");
                SW.Write(osoba.Nazwisko);
                SW.Write(" , ");
                SW.Write(" Plec: ");
                SW.Write(osoba.Sex);
                SW.Write(" , ");
                SW.Write(" Waga: ");
                SW.Write(osoba.Waga);
                SW.Write(" , ");
                SW.Write(" Wiek: ");
                SW.Write(osoba.Wiek);
                SW.Write(" , ");
                SW.Write(" promile: ");
                SW.Write(wynik);
                SW.WriteLine("");
                
            }
            SW.Close();
        }

    }

}       
    

