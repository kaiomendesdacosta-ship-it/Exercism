class BirdCount(int[] birdsPerDay)
{
    private readonly int[] birdsPerDay = birdsPerDay;

    public static int[] LastWeek()
    => [0, 2, 5, 3, 7, 8, 4];

    public int Today()
    => birdsPerDay.LastOrDefault();

    public void IncrementTodaysCount()
    => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    => birdsPerDay.Any(d => d == 0);
    
    public int CountForFirstDays(int numberOfDays)
    => birdsPerDay.Take(0..numberOfDays).Sum();

    public int BusyDays()
    => birdsPerDay.Count(d => d >= 5);
}
