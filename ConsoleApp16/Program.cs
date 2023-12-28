using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static string MyColor(int Color, string[] NameColor)
            {
                Console.WriteLine("Сколько у вас любимых цветов? ");

                Color = int.Parse(Console.ReadLine());

                NameColor = new string[Color];

                Console.WriteLine("Cкажите ваши цвета! ");

                for (int i = 0; i < Color; i++)
                {
                    NameColor[i] = Console.ReadLine();
                }

                return NameColor[Color];
            }

            static string MyPet(int ColvoPet, string[] NamePet)
            {
                Console.WriteLine("Сколько у вас магических животных? ");

                ColvoPet = int.Parse(Console.ReadLine());

                NamePet = new string[ColvoPet];

                Console.WriteLine("Cкажите имена (Имя) вашего (их) маг-животных ");

                for (int i = 0; i < ColvoPet; i++)
                {
                    NamePet[i] = Console.ReadLine();
                }


            }
            static void Anketka()
            {
                (string name, string family, int age, int pet, int Color) anketa;

                Console.WriteLine("Это самая обычная магическая Анкета, будь добры, выполняйте всё, что она молвит! ");

                Console.WriteLine("Ваше имя? ");

                anketa.name = Console.ReadLine();

                Console.WriteLine("Ваша фамилия? ");

                anketa.family = Console.ReadLine();

                Console.WriteLine("Будте добры, ваш возраст? (Только числами!) ");

                anketa.age = int.Parse(Console.ReadLine());

                Console.WriteLine("У вас есть маг-питомец или маг-питомцы? Выберете цифру \n 1)Да    2)Нет");

                anketa.pet = int.Parse(Console.ReadLine());

                if (anketa.pet == 1)
                {
                    MyPet();
                }

                else
                {
                    Console.WriteLine("Ничего страшного, если нет магического животного) ");
                }

                Console.WriteLine("У вас есть любимые цвета?  \n 1)Да    2)Нет");

                anketa.Color = int.Parse(Console.ReadLine());

                if (anketa.Color == 1)
                {
                    MyColor();
                }

                else
                {
                    Console.WriteLine("Ничего страшного, если нет любимого цвета) ");
                }

            }
        }
    }
}
