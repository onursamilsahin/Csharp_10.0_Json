using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_10._0_Json
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Personel> Personellerim=new List<Personel>();



            for (int i = 0; i < 1000; i++)
            {
                
                Personel temp=new Personel();


                temp.ID=new Guid();

                temp.Isim = FakeData.NameData.GetFirstName();
                temp.Soyisim = FakeData.NameData.GetSurname();
                temp.Email = $"{temp.Isim}.{temp.Soyisim}" + $"{FakeData.NetworkData.GetDomain()}";

                temp.Sehir = FakeData.PlaceData.GetCity();
                temp.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();

                Personellerim.Add(temp);
            }

                Console.WriteLine("bilgileriniz json formatında C:\\JsonIslemlerim\\persnellerim.json olarak kayıt edilecektir. ");

         
              if (Directory.Exists("c:\\JsonIslemlerim\\"))
                {
                    //ilgili klasör var ise herhangi bir işlem yapma
                }
                else
                {
                    Directory.CreateDirectory("c:\\JsonIslemlerim\\"); //klasör yok ise burada klasör oluşturuluyor
                }


                string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personellerim);//Elimizde bulunan data buradaki nesneler sayesinde json formatına çevriliyor.
            

                File.WriteAllText("c:\\JsonIslemlerim\\Personellerim.json",JsonPersonellerim);//json formatında elimizde buluna datalar File.WriteALLtext ile dosyaya yazılıyor.

                Console.WriteLine("Json yazma işlemi tamamlandı.");


            Console.ReadLine();


















        }
    }
}
