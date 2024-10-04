using System;

namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // 10'a eşit mi, küçük mü, büyük mü kontrolü
            if (number == 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
            }
            else if (number < 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
            }

            // Çift mi, tek mi kontrolü
            if (number % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
        }
    }
}
