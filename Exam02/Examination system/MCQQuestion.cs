using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, Answer[] answers, Answer rightAnswer) 
        : base(body, mark, answers, rightAnswer) { }

        public override string Header => "Choose One Answer Question";
    }
}
