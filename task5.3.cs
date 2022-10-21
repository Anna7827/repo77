using System;
namespace My_project
{
    class MainClass
    {
	//5.3. Напишіть функцію, яка підносить число до степеня, не використовуючи при цьому вбудовані математичні функції.
						
        static int FunctionPower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number, please");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power of the number, please");

            int power = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is equal " + FunctionPower(number, power) + " ");
            Console.ReadKey();
        }
    }
}
