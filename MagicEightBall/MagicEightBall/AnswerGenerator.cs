using System;

namespace MagicEightBall
{
    class AnswerGenerator
    {
        private static string[] answers = new string[]
        {
            "It is certain.",
            "It is decidedly so.",
            "Without a doubt.",
            "Yes – definitely.",
            "You may rely on it.",
            "As I see it, yes.",
            "Most likely.",
            "Outlook good.",
            "Yes.",
            "Signs point to yes.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Very doubtful."
        };

        public static string GenerateAnswer()
        {
            var generator = new Random();
            var answer = answers[generator.Next(0, answers.Length)];

            return answer;
        }
    }
}
