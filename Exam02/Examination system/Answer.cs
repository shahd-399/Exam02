using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override bool Equals(object obj)
        {
            if (obj is Answer other)
                return AnswerId == other.AnswerId ;
            return false;
        }
    }
}
