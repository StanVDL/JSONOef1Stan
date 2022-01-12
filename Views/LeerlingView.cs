using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONOef1Stan.Views
{
    class LeerlingView
    {
        public static Classes.Models.Leerling LeerlingToevoegen()
        {
            var leerling = new Classes.Models.Leerling();
            Console.Write("Vul naam van leerling in: ");
            leerling.Naam = Console.ReadLine();

            Console.Write("Vul leeftijd van leerling in: ");
            leerling.Leeftijd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vul klas van leerling in: ");
            leerling.Klas = Console.ReadLine();

            return leerling;
        }

        public static void ToonLeerling(Classes.Models.Leerling leerling)
        {
            Console.WriteLine("Naam: " + leerling.Naam);
            Console.WriteLine("Leeftijd: " + leerling.Leeftijd);
            Console.WriteLine("Klas: " + leerling.Klas);
        }
        
        public static List<Classes.Models.Leerling> ZoekLeerling(List<Classes.Models.Leerling> Leerlingen)
        {
            Console.WriteLine("Vul naam leerling in: ");
            var zoekterm = Console.ReadLine();

            var resultaat = Leerlingen.Where(Leerlingen => Leerlingen.Naam.StartsWith(zoekterm));

            return resultaat.ToList();
        }

        public static void ToonLijst(List<Classes.Models.Leerling> Leerlingen)
        {
            Leerlingen.ForEach(item =>
            {
                ToonLeerling(item);
                Console.WriteLine();
            });
        }
    }
}
