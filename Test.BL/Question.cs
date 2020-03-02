using System;
using System.Collections.Generic;
using Test.BL;

namespace Test
{
    /// <summary>
    /// Вопрос.
    /// </summary>
    [Serializable]
    public class Question
    {
        /// <summary>
        /// Номер вопроса.
        /// </summary>
        public int QuestionNumber { get; set; }
        /// <summary>
        /// Текст вопроса.
        /// </summary>
        public string QuestionText { get; set; }
        /// <summary>
        /// Ответы на вопрос.
        /// </summary>
        public List<Answer> Answers { get; set; }

        /// <summary>
        /// Создать новый вопрос.
        /// </summary>
        /// <param name="questionNumber">Номер вопроса.</param>
        /// <param name="questionText">Текст вопроса.</param>
        /// <param name="answers">Варианты ответа на вопрос.</param>
        public Question(int questionNumber, string questionText, List<Answer> answers)
        {
            if (questionNumber <= 0)
                throw new ArgumentException("Номер ответа не может быть меньше либо равен нулю.", nameof(questionNumber));
            if (string.IsNullOrWhiteSpace(questionText))
                throw new ArgumentNullException("Текст вопроса не может быть пустым.", nameof(questionText));
            if (answers == null)
                throw new ArgumentNullException("Количество ответов на вопрос не может быть нулевым.", nameof(answers));

            // Лень заморачиваться с количеством ответов. Их всегда будет 4.
            if (answers.Count != 4)
                throw new ArgumentException("Количество ответов на вопрос может быть равно только 4", nameof(answers));

            QuestionNumber = questionNumber;
            QuestionText = questionText;
            Answers = answers;
        }
    }
}