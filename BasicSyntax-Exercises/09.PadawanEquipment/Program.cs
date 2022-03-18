using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double totalLigthsabers = Math.Ceiling(studentsCount* 1.1) ;
            double totalPrice = totalLigthsabers * lightsabersPrice + studentsCount * robesPrice + (studentsCount- studentsCount / 6) * beltsPrice;
            if (money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice-money:f2}lv more.");
            }
        }
    }
}
