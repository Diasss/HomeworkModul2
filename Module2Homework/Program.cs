using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            task10();
        }
        static void taskLuckyTicket()
        {
            int ticket = Int32.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                sum1 += (ticket % 10);
                ticket = ticket / 10;
            }
            for (int i = 0; i < 3; i++)
            {
                sum2 += ticket % 10;
                ticket = ticket / 10;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Билет счастливый!");
            }
            else
                Console.WriteLine("Билет несчастливый!");   
        }
        static void task4()
        {
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            for (int i = A; i < B+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("\n");
            }
        }
        static void task5()
        {
            int num = Int32.Parse(Console.ReadLine());
            int k = 0;
            int temp = num;
            while (temp != 0)
            {
                temp = temp / 10;
                k++;
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("{0}", num % 10);
                num = num % 10;
            }
        }
        static void task6()

        {
            Random random = new Random();
            int[] arr = new int[3
];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = random.Next(3, 7);
                Console.Write("{0}  ", arr[i]);
            }
        }
        static void task25()
        {
            int num = Int32.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine("{0}", sum);
        }
        static void task16()
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("{0}", y);
        }
        static void task12()
        {
            int radius = Int32.Parse(Console.ReadLine());
            int a = Int32.Parse(Console.ReadLine());
            if (radius * radius * 3.14 > a * a)
            {
                Console.WriteLine("У круга площадь больше!");
            }
            else
                Console.WriteLine("У квадрата площадь больше!");
        }
        static void task13()
        { 

            double obem1 = Double.Parse(Console.ReadLine());
            double massa1 = Double.Parse(Console.ReadLine());
            double obem2 = Double.Parse(Console.ReadLine());
            double massa2 = Double.Parse(Console.ReadLine());
            if (massa1 / obem1 > massa2 / obem2)
            {
                Console.WriteLine("Плотность первого вещ-ва больше!");
            }
            else
                Console.WriteLine("Плотность второго вещ-ва больше!");
        }
        static void task10()
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Десятков = {0}, Единиц = {1}, Сумма цифр = {2}, Произведение цифр = {3}", num/10, num%10, num%10+num/10, num%10*num/10);
            
        }


    }
}
