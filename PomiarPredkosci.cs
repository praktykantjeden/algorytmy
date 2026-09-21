using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] measurements = new int[n];
            int maxPossibleSum = 0;

            for (int i = 0; i < n; i++)
            {
                measurements[i] = int.Parse(Console.ReadLine());
                maxPossibleSum += measurements[i];
            }

            HashSet<int> currentSpeeds = new HashSet<int>();
            currentSpeeds.Add(0); 

            for (int i = 0; i < n; i++)
            {
                int diff = measurements[i];
                HashSet<int> nextSpeeds = new HashSet<int>();

                foreach (int speed in currentSpeeds)
                {
                    nextSpeeds.Add(speed + diff);
                    nextSpeeds.Add(speed - diff);
                }

                currentSpeeds = nextSpeeds;
            }

            int minAbsSpeed = int.MaxValue;
            foreach (int speed in currentSpeeds)
            {
                int abs = Math.Abs(speed);
                if (abs < minAbsSpeed)
                {
                    minAbsSpeed = abs;
                }
            }

            int maxAbsSpeed = maxPossibleSum;

            Console.WriteLine($"{minAbsSpeed} {maxAbsSpeed}");
        }
    }
}
