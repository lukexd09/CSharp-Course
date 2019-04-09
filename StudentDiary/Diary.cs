using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {

        //Stan (zmienne - pola)
        List<float> ratings = new List<float>(); // Lista wszystkich ocen


        //Zachowania
        /// <summary>
        /// Adding rating to array
        /// </summary>
        /// <param name="rating">New rating</param>
        public void AddRating(float rating) // Dodawanie nowej oceny do listy
        {
            ratings.Add(rating); 
        }
        /// <summary>
        /// Sum up every number and then divide by the number of all numbers
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Return the biggest number
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating() // Odnalezienie i wyświetlenie maksymalnej oceny
        {
           return ratings.Max();
        }
        /// <summary>
        /// Return the smallest number
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating() // Odnalezienie i wyświetlenie minimalnej oceny
        {
            return ratings.Min();
        }
    }
}
