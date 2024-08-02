namespace Examination_System;

public class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public Exam ExamType { get; set; }
    
    public Subject(int subjectId, string subjectName)
    {
        SubjectId = subjectId;
        SubjectName = subjectName;
    }

    public void CreateExam()
    {
        Console.Write("Please choose exam type (1.Final | 2.Practical): ");
        int choose = int.Parse(Console.ReadLine());
        Console.Write("Please enter the time of exam in minutes: ");
        int time = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of questions: ");
        int num = int.Parse(Console.ReadLine());
        Console.Clear();
        if (choose == 1)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Final final = new Final(time, num);
            final.QuestionType();
            ExamType = final;
        }
        else if (choose == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Practical practical = new Practical(time, num);
            practical.QuestionType();
            ExamType = practical;
        }
    }
}