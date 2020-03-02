using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Test.BL;

namespace Test
{
    public partial class Form1 : Form
    {
        public List<QuestionsCollection> Collections { get; private set; }

        public QuestionsCollection CurrentCollection { get; private set; }

        public Form1()
        {
            InitializeComponent();

            Collections = Files.Load();

            CurrentCollection = Collections.FirstOrDefault();

            foreach(var collection in Collections)
                cbxTheme.Items.Add(collection.Theme);
        }

        private void ChangeTheme(object sender, System.EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var theme = comboBox.Text;

            CurrentCollection = Collections.FirstOrDefault(c => c.Theme == theme);

            ChangeQuestions();
        }

        private void ChangeQuestions()
        {
            var question = CurrentCollection.Questions.FirstOrDefault();

            tbxQuestion.Text = question.QuestionText;

            // Довольно костыльная реализация -_-
            rbtnAnswer1.Text = question.Answers.First(a => a.Number == 1).Text;
            rbtnAnswer2.Text = question.Answers.First(a => a.Number == 2).Text;
            rbtnAnswer3.Text = question.Answers.First(a => a.Number == 3).Text;
            rbtnAnswer4.Text = question.Answers.First(a => a.Number == 4).Text;
        }
    }
}