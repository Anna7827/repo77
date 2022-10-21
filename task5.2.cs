using System;
namespace My_project
{
    class MainClass
    {
        //5.2. Напишіть функцію, яка конвертує відстань у кілометрах у милі.
        static float KonvertDistanceToMile(float km)
        {
            float mile = 0.621f;
            return km * mile;
        }
        public static void Main(string[] args)
        {
            Console.Write("Dear User, enter the distance in kilometers, please : ");
            float km = float.Parse(Console.ReadLine());
            Console.WriteLine("It's " + KonvertDistanceToMile(km) + " miles");
            Console.ReadKey();
        }
    }
}
