namespace Examination_System;

public class MCQ : Question
{
    public MCQ()
    {
        Header = "MCQ";
        AnswersList = new Answer[4];
        for (int i = 0; i < 4; i++)
        {
            AnswersList[i] = new Answer() { AnswerId = i + 1 };
        }
    }
}