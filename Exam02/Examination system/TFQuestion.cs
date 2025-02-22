using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Examination_system
{
    internal class TFQuestion : Question
    {
        public TFQuestion(string body, int mark, Answer rightAnswer) 
        : base(body, mark,new Answer[2]{new Answer(1, "True"),new Answer(2, "False")}, 
          rightAnswer) { }

        public override string Header => "True | False Question"; 
    
    }
}
