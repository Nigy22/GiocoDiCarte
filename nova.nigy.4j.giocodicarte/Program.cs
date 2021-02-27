using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nova.nigy._4j.giocodicarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta carta1 = new Carta(3, 4);
            Carta carta2 = new Carta(1, 11);

            carta1.Visualizza();
            carta2.Visualizza();
            carta1.Vince(carta2);
           
            Console.ReadLine();
        }
    }
    class Carta
    {
        public int _seme;  //1=picche, 2 =fiori, 3=quadri, 4 cuori
        public int _valore;
        public Carta(int seme, int valore)
        {
            _seme = seme;
            _valore = valore;
        }
        public void Visualizza()
        {
            if (_valore != 11 && _valore != 12 && _valore != 13 && _valore != 14)
            {
                if (_seme == 1)
                {
                    Console.WriteLine(_valore + " di picche");
                }
                if (_seme == 2)
                {
                    Console.WriteLine(_valore + " di fiori");
                }
                if (_seme == 3)
                {
                    Console.WriteLine(_valore + " di quadri");
                }
                if (_seme == 4)
                {
                    Console.WriteLine(_valore + " di cuori");
                }
            }
            else
            {
                if(_valore==11)
                {
                    if (_seme == 1)
                    {
                        Console.WriteLine("jack di picche");
                    }
                    if (_seme == 2)
                    {
                        Console.WriteLine("jack di fiori");
                    }
                    if (_seme == 3)
                    {
                        Console.WriteLine("jack di quadri");
                    }
                    if (_seme == 4)
                    {
                        Console.WriteLine("jack di cuori");
                    }
                }
                if (_valore == 12)
                {
                    if (_seme == 1)
                    {
                        Console.WriteLine("regina di picche");
                    }
                    if (_seme == 2)
                    {
                        Console.WriteLine("regina di fiori");
                    }
                    if (_seme == 3)
                    {
                        Console.WriteLine("regina di quadri");
                    }
                    if (_seme == 4)
                    {
                        Console.WriteLine("regina di cuori");
                    }
                }
                if (_valore == 13)
                {
                    if (_seme == 1)
                    {
                        Console.WriteLine("re di picche");
                    }
                    if (_seme == 2)
                    {
                        Console.WriteLine("re di fiori");
                    }
                    if (_seme == 3)
                    {
                        Console.WriteLine("re di quadri");
                    }
                    if (_seme == 4)
                    {
                        Console.WriteLine("re di cuori");
                    }
                }
                if (_valore == 14)
                {
                    if (_seme == 1)
                    {
                        Console.WriteLine("asso di picche");
                    }
                    if (_seme == 2)
                    {
                        Console.WriteLine("asso di fiori");
                    }
                    if (_seme == 3)
                    {
                        Console.WriteLine("asso di quadri");
                    }
                    if (_seme == 4)
                    {
                        Console.WriteLine("asso di cuori");
                    }
                }

            }
        }
        public void Vince(Carta carta2)
        {
            if(_valore>carta2._valore)
            {
                Console.WriteLine("La prima carta è vincente");
            }
            if (_valore < carta2._valore)
            {
                Console.WriteLine("La seconda carta è vincente");
            }
            if (_valore == carta2._valore)
            {
                if(_seme>carta2._seme)
                {
                    Console.WriteLine("La prima carta è vincente");
                }
                else
                {
                    Console.WriteLine("La seconda carta è vincente");
                }
            }
            Console.ReadLine();
        }
    }       
}

