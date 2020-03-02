using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// Сборник вопросов.
    /// </summary>
    [Serializable]
    public class QuestionsCollection
    {
        /// <summary>
        /// Количество вопросов в сборнике.
        /// </summary>
        public int QuestionsCount { get; set; }
        /// <summary>
        /// Тема сборника вопросов.
        /// </summary>
        public string Theme { get; set; }
        /// <summary>
        /// Вопросы сборника.
        /// </summary>
        public List<Question> Questions { get; set; }

        /// <summary>
        /// Создать новый сборник вопросов.
        /// </summary>
        /// <param name="questionsCount">Количество вопросов.</param>
        /// <param name="theme">Тема.</param>
        /// <param name="questions">Список вопросов.</param>
        public QuestionsCollection(int questionsCount, string theme, List<Question> questions)
        {
            if (questionsCount <= 0)
                throw new ArgumentException("Количество вопросов не может быть меньше или равно нулю.", nameof(questionsCount));
            if (string.IsNullOrWhiteSpace(theme))
                throw new ArgumentNullException("Тема сборника вопросов не может быть пустой.", nameof(theme));
            if (questions.Count == 0)
                throw new ArgumentNullException("Количество вопросов сборника не может быть равно нулю.", nameof(questions));

            QuestionsCount = questionsCount;
            Theme = theme;
            Questions = questions;
        }
    }
}