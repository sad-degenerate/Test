using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Test.BL;

namespace Test
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Номер текущего вопроса.
        /// </summary>
        public int CurrentQuestionNumber { get; set; }
        /// <summary>
        /// Все коллекции вопросов.
        /// </summary>
        public List<QuestionsCollection> Collections { get; private set; }
        /// <summary>
        /// Текущая коллекция вопросов.
        /// </summary>
        public QuestionsCollection CurrentCollection { get; private set; }

        public Form1()
        {
            InitializeComponent();

            Collections = Files.Load();

            CurrentCollection = Collections.FirstOrDefault();

            foreach(var collection in Collections)
                cbxTheme.Items.Add(collection.Theme);
        }

        /// <summary>
        /// Сменить тему.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeTheme(object sender, System.EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var theme = comboBox.Text;

            CurrentCollection = Collections.FirstOrDefault(c => c.Theme == theme);

            CurrentQuestionNumber = ChangeQuestions(1);

            btnSend.Enabled = true;

            progressBar.Maximum = CurrentCollection.QuestionsCount;
        }

        /// <summary>
        /// Сменить вопрос.
        /// </summary>
        /// <param name="number">Номер вопроса.</param>
        /// <returns>Номер вопроса.</returns>
        private int ChangeQuestions(int number)
        {
            var question = CurrentCollection.Questions.FirstOrDefault(q => q.QuestionNumber == number);

            if (question != null)
            {
                tbxQuestion.Text = question.QuestionText;

                // Довольно костыльная реализация -_-
                rbtnAnswer1.Text = question.Answers.First(a => a.Number == 1).Text;
                rbtnAnswer2.Text = question.Answers.First(a => a.Number == 2).Text;
                rbtnAnswer3.Text = question.Answers.First(a => a.Number == 3).Text;
                rbtnAnswer4.Text = question.Answers.First(a => a.Number == 4).Text;
            }
            else
            {
                if (CurrentCollection.QuestionsCount == CurrentQuestionNumber)
                    MessageBox.Show("Вопросы кончились!", "Вопрос не найден");
                else
                    MessageBox.Show("Вопрос не найден!", "Вопрос не найден");

                return CurrentQuestionNumber;
            }

            progressBar.Value = number;

            return number;
        }

        /// <summary>
        /// Проверить ответ на правильность.
        /// </summary>
        /// <param name="number">Номер ответа.</param>
        /// <returns>Правильный ли ответ.</returns>
        private bool CheckAnswer(int number)
        {
            var question = CurrentCollection.Questions.FirstOrDefault(q => q.QuestionNumber == CurrentQuestionNumber);

            var answer = question.Answers.FirstOrDefault(a => a.Number == number);

            return answer.IsCorrect;
        }

        /// <summary>
        /// Ответить на вопрос.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reply(object sender, System.EventArgs e)
        {
            foreach(Control control in gbx.Controls)
                if(control is RadioButton)
                {
                    var btn = (RadioButton)control;

                    if (btn.Checked)
                    {
                        var tag = int.Parse(btn.Tag.ToString());

                        if (CheckAnswer(tag))
                            CurrentQuestionNumber = ChangeQuestions(CurrentQuestionNumber + 1);
                        else
                            MessageBox.Show("Выбранный вами ответ - неверный!", "Неверный ответ");
                    }
                }

            if (progressBar.Value == progressBar.Maximum)
            {
                MessageBox.Show("Тест окончен!", "Мои поздравления! Тест был пройден!");
                ChangeQuestions(1);
            }
        }
    }
}