
public class PiCalc
{
    /// <summary>
    /// Executes the calculation of an 
    /// approximate value of pi.
    /// </summary>
    /// <param name="iterations">Number of iterations to perform</param>
    /// <returns>Approximate value of pi</returns>
    public double Calculate(int iterations)
    {
        int insideUnitCircleA = 0;
        int insideUnitCircleB = 0;
        int insideUnitCircleC = 0;
        int insideUnitCircleD = 0;

        Task t1 = new Task(() => { insideUnitCircleA = Iterate(iterations / 4); });
        Task t2 = new Task(() => { insideUnitCircleB = Iterate(iterations / 4); });
        Task t3 = new Task(() => { insideUnitCircleC = Iterate(iterations / 4); });
        Task t4 = new Task(() => { insideUnitCircleD = Iterate(iterations / 4); });

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        Task.WaitAll(t1,t2,t3,t4);

        return (insideUnitCircleA + insideUnitCircleB + insideUnitCircleC + insideUnitCircleD) * 4.0 / iterations;
    }

    /// <summary>
    /// Perform a number of "dart-throwing" simulations.
    /// </summary>
    /// <param name="iterations">Number of dart-throws to perform</param>
    /// <returns>Number of throws within the unit circle</returns>
    public int Iterate(int iterations)
    {
        Random _generator = new Random(Guid.NewGuid().GetHashCode());
        int insideUnitCircle = 0;

        for (int i = 0; i < iterations; i++)
        {
            double x = _generator.NextDouble();
            double y = _generator.NextDouble();

            if (x * x + y * y < 1.0)
            {
                insideUnitCircle++;
            }
        }

        return insideUnitCircle;
    }
}
