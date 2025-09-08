//Challenge 6
int[] testScores = [100, 90, 30, 88, 75, 93];

//Write the C# to determine the BEST score, the WORST score, the AVERAGE score, the SUM

int best = 0;
int worst = 100;
int sum = 0;

foreach (int i in testScores)
{
    best = int.Max(best, i);
    worst = int.Min(worst, i);
    sum += i;
}

Console.WriteLine($"Best: {best}\nWorst: {worst}\nSum: {sum}\nAverage: {sum / 6}");