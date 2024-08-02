namespace Examination_System;

public class Practical : Exam
{
    public Practical(int examTime, int numberOfQuestions) : base(examTime, numberOfQuestions)
    {
    }

    public void QuestionType()
    {
        for (int i = 0; i < NumberOfQuestions; i++)
        {
            Question question = new MCQ();
            Console.WriteLine($"{question.Header}");
            Console.Write("Enter the question body: ");
            question.Body = Console.ReadLine();
            Console.Write("Enter the mark for this question: ");
            question.Mark = int.Parse(Console.ReadLine());
                
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Enter the choice number {j + 1}: ");
                question.AnswersList[j].AnswerText = Console.ReadLine();
            }
            Console.Write("Enter the correct answer (option number): ");
            int correctAnswerId = int.Parse(Console.ReadLine());
            question.CorrectAnswer = question.AnswersList[correctAnswerId - 1];
            Questions[i] = question;
            Console.Clear();
        }

    }
    public override void ShowExam()
    {
        int TotalMarks = 0;
        int MarksFrom = 0;
        foreach (var questions in Questions)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Question Header: {questions.Header}");
            Console.WriteLine($"Question: {questions.Body}");
            Console.WriteLine($"The mark of the question: {questions.Mark}");

            foreach (var answer in questions.AnswersList)
            {
                Console.WriteLine($"Answer {answer.AnswerId}: {answer.AnswerText}");
            }
            Console.Write("Enter your answer choice number: ");
            int ans = int.Parse(Console.ReadLine());
            if (questions.CheckAnswer(ans)) TotalMarks += questions.Mark;
            MarksFrom += questions.Mark;
            Console.Clear();
        }
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--------------- EXAM ANSWERS ---------------");
        for (int i = 0; i < Questions.Length; i++)
        {
            var question = Questions[i];
            Console.WriteLine($"Question {i + 1}) Correct Answer: {question.CorrectAnswer.AnswerText}");
        }
    }
}