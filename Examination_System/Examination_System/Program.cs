using System.Diagnostics;

namespace Examination_System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Subject s01 = new Subject(10, "C#");
        s01.CreateExam();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Do you want to start the exam (y|n):");
        if (char.Parse(Console.ReadLine()) == 'y')
        {
            Console.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            s01.ExamType.ShowExam();
            sw.Stop();
            Console.WriteLine($"The elapsed time = {sw.Elapsed}");
        }
    }
}