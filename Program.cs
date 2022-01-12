using JSONOef1Stan.Classes;
using JSONOef1Stan.Views;
using System;

namespace JSONOef1Stan
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Datastore2();

            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Voeg een leerling toe", () => store.AddLeerling(LeerlingView.LeerlingToevoegen()));

            menu.AddOption('2', "Toon alle leerlingen", () => LeerlingView.ToonLijst(store.Leerlingen));

            menu.AddOption('3', "Zoek een leerling", () => LeerlingView.ToonLijst(LeerlingView.ZoekLeerling(store.Leerlingen)));

            menu.Start();

            store.SaveData();

            Console.ReadKey();
        }
    }
}
