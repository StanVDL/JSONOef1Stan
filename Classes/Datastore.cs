using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONOef1Stan.Classes
{
    class Datastore
    {
        public List<Models.Leerling> Leerlingen { get; set; } = new List<Models.Leerling>();
    }

    class Datastore2
    {
        Datastore data;

        public List<Models.Leerling> Leerlingen => data.Leerlingen;

        public void AddLeerling(Models.Leerling Leerlingen)
        {
            data.Leerlingen.Add(Leerlingen);
        }

        public Datastore2()
        {
            if (System.IO.File.Exists("data.json"))
            {
                var input = System.IO.File.ReadAllText("data.json");
                data = JsonConvert.DeserializeObject<Datastore>(input);
            }
            else
            {
                data = new Datastore();
            }
        }

        public void SaveData()
        {
            var content = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText("data.json", content);
        }
    }
}

