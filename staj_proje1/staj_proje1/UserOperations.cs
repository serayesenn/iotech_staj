using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje1
{
    internal class UserOperations
    {

        private int cardpassword;



        public void login()
        {
            Console.WriteLine("KARTINIZIN ŞİFRESİNİ GİRİNİZ");
            int password = int.Parse(Console.ReadLine());
            cardpassword = password;
        }
        public void PasswordCheck()
        {
            if (cardpassword == 12345)
            {
                Console.WriteLine("ŞİFRE DOĞRU");
                Processes();

            }
            else
            {
                Console.WriteLine("ŞİFRE YANLIŞ");
            }
        }

        public int Processes()
        {

            int selection;
            int balance = 1000;
            int amount;

            Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");
            Console.WriteLine("1. BAKİYE SORGULAMA");
            Console.WriteLine("2. PARA ÇEKME");
            Console.WriteLine("3. PARA YATIRMA");
            Console.WriteLine("4. HAVALE");
            Console.WriteLine("5. KART İADE");

            selection = int.Parse(Console.ReadLine());

            switch (selection)
            {

                case 1:
                    Console.WriteLine(balance);
                    Reprocess();
                    return 1;

                case 2:
                    Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI TUŞLAYINIZ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine("BAKİYENİZ YETERLİ OLMADIĞI İÇİN İŞLEM GERÇEKLEŞTİRİLEMİYOR");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine("İŞLEMİNİZ GERÇEKLEŞTİRİLİYOR...");
                        Console.WriteLine("PARAYI HAZNESİNDEN ALINIZ");
                        Console.WriteLine("MEVCUT BAKİYE: " + balance);
                        Reprocess();
                    }
                    return 1;

                case 3:
                    Console.WriteLine("YATIRMAK İSTEDİĞİNİZ TUTARI TUŞLAYINIZ");
                    amount = int.Parse(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine("İŞLEMİNİZ GERÇEKLEŞTİRİLİYOR...");
                    Console.WriteLine("PARA YATIRMA İŞLEMİ BAŞARILI");
                    Console.WriteLine("MEVCUT BAKİYE: " + balance);
                    Reprocess();
                    return 1;

                case 4:
                    Console.WriteLine("HAVALE YAPMAK İSTEDİĞİNİZ TUTARI TUŞLAYINIZ:");
                    amount = int.Parse(Console.ReadLine());
                    string account1 = "A";
                    string account2 = "B";
                    string account3 = "C";

                    if (amount > balance)
                    {
                        Console.WriteLine("BAKİYENİZ YETERSİZ OLDUĞU İÇİN İŞLEM GERÇEKLEŞTİRİLEMİYOR");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine("HAVALE YAPMAK İSTEDİĞİNİZ HESABI SEÇİNİZ:");
                        Console.WriteLine(account1);
                        Console.WriteLine(account2);
                        Console.WriteLine(account3);
                        string choose = Console.ReadLine();

                        if (choose == account1)
                        {
                            Console.WriteLine(account1 + " HESABINA HAVALE İŞLEMİ GERÇEKLEŞTİRİLDİ");
                        }

                        else if (choose == account2)
                        {
                            Console.WriteLine(account2 + " HESABINA HAVALE İŞLEMİ GERÇEKLEŞTİRİLDİ");
                        }
                        else if (choose == account3)
                        {
                            Console.WriteLine(account3 + " HESABINA HAVALE İŞLEMİ GERÇEKLEŞTİRİLDİ");
                        }
                        else
                        {
                            Console.WriteLine("YANLIŞ YA DA EKSİK BİR SEÇİM, İŞLEMİNİZ GERÇEKLEŞTİRİLEMEDİ");
                        }
                    }

                    Console.WriteLine("MEVCUT BAKİYE: " + balance);
                    Reprocess();


                    return 1;

                case 5:
                    Console.WriteLine("KARTINIZ İADE EDİLİYOR...");
                    return 1;

                default:
                    Console.WriteLine("YANLIŞ YA DA EKSİK TUŞLAMA!");
                    Reprocess();
                    return 1;

            }



            return 1;
        }

        public void Reprocess()
        {
            Console.WriteLine("TEKRAR İŞLEM YAPMAK İSTİYOR MUSUNUZ?");
            Console.WriteLine("EVET İÇİN 1, HAYIR İÇİN 0 TUŞLAYINIZ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Processes();
            }
            else if (secim == 0)
            {
                Console.WriteLine("KARTINIZ İADE EDİLİYOR...");
            }
            else
            {
                Console.WriteLine("İŞLEM TANIMLANAMADI, LÜTFEN DOĞRU SEÇİM YAPINIZ!");
                Reprocess();
            }
        }
    }
}
