// Arrays
string[] answerKeys = new string[5] { "a", "b", "c", "d", "e" };
string[] userAnswers = new string[5];

// Variables
int correctAnswersNumber = 0;
int incorrectAnswersNumber = 0;
int emptyAnswerNumber = 0;
int examScore;

// User Input Section
for (int i = 0; i < answerKeys.Length; i++)
{
    Console.Write($"Enter {i + 1}. Answer: ");
    string userAnswer = Console.ReadLine();
    userAnswers[i] = userAnswer;
}

// Compare Answers Loop
for (int i = 0; i < answerKeys.Length; i++)
{
    if (answerKeys[i] == userAnswers[i])
    {
        correctAnswersNumber++;
    }
    else if (userAnswers[i] == string.Empty)
    {
        emptyAnswerNumber++;
    }
    else
    {
        incorrectAnswersNumber++;
    }
}

// Calculate Exam Score
examScore = correctAnswersNumber - (incorrectAnswersNumber / 3);

// Output
Console.Clear();
Console.WriteLine($"Correct Answer Number:  \t{correctAnswersNumber}");
Console.WriteLine($"Incorrect Answer Number:\t{incorrectAnswersNumber}");
Console.WriteLine($"Empty Answer Number:    \t{emptyAnswerNumber}");
Console.WriteLine($"Your Exam Net is:       \t{examScore}");