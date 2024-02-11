using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Açıkgöz Panele Hoş Geldiniz");
            Console.WriteLine("Lütfen ilerlemek için Kullanıcı Adınızı ve Şifrenizi Giriniz..");
            Console.WriteLine("Kullanıcı Adınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("Şifreniz: ");

            string password = Console.ReadLine();

            Admin admin = new Admin();

            if (name == admin.Name && password == admin.Password)
            {
                Console.WriteLine($"{admin.Name} Başarıyla giriş yapıldı..");
            }

            Console.WriteLine("Yapmak istediğiniz işlemleri seçiniz.");
            Console.WriteLine("1. Yeni bir çalışan ekleme");
            Console.WriteLine("2. Aktif bir çalışanı sistemden silme");
            Console.WriteLine("3. Aktif çalışanları görme");
            Console.WriteLine("4. Sistemden Çıkış Yapma");

            int islem = Convert.ToInt32(Console.ReadLine());

            PersonelManager personAdmin = new PersonelManager();

            while (islem != 4)
            {
                if (islem == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen eklemek istediğiniz Çalışanın Bilgilerini yazın veya 'exit' yazarak sistemden çıkış yapın ");
                        string calisanAdi = Console.ReadLine();

                        if (calisanAdi.ToLower() == "exit")
                        {
                            break;
                        }

                        personAdmin.CalisanEkle(calisanAdi);

                    }
                }
                else if (islem == 3)
                {
                    personAdmin.CalisanListe();
                }

                Console.WriteLine("Yapmak istediğiniz işlemleri seçiniz.");
                Console.WriteLine("1. Yeni bir çalışan ekleme");
                Console.WriteLine("2. Aktif bir çalışanı sistemden silme");
                Console.WriteLine("3. Aktif çalışanları görme");
                Console.WriteLine("4. Sistemden Çıkış Yapma");

                islem = Convert.ToInt32(Console.ReadLine());



            }

            Console.WriteLine("Uygulamadan çıkılıyor...");


        }


        class Admin
        {
            public string Name { get; set; }
            public string Password { get; set; }

            public Admin()
            {
                Name = "admin";
                Password = "admin";
            }

        }
        class PersonelManager
        {
            private string[] calisanlar = new string[100];
            private int calisanSayisi = 0;

            public void CalisanEkle(string calisanAdi)
            {
                calisanlar[calisanSayisi] = calisanAdi;
                calisanSayisi++;
                Console.WriteLine(' ' + calisanAdi + " adlı çalışan başarıyla eklendi..");
            }

            public void CalisanListe()
            {
                Console.WriteLine("Aktif olarak çalışanlar");
                for (int i = 0; i < calisanSayisi; i++)
                {
                    Console.WriteLine((i + 1) + ". " + calisanlar[i]);
                }
            }

        }


    }
}
