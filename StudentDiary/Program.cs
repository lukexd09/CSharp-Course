using System;


namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary= new Diary();
            diary.AddRating(5);
            Console.WriteLine(diary.CalculateAverage());
        }
    }
}
