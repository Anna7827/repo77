using System;

namespace My_project
{
    class MainClass
    {

     //5.1.Напишіть функцію, яка виводить табличку множення для заданого числа.
						
        static void MultiplicationTable(int n)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number, please : ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            MultiplicationTable(UserNumber);
            Console.ReadKey();
        }
    }
}
