using System;
using System.Collections.Generic;
using System.Text;

namespace MyquizApp
{
    internal class Quiz
    {
        private Questions[] questions;

        private static int result = 0;
        public int Result{ get { return result; } }


        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;
            foreach (Questions questions in questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(questions);
                int userChoice=GetUserChoice();
                if (questions.IsCorrectAnswer(userChoice)) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Correct");
                    Console.ResetColor();
                    result++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Incorrect! The correct answer is {questions.Answers[questions.CorrectAnswerIndex]}");
                    Console.ResetColor();
                }
            }
        }
        private void DisplayQuestion(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================================================");
            Console.WriteLine("||                    Question                 ||");
            Console.WriteLine("=================================================");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($".{question.Answers[i]}");
            }
           
        }

        
        private int GetUserChoice()
        {
            Console.WriteLine("Your Answer (number): ");
            string input=Console.ReadLine();
            int choice=0;
            while (!int.TryParse(input, out choice)||choice<1||choice>4 )
            {
                Console.WriteLine("Invalid Input. Please enter a number between 1-4: ");
                input = Console.ReadLine();
            }
            return choice-1;
        }
    }
}
