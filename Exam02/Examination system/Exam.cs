using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public int NumOfQuestions { get; set; }

        public Exam(int time, int numOfQuestions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
        }

        public abstract void ShowExam();

        public abstract void CreateExam(int time , int numQuestions);
    }
}
