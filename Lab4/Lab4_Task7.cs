using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] tracks =
        {
            "Gentle Giant – Free Hand [6:15]",
            "Supertramp – Child Of Vision [07:27]",
            "Camel – Lawrence [10:46]",
            "Yes – Don’t Kill The Whale [3:55]",
            "10CC – Notell Hotel [04:58]",
            "Nektar – King Of Twilight [4:16]",
            "The Flower Kings – Monsters & Men [21:19]",
            "Focus – Le Clochard [1:59]",
            "Pendragon – Fallen Dream And Angel [5:23]",
            "Kaipa – Remains Of The Day (08:02)"
        };

        int[] time = new int[10];
        Regex r = new Regex(@"(\d{1,2}):(\d{2})");

        for (int i = 0; i < tracks.Length; i++)
        {
            Match m = r.Match(tracks[i]);
            int min = int.Parse(m.Groups[1].Value);
            int sec = int.Parse(m.Groups[2].Value);
            time[i] = min * 60 + sec;
        }

        int total = 0;
        foreach (int t in time) total += t;

        int minIndex = 0, maxIndex = 0;
        for (int i = 1; i < time.Length; i++)
        {
            if (time[i] < time[minIndex]) minIndex = i;
            if (time[i] > time[maxIndex]) maxIndex = i;
        }

        int bestDiff = int.MaxValue;
        int p1 = 0, p2 = 1;
        for (int i = 0; i < time.Length; i++)
            for (int j = i + 1; j < time.Length; j++)
            {
                int diff = Math.Abs(time[i] - time[j]);
                if (diff < bestDiff)
                {
                    bestDiff = diff;
                    p1 = i;
                    p2 = j;
                }
            }

        Console.WriteLine($"Общее время: {total / 60}:{total % 60:D2}");
        Console.WriteLine("Самая короткая: " + tracks[minIndex]);
        Console.WriteLine("Самая длинная: " + tracks[maxIndex]);
        Console.WriteLine("Минимальная разница:");
        Console.WriteLine(tracks[p1]);
        Console.WriteLine(tracks[p2]);
    }
}
