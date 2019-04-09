using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {

        //Stan (zmienne - pola)
        List<float> ratings; // Lista wszystkich ocen


        //Zachowania

        public void AddRating(float rating) // Dodawanie nowej oceny do listy
        {
            ratings.Add(rating); 
        }

        public float CalculateAverage() // Wyliczanie i wyświetlanie średniej ocen
        {
            float sum = 0, avg = 0;
            foreach (var item in ratings)
            {
                sum += item;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float GiveMaxRating() // Odnalezienie i wyświetlenie maksymalnej oceny
        {
           return ratings.Max();
        }

        public float GiveMinRating() // Odnalezienie i wyświetlenie minimalnej oceny
        {
            return ratings.Min();
        }
    }
}
