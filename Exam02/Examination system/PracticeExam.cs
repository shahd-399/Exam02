using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public class PracticeExam : Exam
    {
        public List<MCQQuestion> Questions { get; set; }
        public PracticeExam(int time, int numOfQuestions) : base(time, numOfQuestions) 
        {
            Questions = new List<MCQQuestion>();
        }

        public override void ShowExam()
        {
            Console.Clear();

            int MyTotalMarks = 0;
            foreach (var Q in Questions)
            {
                Q.ShowQuestion();

                int userAnswerId = Convert.ToInt32(Console.ReadLine());
                Answer userAnswer = Q.GetRightAnswer(userAnswerId);

                if (Q.CheckAnswer(userAnswer))
                    MyTotalMarks += Q.Mark;
                Console.WriteLine("======================================================================");
            }
            Console.Clear();

            Console.WriteLine("The Right Answer");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1})\t{Questions[i].RightAnswer.AnswerText}");
            }

        }

        public override void CreateExam(int time, int numQuestions)
        {
            for(int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine("Choose One Answer Question");

                Console.Write($"Please Enter The Body of Question Number({i + 1}): ");
                string body = Console.ReadLine();

                Console.Write("Please Enter The Marks of Question: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The Choices Of Question: ");
                List<Answer> answers = new List<Answer>();

                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Please Enter The Choice Number {j}: ");
                    answers.Add(new Answer(j, Console.ReadLine()));
                }

                Answer[] answerArr = answers.ToArray();
                Console.Write("Please Specify The Right Choice of Question: ");
                int rightChoiceId = Convert.ToInt32(Console.ReadLine());

                Answer rightChoice = answerArr[rightChoiceId-1];

                Questions.Add(new MCQQuestion(body, mark, answerArr, rightChoice));

                Console.Clear();
            }
        }
    }
}
