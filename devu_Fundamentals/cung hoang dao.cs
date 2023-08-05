using System;

namespace SimpleClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            do
            {
                int month = 0;
                int day = 0;
                while (true) 
                {
                    Console.WriteLine("Nhap ngay sinh: ");
                    day = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nhap thang sinh: ");
                    month = Convert.ToInt32(Console.ReadLine());

                    if (month == 2 && day >= 1 && day <= 28)
                    {
                        break;
                    }

                    if ((month == 4 || month == 6 || month == 9 || month == 11) && day >= 1 && day <= 30)
                    {
                        break;
                    }

                    if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day >= 1 && day <= 31)
                    {
                        break;
                    }

                    Console.WriteLine("Nhap ngay thang hop le");
                }

                //kiem tra va dua ra cung hoang dao tuong ung.
                string result = "";
                switch (month)
                {
                    case 1:
                        if(day >= 20)
                        {
                            result = "Bao Binh";
                        }
                        else
                        {
                            result = "Ma Ket";
                        }
                        break;

                    case 2:
                        if (day >= 19)
                        {
                            result = "Song Ngu";
                        }
                        else
                        {
                            result = "Bao Binh";
                        }
                        break;

                    case 3:
                        if (day >= 21)
                        {
                            result = "Bach Duong";
                        }
                        else
                        {
                            result = "Song Ngu";
                        }
                        break;
                }
                //dua ket qua

                Console.WriteLine("Ban thuoc cung {0}.", result );
                Console.WriteLine("==============================");
                Console.WriteLine("Nhap Y de tiep tuc, Nhap N de thoat.");
                choice = Console.ReadLine();
                if(choice.ToLower() == "n")
                {
                    System.Environment.Exit(0);
                }


            } while (true);
        }
    }
}
