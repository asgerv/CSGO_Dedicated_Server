using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSGO_Dedicated_Server.Utilities
{
    class Settings
    {
        public string Path { get; set; }
        public int GameMode { get; set; }
        public string Map { get; set; }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(@".\settings.txt", json);
        }
    }
}
