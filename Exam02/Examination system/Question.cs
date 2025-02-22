using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        protected Question(string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }
        public Answer GetRightAnswer(int id)
        {
            return AnswerList[id-1];
        }
        public void ShowQuestion()
        {
            Console.WriteLine($"*{Header} \t Mark({Mark})");
            Console.WriteLine($"{Body}");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.Write($"{AnswerList[i].AnswerId}.{AnswerList[i].AnswerText} \t");
            }
            Console.WriteLine();
            Console.WriteLine("***********************************************************************");
        }
        public bool CheckAnswer(Answer userAnswer)
        {
            return userAnswer.Equals(RightAnswer);
        }
    }
}
