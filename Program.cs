using System;
using System.Threading;

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Seconds => 10s = 10 seconds");
    Console.WriteLine("M = Minutes => 1m = 1 minute");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("How long do you want to count?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    if (time == 0)
        Environment.Exit(0);

    PreStart(time * multiplier);
}

void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go!");
    Thread.Sleep(2500);

    Start(time);
}

void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("StopWatch finished!");
    Thread.Sleep(2500);
    Menu();
}
