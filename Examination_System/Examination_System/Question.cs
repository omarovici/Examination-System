namespace Examination_System;

public class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public Answer[] AnswersList { get; set; }
    public Answer CorrectAnswer { get; set; }

    public bool CheckAnswer(int answer) => CorrectAnswer.AnswerId == answer;
}