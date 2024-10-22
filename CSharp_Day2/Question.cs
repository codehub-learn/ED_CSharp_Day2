using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day2
{
    internal class Question<T1, T2>
    {
        public T1 Ask { get; set; }
        public T2 Answer { get; set; }
        public T1 GetAsk()
        {
            return Ask;
        }

        public void SetAsk (T1 ask)
        {
            Ask = ask;
        }

        public T2 GetAnswer()
        {
            return Answer;
        }

        public void SetAnswer(T2 answer) 
        { 
            Answer = answer;
        }
    }
}
