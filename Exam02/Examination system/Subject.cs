using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create(1 for Practical, 2 for Final): ");
            int examType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The Time Of Exam in Minutes: ");
            int examTime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The Number of Questions You Wanted To Create: ");
            int numQuestions = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            if(examType == 1)
            {
                Exam = new PracticeExam(examTime, numQuestions);
                Exam.CreateExam(Exam.Time, Exam.NumOfQuestions);
            }
            if(examType == 2) 
            {
                Exam = new FinalExam(examTime, numQuestions);
                Exam.CreateExam(Exam.Time, Exam.NumOfQuestions);
            }

        }
    }
}
