using System;

namespace last_exam
{

    static class Sinav
    {
        public static  void Soru_Bir()
        {
            Random _random = new Random();
            Console.WriteLine("Sutun Giriniz");var sutun= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satır Giriniz"); var satır = Convert.ToInt32(Console.ReadLine());
            int[,] xy = new int[sutun, satır];

            int toplam = 0;
            int k = 0;
            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satır; j++)
                {
                    xy[i,j] = _random.Next(1000);
                    if((i == 0 || i == sutun - 1)|| (j == 0 || j == satır - 1))
                    {
                        Console.WriteLine($"{xy[i, j]} i:{i} j:{j} sayısı:{++k}");
                        toplam += xy[i, j];
                    }
                }
            }
            Console.WriteLine($"Toplam : {toplam}");
        }


        public static bool lynchbell(int sayi)
        {

            String sayiStr = $"{sayi}";
            for (int i = 0; i < sayiStr.Length; i++)
            {  // sayının bütün rakamlarına bölen metod
                if (sayiStr[i] != '0')
                { // ArithmeticException önlemi
                    if (sayi % Convert.ToInt32($"{sayiStr[i]}") != 0)
                    {  // eğer o anki rakama bölümü 0 değilse lynchbell değil
                        return false;
                    }
                }
            }

            return true;

        }

        public static void Soru_Iki()
        {
            Console.WriteLine("Limit Giriniz"); var limit= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < limit; i++)
            {
                if (lynchbell(i))
                {
                    Console.WriteLine($"Sayı:{i} Lychbell sayısı");
                }
            }

        }

        public static void Soru_Uc()
        {
            Random _random = new Random();
            Console.WriteLine("Sutun Giriniz"); var sutun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satır Giriniz"); var satır = Convert.ToInt32(Console.ReadLine());
            int[,] xy = new int[sutun, satır];

            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satır; j++)
                {
                    xy[i, j] = _random.Next(1000);
                    Console.WriteLine($"Değer:{xy[i, j]} i:{i} j:{j}");
                }
            }

            Console.WriteLine("1- Sütün değişimi");
            Console.WriteLine("2- Satır değişimi");
            Console.WriteLine("Seçiminiz"); var seçim = Convert.ToInt32(Console.ReadLine());


            switch (seçim)
            {
                case 1:
                    Console.WriteLine("Istenen 1. sutun girin"); var sutun_secim_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Istenen 2. sutun girin"); var sutun_secim_2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < satır; i++)
                    {
                        int temp = xy[i, sutun_secim_1];
                        xy[i, sutun_secim_1] = xy[i, sutun_secim_2];
                        xy[i, sutun_secim_2] = temp;
                    }

                    break;

                case 2:
                    Console.WriteLine("Istenen 1. satır girin"); var satır_secim_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Istenen 2. satır girin"); var satır_secim_2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < sutun; i++)
                    {
                        int temp = xy[satır_secim_1, i];
                        xy[satır_secim_1, i] = xy[satır_secim_2, i];
                        xy[satır_secim_2, i] = temp;
                    }
                    break;

                default:
                    break;
            }

            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satır; j++)
                {
                    Console.WriteLine($"Değer:{xy[i, j]} i:{i} j:{j}");
                }
            }


        }

        public static void Soru_Dort()
        {


            Console.WriteLine("Ilk Sayıyı Giriniz.");
            int Sayi1 = Convert.ToInt32(Console.ReadLine());


            int onlar1 = Sayi1 / 10;
            int birler1 = Sayi1 % 10;

            Console.WriteLine("Ikinci Sayıyı Giriniz.");
            int Sayi2 = Convert.ToInt32(Console.ReadLine());

            int onlar2 = Sayi2 / 10;
            int birler2 = Sayi2 % 10;


            if (birler1 + birler2 == 10 && onlar1 == onlar2)
                Console.WriteLine("Sayılar bağdaşıktır");
            else
                Console.WriteLine("Sayılar bağdaşık değildir");


        }


        public static int PrimeMı(int sayı, bool artıyorMu)
        {
            while (true)
            {
                bool asalMı = true;
                if (artıyorMu)
                {
                    sayı = sayı + 1;
                }
                else
                {
                    sayı = sayı - 1;
                }

                int sayınınKoku = (int)Math.Sqrt(sayı);

                for (int i = 2; i <= sayınınKoku; i++)
                {
                    if (sayı % i == 0)
                    {
                        asalMı = false;
                        break;
                    }
                }
                if (asalMı)
                    return sayı;
            }
        }

     
        public static void Soru_Bes()
        {
            Console.WriteLine("Sayımızı Giriniz"); int sayımız = Convert.ToInt32(Console.ReadLine());

            int ufakEnYakınAsalBüyük = PrimeMı(sayımız, true);
            int ufakEnYakınAsalKüçük = PrimeMı(sayımız, false);

            bool araAsalMı = (ufakEnYakınAsalKüçük + ufakEnYakınAsalBüyük) / 2 == sayımız;

            if (araAsalMı)
            {
                Console.WriteLine("Sayımız bir ara asaldır");
            }
            else
            {
                Console.WriteLine("Sayımız bir ara asal değildir.");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Sinav.Soru_Iki();

            Console.ReadLine();
        }
    }
}
