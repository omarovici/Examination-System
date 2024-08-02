# Examination System

Welcome to the Examination System project! This C# application allows users to create, manage, and conduct different types of exams with ease.

## Features

- **Exam Types:** Supports both Final and Practical exams.
- **Question Types:** Includes Multiple-Choice Questions (MCQ) and True/False questions.
- **Dynamic Question Entry:** Allows entering questions and their respective answers during exam creation.
- **Automatic Scoring:** Evaluates answers and provides total marks at the end of the exam.
- **User-Friendly Interface:** Console-based interaction for seamless user experience.

## Classes and Structure

### Main Classes

- **Answer**
  - `AnswerId` (int): Unique identifier for the answer.
  - `AnswerText` (string): Text of the answer.

- **Question (Abstract)**
  - `Header` (string): Header of the question type.
  - `Body` (string): Main text of the question.
  - `Mark` (int): Mark assigned to the question.
  - `AnswersList` (Answer[]): List of possible answers.
  - `CorrectAnswer` (Answer): The correct answer for the question.
  - `CheckAnswer(int answer)` (bool): Method to check if the given answer is correct.

- **TrueOrFalse**
  - Inherits from `Question`.
  - Initializes with "True" and "False" answers.

- **MCQ**
  - Inherits from `Question`.
  - Initializes with four answer choices.

- **Exam (Abstract)**
  - `ExamTime` (int): Duration of the exam.
  - `NumberOfQuestions` (int): Number of questions in the exam.
  - `Questions` (Question[]): Array of questions.
  - `ShowExam()`: Abstract method to display the exam.

- **Final**
  - Inherits from `Exam`.
  - Provides methods to enter questions and display the final exam.

- **Practical**
  - Inherits from `Exam`.
  - Provides methods to enter questions and display the practical exam.

- **Subject**
  - `SubjectId` (int): Unique identifier for the subject.
  - `SubjectName` (string): Name of the subject.
  - `ExamType` (Exam): The type of exam (Final or Practical).
  - `CreateExam()`: Method to create an exam for the subject.

## Usage

1. **Clone the repository:**
    ```bash
    git clone https://github.com/omarovici/Examination-System.git
    cd Examination-System
    ```

2. **Build and run the project:**
    Use your preferred C# IDE or .NET CLI to build and run the project.

3. **Create an exam:**
    Follow the prompts in the console to create a final or practical exam by entering the required details.

4. **Start the exam:**
    After creating the exam, you can start it, answer the questions, and receive your total marks at the end.
