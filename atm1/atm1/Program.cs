using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1200, cekme = 0, yatırma = 0,fatura, islem;
            int hak = 3, girilen, elektrik=324,su=170, dogalgaz=509,internet=94;
            while (hak > 0)
            {
                Console.WriteLine("lütfen dört haneli şifrenizi giriniz: ");
                girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 1234)
                {
                    Console.WriteLine("şifreniz doğru"); break;
                }
                else hak--;
            }
            if (hak == 0)
            {
                Console.WriteLine("kartınız bloke olmuştur");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("1: bakiye sorgulama"); 
            Console.WriteLine("2: para çekme");
            Console.WriteLine("3: para yatırma");
            Console.WriteLine("4: fatura ödeme");
            Console.WriteLine("5: çıkış");
            Console.WriteLine("lütfen yapacağınız işlemi seçiniz: ");
            islem= Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1: Console.WriteLine("bakiyeniz: " + bakiye); break;

                case 2:
                    Console.WriteLine("bakiyeniz: " + bakiye);
                    Console.WriteLine("çekmek istediğiniz miktarı giriniz: ");
                    cekme = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        if (cekme > bakiye || cekme % 10 != 0 || cekme < 0)
                        {
                            Console.WriteLine("işleminiz yapılamamaktadır tekrar deneyiniz:");
                            cekme = Convert.ToInt32(Console.ReadLine()); continue;
                        }
                        break;
                    }
                    bakiye -= cekme;
                    Console.WriteLine("yeni bakiyeniz" + bakiye); break;
                case 3:
                    Console.WriteLine("bakiyeniz: " + bakiye);
                    Console.WriteLine("yatırmak istediğiniz para değerini giriniz: ");
                    yatırma = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatırma;
                    Console.WriteLine("yeni bakiyeniz: " + bakiye);
                    break;
                case 4:
                    Console.WriteLine("bakiyeniz: "+ bakiye);
                    Console.WriteLine("6: elektrik");
                    Console.WriteLine("7: su");
                    Console.WriteLine("8: doğalgaz");
                    Console.WriteLine("9: internet");
                    Console.WriteLine("ödemek istediğiniz faturayı seçiniz: ");
                    fatura=Convert.ToInt32(Console.ReadLine());
                    switch(fatura)
                    {
                        case 6: Console.WriteLine("elektrik faturanız {0} kadar", elektrik);
                            Thread.Sleep(2000);
                            bakiye -= elektrik;
                            elektrik = elektrik - elektrik;
                            Console.WriteLine("faturanız ödendi");
                            Console.WriteLine("kalan bakiye: "+bakiye);break;
                            case 7:
                            Console.WriteLine("su faturanız {0} kadar", elektrik);
                            Thread.Sleep(2000);
                            bakiye -= su;
                            su = su - su;
                            Console.WriteLine("faturanız ödendi");
                            Console.WriteLine("kalan bakiye: " + bakiye); break;
                            case 8:
                            Console.WriteLine("doğalgaz faturanız {0} kadar", elektrik);
                            Thread.Sleep(2000);
                            bakiye -= dogalgaz;
                            dogalgaz = dogalgaz - dogalgaz;
                            Console.WriteLine("faturanız ödendi");
                            Console.WriteLine("kalan bakiye: " + bakiye); break;
                            case 9:
                            Console.WriteLine("internet faturanız {0} kadar", elektrik);
                            Thread.Sleep(2000);
                            bakiye -= internet;
                            internet = internet - internet;
                            Console.WriteLine("faturanız ödendi");
                            Console.WriteLine("kalan bakiye: " + bakiye);
                            break;
                           

                    }break;
                case 5:
                    string cıkıs;
                        do { 
                    Console.WriteLine("çıkış yapmak için 0 ı tuşalyınız");
                        cıkıs= Console.ReadLine();
                            }while(cıkıs!="0"); break;    


            }


        }
    }
}
