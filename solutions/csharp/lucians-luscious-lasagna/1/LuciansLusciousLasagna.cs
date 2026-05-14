class Lasagna
{
    public int ExpectedMinutesInOven()
    => 40;

    public int RemainingMinutesInOven(int minutes)
    => 40 - minutes;

    public int PreparationTimeInMinutes(int layers)
    => 2 * layers;

    public int ElapsedTimeInMinutes(int layers, int minutes)
    => PreparationTimeInMinutes(layers) + minutes;
}
