
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // open file stream to file
            Stream cf = File.OpenRead("F:\\Downloads\\quicknoodle.yml");
            StreamReader s = new StreamReader(cf);
            // read stream and set variable
            string yaml = s.ReadToEnd();
            
            // Init for deserializer
            var deserializer = new Deserializer();
            
            // deserialize  yaml file
            var yamlObject = deserializer.Deserialize<dynamic>(yaml);




            //s tart pmotelr
            string json = JsonConvert.SerializeObject(yamlObject);

            dynamic j =  JsonConvert.DeserializeObject<dynamic>(json);

            
            Console.WriteLine(j["bookmarks"]);
            */
            int[] i = HexColorDecoder.DecodeHexColor("#00ff11");
            Array.ForEach(i, Console.WriteLine);
            Console.ReadKey();
        }
    }

}
