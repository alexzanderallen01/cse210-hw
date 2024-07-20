using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();

        Running running = new Running("Nov 3, 2022", 30, 3); //Add stuff here
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("Nov 4, 2022", 60, 3); //add stuff here
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("05 Nov 2022", 10, 10); //add stuff here
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises: ");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}