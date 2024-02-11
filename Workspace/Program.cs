// See https://aka.ms/new-console-template for more information












using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello World!");

            {
                SelamVer(isim: "Sema");
                SelamVer(isim: "Anıl");
                SelamVer(isim: "Zeynep");
                SelamVer();





                int sonuc = Topla();




                //Arrays 

                string ogrenci1 = "Sema";
                string ogrenci2 = "Anıl";
                string ogrenci3 = "Zeynep";



                string[] ogrenciler = new string[3];
                ogrenciler[0] = "Sema";
                ogrenciler[1] = "Anıl";
                ogrenciler[2] = "Zeynep";


                for (int i = 0; i <  ogrenciler.Length; i++)
                {
                    Console.WriteLine(ogrenciler[i]);

                }





                //Referans Tipler
                string[] sehirler1 = new[] { "Amasya", "İstanbul", "Bursa" };
                string[] sehirler2 = new[] { "ESkişehir", "Aydın", "Samsun" };

    


    
                sehirler2 = sehirler1;
                sehirler1[0] = "Adana";


                Console.WriteLine(sehirler2[0]);




                Person person1 = new Person();
                person1.FirstName ="Semaha";
                person1.LastName = "Dündar";
                person1.DateOfBirthYear =1985;
                person1.NationalIdentity = 321;


                Console.WriteLine(sehirler2[0]);

                 Person person2= new Person();
                 person2.FirstName = "Zeynep";




                foreach (string sehir in sehirler1)
                {
                    Console.WriteLine(sehir);
                }



                List<string> yenisehirler1 = new() { "Amasya*", "İstanbul^+", "Bursa-" };
                yenisehirler1.Add(item: "İzmir");
                foreach (var sehir in yenisehirler1)
                {
                    Console.WriteLine(sehir);
                }




                PttManager pttManager = new PttManager(new PersonManager());
                pttManager.GiveMask(person1);




                Console.ReadLine();


            }


            static void SelamVer(string isim = "isimsiz")
                {




                    Console.WriteLine("Merhaba" + isim);




                }

                static int Topla(int sayi1 = 6, int sayi2 = 8)
                {

                    int sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplam :" + sonuc.ToString());
                    return sonuc;

                }







            














//double tutar = 100000;// db den gelen 
//int sayi = 1000;
//bool girisYapmisMi = true;





//Console.WriteLine(tutar* 1.18);

//Console.WriteLine(mesaj);

//Console.WriteLine(mesaj);


//Console.WriteLine(mesaj);


//Console.WriteLine(mesaj);











//Vatandas vatandas1 = new Vatandas();


//public class Vatandas
//{
//    public string Ad { get; set; }

//    public string Soyad  { get; set; }

//    public int DogumYili  { get; set; }
//    public long TcNo{ get; set; }
//}
