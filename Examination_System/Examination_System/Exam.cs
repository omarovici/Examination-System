namespace Examination_System;

public abstract class Exam
{
    public int ExamTime { get; set; }
    public int NumberOfQuestions { get; set; }
    public Question[] Questions { get; set; }
    public abstract void ShowExam();
    public Exam(int examTime, int numberOfQuestions)
    {
        ExamTime = examTime;
        NumberOfQuestions = numberOfQuestions;
        Questions = new Question[numberOfQuestions];
    }
}