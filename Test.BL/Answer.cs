using System;

namespace Test.BL
{
    /// <summary>
    /// Ответ на вопрос.
    /// </summary>
    [Serializable]
    public class Answer
    {
        /// <summary>
        /// Номер ответа.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Текст ответа.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Верный ли ответ.
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// Создать новый ответ на вопрос.
        /// </summary>
        /// <param name="number">Номер ответа.</param>
        /// <param name="text">Текст ответа.</param>
        /// <param name="isCorrect">Верный ли ответ.</param>
        public Answer(int number, string text, bool isCorrect)
        {
            if (number <= 0)
                throw new ArgumentException("Номер вопроса не может быть меньше или равен нулю.", nameof(number));
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException("Текст вопроса не может быть пустым.", nameof(text));

            // Не требуется увеличение/уменьшение количество ответов. Везде используется константа - 4.
            if (number > 4)
                throw new ArgumentException("Номер вопроса не может быть больше 4.", nameof(number));

            Number = number;
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}