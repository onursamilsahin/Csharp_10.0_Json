using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_10._1_jsonOku
{
    class Program
    {
        static void Main(string[] args)
        {
         string jsonOkunanData=File.ReadAllText("C:\\JsonIslemlerim\\Personellerim.json");




           List<Xobje> Data=Newtonsoft.Json.JsonConvert.DeserializeObject<List < Xobje > >(jsonOkunanData);


            foreach (var item   in Data)
            {
                Console.WriteLine("isim ve Soyisimler:{0}",item);   
                    
                
            }

            Console.ReadLine();


        }
    }
}
