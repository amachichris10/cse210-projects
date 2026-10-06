class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Exercise running = new Running(30, 30.0); // 30 minutes, 30 kilometers
        Exercise cycling = new Cycling(30, 15.0); // 30 minutes, 15 kph
        Exercise swimming = new Swimming(20, 120); // 20 minutes, 120 laps

        List<Exercise> exercises = new List<Exercise> { running, cycling, swimming };

        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary();
        }
    }
}