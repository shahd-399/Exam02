using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public class FinalExam : Exam
    {
        public List<Question> Questions { get; set; }
        public List<string> AnsString { get; set; }
        public FinalExam(int time, int numOfQuestions) : base(time, numOfQuestions) 
        {
            Questions = new List<Question>();
            AnsString = new List<string>();
        }
        public override void ShowExam()
        {
            Console.Clear();

            int MyTotalMarks = 0;
            int Grade = 0;

            foreach (var Q in Questions)
            {
                Q.ShowQuestion();

                int userAnswerId = Convert.ToInt32(Console.ReadLine());
                Answer userAnswer = Q.GetRightAnswer(userAnswerId);
                AnsString.Add(userAnswer.AnswerText);

                if (Q.CheckAnswer(userAnswer))
                    MyTotalMarks += Q.Mark;

                Grade += Q.Mark;

                Console.WriteLine("======================================================================");
            }
            Console.Clear();

            Console.WriteLine("Your Answers: ");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1})\t{Questions[i].Body}: {AnsString[i]}");
            }

            Console.WriteLine($"Your Exam Grade Is {MyTotalMarks} from {Grade}");
        }

        public override void CreateExam(int time, int numQuestions)
        {
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"Please Choose The Type of Question Number({i + 1}) (1 for True/False, 2 for MCQ): ");
                int type = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (type == 1)
                {
                    Console.WriteLine("True | False Question: ");


                    Console.Write($"Please Enter The Body of Question ");
                    string body = Console.ReadLine();

                    Console.Write("Please Enter The Marks of Question: ");
                    int mark = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter The Right Answer Of Question (1 for True, 2 for False): ");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    Answer rightAnswer = new Answer(rightAnswerId, rightAnswerId == 1 ? "True" : "False");

                    Questions.Add(new TFQuestion(body, mark, rightAnswer));
                }

                if (type == 2)
                {
                    Console.WriteLine("Choose One Answer Question: ");


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

                    Answer rightChoice = answerArr[rightChoiceId - 1];

                    Questions.Add(new MCQQuestion(body, mark, answerArr, rightChoice));

                }

                Console.Clear();
            }
        }
    }
}
