using System;


namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary= new Diary();
            for (; ; )// Nieskończona pętla uzupełniająca oceny w dzienniku
            {
                Console.WriteLine("Podaj swoją ocenę z zakresu 1 - 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(),out rating); // Próba parsowania string na float
                // Warunek wyjścia - liczba 11
                if (rating == 11)
                {
                    break;
                }
                // Sprawdzanie poprawności wprowadzonych danych
                if (result)
                {
                    if (rating >= 1 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Ocena z poza zakresu");
                    }

                }
                else
                {
                    Console.WriteLine("Nie podano liczby");
                }
                
            }
          
            // Wyświetlanie danych
            Console.WriteLine("Średnia podanych ocen to :"+ diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to :" + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to :" + diary.GiveMinRating());
            Console.ReadKey();
            
        }
    }
}
