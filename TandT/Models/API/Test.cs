using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class Test : MongoModel
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public List<string> AnswerOptions { get; set; }
    }
}
