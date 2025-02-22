
using Exam02.Examination_system;
using System.Diagnostics;

Subject Sub1 = new Subject(10, "C#");
Sub1.CreateExam();
Console.Clear();
Console.Write("Subject.CreateExam The Exam (y/n): ");

if (char.Parse(Console.ReadLine()) == 'y')
{
    Stopwatch SW = new Stopwatch();
    SW.Start();
    Sub1.Exam.ShowExam();
    Console.WriteLine($"The Elapsed Time: {SW.Elapsed}");
}