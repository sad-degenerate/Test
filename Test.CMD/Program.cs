using System;
using System.Collections.Generic;
using System.Linq;
using Test.BL;

namespace Test.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВНИМАНИЕ!!!\nПри некорректном вводе данных вы сами ответственны за свои ошибки!\n");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "help":
                        Help();
                        break;

                    case "add":
                        Add();
                        break;

                    case "edit":
                        Edit();
                        break;

                    case "delete":
                        Delete();
                        break;

                    case "show all":
                        ShowAll();
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Попробуй ввести что-то ещё -_- (например - help)");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void ShowAll()
        {
            var collections = Files.Load();

            foreach(var collection in collections)
            {
                Console.WriteLine(collection.Theme + "\n");

                foreach(var question in collection.Questions)
                {
                    Console.WriteLine("Вопрос №{0} - {1}", question.QuestionNumber, question.QuestionText);

                    foreach(var answer in question.Answers)
                    {
                        Console.WriteLine("Ответ №{0} - {1} ({2})", answer.Number, answer.Text, answer.IsCorrect);
                    }
                }
            }
        }

        private static void Delete()
        {
            throw new NotImplementedException();
        }

        private static void Edit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавление нового сборника вопросов.
        /// </summary>
        private static void Add()
        {
            Console.Clear();

            Console.WriteLine("Добавление сборника вопросов:\n");
            Console.WriteLine("Дисклеймер:");
            Console.WriteLine("При закрытии приложения во время добавления сборника вопросов - изменения не сохраняются," +
                                " а поменять что-то в сборнике можно будет только после окончания создания.\n");

            Console.Write("Введите количество вопросов: ");
            int questionsCount = int.Parse(Console.ReadLine());

            Console.Write("Введите тему сборника вопросов: ");
            string theme = Console.ReadLine();

            var questions = CreateQuestions(questionsCount);

            try
            {
                var questionsCollection = new QuestionsCollection(questionsCount, theme, questions);

                Files.SaveCollection(questionsCollection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }

        /// <summary>
        /// Создать вопросы для сборника вопросов.
        /// </summary>
        /// <param name="count">Количество вопросов.</param>
        /// <returns>Список вопросов.</returns>
        private static List<Question> CreateQuestions(int count)
        {
            var questions = new List<Question>();

            Console.WriteLine("\nСоздание вопросов:\n");
            Console.WriteLine("Дисклеймер:");
            Console.WriteLine("Если вы не введете хоть один верный ответ, то ответ, который будет помечен как \"верный\"," +
                                " будет выбран константно (то есть программой и это число будет одинаковым " +
                                "для всех вопросов с не отмеченным правильным ответом).\n");

            for (int i = 1; i <= count; i++)
            {
                //Да-да тафталогия, мне пофиг.
                Console.WriteLine("Введите текст вопроса {0}-го вопроса: ", i);
                string text = Console.ReadLine();

                var answers = new List<Answer>();
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("Введите текст {0}-го ответа: ", j);
                    var answerText = Console.ReadLine();

                    Console.Write("Он правильный? (введите true или false): ");
                    var isCorrect = bool.Parse(Console.ReadLine());

                    var answer = new Answer(j, answerText, isCorrect);
                    answers.Add(answer);
                }

                answers = CheckAnswers(answers);

                var question = new Question(i, text, answers);

                questions.Add(question);
            }

            return questions;
        }

        /// <summary>
        /// Проверка ответов на правильность.
        /// </summary>
        /// <param name="answers">Ответы.</param>
        /// <returns>Ответы.</returns>
        private static List<Answer> CheckAnswers(List<Answer> answers)
        {
            var count = 0;
            foreach (var answer in answers)
                if (answer.IsCorrect)
                    count++;

            if (count == 0)
                answers.First().IsCorrect = true;
            if(count > 1)
            {
                foreach (var answer in answers)
                    answer.IsCorrect = false;
                answers.First().IsCorrect = true;
            }

            return answers;
        }

        /// <summary>
        /// Вывод всех возможных команд.
        /// </summary>
        private static void Help()
        {
            Console.WriteLine("help - получение справки");
            Console.WriteLine("add - добавление вопроса");
            Console.WriteLine("edit - редактирование вопроса");
            Console.WriteLine("delete - удаление вопроса");
            Console.WriteLine("exit - выход из программы");
        }
    }
}