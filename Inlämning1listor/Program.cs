using System;
namespace inlämning1listor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här får du skriva in valfritt antal namn, avsluta med tom rad");

            List<string> lista = new List<string>();

            string nyttNamn = " ";
            while (nyttNamn != "")
            {
                Console.WriteLine("Skriv in ett namn");
                nyttNamn = Console.ReadLine();
                if (nyttNamn != "")
                {
                    lista.Add(nyttNamn);
                }
            }

            lista.Sort();

            Console.WriteLine("Här är namnen i omvänd bokstavsordning");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }

        }
    }
}