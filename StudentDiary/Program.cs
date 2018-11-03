using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.Write("Podaj ocene z zakresu 1 do 10 : ");
                float rating;
                bool result = float.TryParse (Console.ReadLine(), out rating);

                if (result)
                {
                    if (rating > 0 && rating < 11)
                        diary.AddRating(rating);
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba");
                        break;
                    }
                }
            }

            Console.WriteLine("Srednia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyzsza ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najnizsza ocena to: " + diary.GiveMinRating());

            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();
        }
    }
}
