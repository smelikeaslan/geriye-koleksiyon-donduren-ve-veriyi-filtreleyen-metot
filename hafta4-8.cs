using System;
using System.Collections.Generic;

namespace VeriFiltreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "elma", "armut", "kiraz", "karpuz", "muz", "ananas" };

            List<string> filtrelenmisKelimeler = Filtrele(kelimeler);

            Console.WriteLine("Uzunluğu 5 karakterden büyük kelimeler:");
            foreach (string kelime in filtrelenmisKelimeler)
            {
                Console.WriteLine(kelime);
            }
        }

        static List<string> Filtrele(string[] dizi)
        {
            List<string> sonuc = new List<string>();

            foreach (string eleman in dizi)
            {
                if (eleman.Length > 5)
                {
                    sonuc.Add(eleman);
                }
            }

            return sonuc;
            Console.ReadKey();
        }
    }
}