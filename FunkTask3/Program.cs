using System;
using System.Text;

namespace FunkTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int number = GetNumber();

            Console.Clear();
            Console.WriteLine($"Отлично, ты сделал все правильно, ввел число {number}!");
            
        }
        
        static int GetNumber() 
        {
            int number = 0;
            string userEntry = "";
            bool isWork = true;
            bool isEntryNumber;

            Console.WriteLine("Добрый день! Попробуем преобразовать твой ввод в число?");

            while (isWork == true)
            {
                Console.Write("Введи число для пробы: ");
                userEntry = Console.ReadLine();

                isEntryNumber = int.TryParse(userEntry, out number);

                if (isEntryNumber == true)
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Ты чё пёс число ввести не можешь? Ещё раз давай!");
                }
            }

            return number;
        }
    }
}
