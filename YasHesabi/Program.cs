// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.Write("Arabanızın yaşını girin (Çıkmak için -1 girin): ");
            int arabaYasi = Convert.ToInt32(Console.ReadLine());

            if (arabaYasi == -1)
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            string durum = ArabaDurumunuBelirle(arabaYasi);
            Console.WriteLine(durum);
        }
    }

    static string ArabaDurumunuBelirle(int arabaYasi)
    {
        if (arabaYasi < 0 || arabaYasi > 30)
        {
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
        else if (arabaYasi <= 10)
        {
            return "Arabanız yeni";
        }
        else if (arabaYasi <= 20)
        {
            return "Servise götürmeniz gerekebilir";
        }
        else
        {
            return "Arabanız hurdaya çıkabilir";
        }
    }
}

