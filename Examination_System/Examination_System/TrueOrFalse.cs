namespace Examination_System;

public class TrueOrFalse : Question
{
    public TrueOrFalse()
    {
        Header = "True/False";
        AnswersList = new Answer[2]
        {
            new Answer{AnswerId = 1,AnswerText = "True"},
            new Answer{AnswerId = 2,AnswerText = "False"},
        };
    }
}