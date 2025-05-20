using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FajlokListabaOlvasasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> txtfajlok = new List<string>();
            string mappa = @"C:\Users\Admin\Desktop\School\SzTeszt\WPF_BevasarloLista\FajlokListabaOlvasasa\bin\Debug";
            if (Directory.Exists(mappa))
            {
                string[] fajlok =  Directory.GetFiles(mappa,"*.txt");
                foreach (var item in fajlok)
                {
                    txtfajlok.Add(System.IO.Path.GetFileName(item));
                }
                foreach (var item in txtfajlok)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen mappa");
            }
                Console.ReadKey();
        }
    }
}
