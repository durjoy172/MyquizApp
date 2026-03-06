namespace MyquizApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Questions[] questions = 
            {
                new Questions("What is the capital of Germany1", 
                new string[]{"Paris","Berlin","London","Madrid"},
                1),
                new Questions("Which planet is known as the Red Planet?",
                new string[]{"Earth","Mars","Jupiter","Saturn"},
                1),

                new Questions("Who developed the C# programming language?",
                new string[]{"James Gosling","Anders Hejlsberg","Dennis Ritchie","Bjarne Stroustrup"},
                1),

                new Questions("What is the largest ocean on Earth?",
                new string[]{"Atlantic Ocean","Indian Ocean","Pacific Ocean","Arctic Ocean"},
                2),

                new Questions("Which data type is used to store true or false values in C#?",
                new string[]{"int","string","bool","char"},
                2)
            };
            
            
            Quiz myQuiz= new Quiz(questions);
            myQuiz.StartQuiz();
            Console.WriteLine($"Your total Score For the Quiz is: {myQuiz.Result}");
            Console.ReadKey();
        }
    }
}
