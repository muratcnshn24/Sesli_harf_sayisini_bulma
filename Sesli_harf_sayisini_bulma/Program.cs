using System;

namespace Sesli_harf_sayisini_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //ifadenin okunmasi
            string ifade = Console.ReadLine();

            //Sesli Harf
            int sesliHarf = 0;

            for (int i = 0; i < ifade.Length; i++)
            {
                //kontrol
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö')     // || veya demek.

                    sesliHarf++;
            }


            Console.WriteLine("{0} ifadesinde {1} sesli harf var", ifade, sesliHarf);
        }
    }
}
