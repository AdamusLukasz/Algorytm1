using System;
using System.Collections.Generic;

namespace Algorytm1
{
    public class Program
    {

        public static string[] Algorytm(string word)
        {
            //No to mamy pierwsze zadanko na dzisiaj.
            //Wieść gminna niesie, że kiedyś to zadanie pojawiło się na rekrutacji do Microsoftu 😉

            //Napisz program konsolowy, który przyjmie w jednym argumencie ciąg znaków(słowo, zdanie itp.)
            //Dla podanego ciągu wyświetl wszystkie możliwe podzbiory tego ciągu.

            //Przykład
            //Podany zostanie ciąg
            //xyz


            //Zwróć ze swojej aplikacji listę:
            //x
            //y
            //z
            //xy
            //xz
            //yz
            //xyz


            //UWAGA
            //Zwróć uwagę, że ciąg
            //zx
            // nie będzie prawidłowy, ponieważ jest odwróconym podzbiorem.

            int x = word.Length;
            int y = (x * x) / 2;

            List<String> words = new List<string>();

            for (int j = 0; j < y; j++)
            {
                int count = 0;
                for (int i = 0; i < x - j; i++)
                {
                    words.Add(word.Substring(j, i + 1));
                    count++;
                }
            }
            return words.ToArray();
        }

        static void Main(string[] args)
        {

        }
    }
}
