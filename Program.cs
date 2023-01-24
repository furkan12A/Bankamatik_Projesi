using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int hak = 2;

            string şifre = "ab18";
            int tutar = 0;
            int transfer = 10000;
            int egitim = 1000;
            int bakiye = 250;
            string giriş = "";
            int secim1 = -1;
        Menu:
        Dön:




            while (hak > 0)
            {
                hak--;
                Console.Write("Lütfen şifernizi giriniz :");
                giriş = Console.ReadLine();

                if (şifre == giriş)
                    break;

            }
            if (şifre == giriş)
            {
                Console.WriteLine("***Ana Menu***");
                Console.WriteLine("Para Çek -1 \nPara Yatir -2\nPara transferi için -3\nHavale için -4");
                Console.WriteLine("Ödemeler için\nBilgi güncelleme için-5 \nEğitim ödemeleri için:-6");
                secim1 = Convert.ToInt32(Console.ReadLine());



            }

            else if (hak == 0)
            {
                Console.WriteLine("Hatali Giriş Tekrar Giriniz");
            }



            if (secim1 == 1)
            {

                Console.WriteLine("Paraniz = " + bakiye);
                if (bakiye >= 250)
                {
                    Console.WriteLine("Paranizi Alabirsinzi");
                }
                else if (bakiye <= 250)
                {
                    Console.WriteLine("Yetersiz Bakiye");
                }
                Console.WriteLine("ana menü icin:9");
                Console.WriteLine("cıkmak icin:0");
                secim1 = Convert.ToInt32(Console.ReadLine());
                if (9 == secim1)
                {
                    goto Menu;
                }
                else if (0 == secim1)
                {
                    goto Dön;
                }
                else if (secim1 == 2)
                {
                    Console.WriteLine("Paraniz = " + bakiye);
                    Console.WriteLine("Kredi kartına yatırmak icin -1");
                    Console.WriteLine("Hesabiniza Yatirmak İçin -2");




                }
                Console.WriteLine("Ana Menüye dön 9");
                Console.WriteLine("Cikis 0");
                secim1 = Convert.ToInt32(Console.ReadLine());
                if (9 == secim1)
                {
                    goto Menu;
                }
                else if (0 == secim1)
                {
                    goto Dön;
                }




                if (secim1 == 3)
                {
                    Console.WriteLine("Para Transferi = " + transfer);
                    secim1 = Convert.ToInt32(Console.ReadLine());

                }

                if (secim1 == 4)
                {
                    Console.WriteLine(" Eğitim Ödemeleri = " + egitim);
                    Console.WriteLine("Ödeme onaylandi");
                    secim1 = Convert.ToInt32(Console.ReadLine());

                    if (9 == secim1)
                    {
                        goto Menu;
                    }

                    else if (0 == secim1)
                    {
                        goto Dön;
                    }

                    if (secim1 == 5)
                    {
                        Console.WriteLine("Elektirik faturasini girin lütfen");
                        string Islem;
                        Islem = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Kalan bakıyenız:" + (tutar));
                        Console.WriteLine("Ana Menu Dön :9");
                        Console.WriteLine("Ciskis :0 ");
                        secim1 = Convert.ToInt32(Console.ReadLine());
                        if (9 == secim1)
                        {
                            goto Menu;
                        }
                        else if (0 == secim1)
                        {
                            goto Dön;
                        }








                    }





                }

            }
















            Console.ReadLine();


        }
    }
}
